using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EntitiesGrupo;
using PetaPoco;
using WcfLibGrupo;
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.UI.Financeiro
{
    public partial class PagamentosSinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal desk = null;

        public PagamentosSinistrosForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            pesquisaSinistrosConcluidos();
        }

        private void pesquisaSinistrosConcluidos()
        {
            List<sinistro> listS = new List<sinistro>();
            foreach (sinistro s in conn.listaDeSinistrosPorSituacao(1))
            {
                veiculo v = new veiculo();
                reboque r1 = new reboque();
                reboque r2 = new reboque();
                reboque r3 = new reboque();
                if (s.id_veiculo > 0) v = conn.retornaVeiculoPorId(s.id_veiculo);
                if (s.id_reboque1 > 0) r1 = conn.retornaReboquePorId(s.id_reboque1);
                if (s.id_reboque2 > 0) r2 = conn.retornaReboquePorId(s.id_reboque2);
                if (s.id_reboque3 > 0) r3 = conn.retornaReboquePorId(s.id_reboque3);
                s.veiculos_reboques = String.Format(@"{0} / {1} / {2} / {3}", v.placa, r1.placa, r2.placa, r3.placa);
                listS.Add(s);
            }
            bdgListSinistros.DataSource = listS;           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            desk.adicionarControleNavegacao(null);
        }

        private void cbSinistros_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbSinistros.EditValue) == 0)
            {
                bdgSinistro.Clear();
                tfValorPorCota.EditValue = null;
                pnParcelasSinistros.Enabled = false;
                return;
            }
            pnParcelasSinistros.Enabled = true;
            sinistro s = conn.retornaSinistroPorId(Convert.ToInt64(cbSinistros.EditValue));
            List<parcelas_sinistros> listParc = conn.listaDeParcelasSinistrosPorIdSinistro(s.id);
            if (listParc.Count > 0)
            {
                XtraMessageBox.Show("Já foi gerado pagamento/parcelamento para este sinistro.", "Atenção");
                cbSinistros.EditValue = 0;
                bdgSinistro.Clear();
                tfValorPorCota.EditValue = null;
                bdgParcelasSinistro.Clear();
                return;
            }
            bdgSinistro.DataSource = s;
        }

        private void btnGeraParcelasSinistro_Click(object sender, EventArgs e)
        {
            string erro = "";
            if (Convert.ToInt64(tfQntParcelasSinistro.EditValue) == 0)
            {
                erro += "- Informe a quatidade de parcelas\n";
            }
            if (Convert.ToInt32(tfMesInicioParcelaSinistro.EditValue) == 0 || Convert.ToInt32(tfMesInicioParcelaSinistro.EditValue) > 12)
            {
                erro += "- Informe um mes válido para inicio da geração das parcelas.";
            }
            if (!string.IsNullOrEmpty(erro))
            {
                    XtraMessageBox.Show("Corrija os erros abaixo para continuar.\n\n" + erro, "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
            }
            bdgParcelasSinistro.DataSource = new List<ParcelaUtil>();
            bdgParcelasSinistro.Clear();
            List<decimal> p = Util.parcelar(Convert.ToDecimal(tfValorTotal.EditValue), Convert.ToInt32(tfQntParcelasSinistro.EditValue));
            int i = 1;
            DateTime dt = new DateTime(conn.retornaDataHoraLocal().Year, Convert.ToInt32(tfMesInicioParcelaSinistro.EditValue), 1);
            foreach (decimal v in p)
            {                
                bdgParcelasSinistro.List.Add(new ParcelaUtil() { numero_parcelas = i++, mes_parcela = dt.Month, ano_parcela = dt.Year, valor = v });
                dt = dt.AddDays(31);
            }
            tfMesInicioParcelaSinistro.EditValue = 0;
            tfQntParcelasSinistro.EditValue = 0;
        }

        private void btnLimparParcelasSinistro_Click(object sender, EventArgs e)
        {
            bdgParcelasSinistro.Clear();
        }

        private void btnSalvarParcelasSinistro_Click(object sender, EventArgs e)
        {
            if (bdgParcelasSinistro.List.Count <= 0)
            {
                XtraMessageBox.Show("É necessário no mínimo um parcelamento para salvar.", "Atenção");
                return;
            }
            
            try
            {
                sinistro s = (sinistro)bdgSinistro.Current;
                List<parcelas_sinistros> ps = new List<parcelas_sinistros>();
                foreach (ParcelaUtil pu in bdgParcelasSinistro.List)
                {
                    ps.Add(new parcelas_sinistros() 
                    { 
                        ano_parcela = pu.ano_parcela, 
                        mes_parcela = pu.mes_parcela, 
                        id_cliente = s.id_cliente, 
                        id_sinistro = s.id, 
                        numero_parcela = pu.numero_parcelas, 
                        valor = pu.valor
                    });
                }
                if (XtraMessageBox.Show("Confirma a geração do pagamento/parcelas para o sinistro?"
                    + "\nNão será possivel reverter esta ação.", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    == DialogResult.Cancel)
                    return;
                conn.salvarParcelasSinistro(ps);
                XtraMessageBox.Show("Parcelas salvas com sucesso para o sinistro selecionado.", "Atenção");
                cbSinistros.EditValue = 0;
                bdgSinistro.Clear();
                bdgParcelasSinistro.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n{0}\n\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void bdgSinistro_CurrentItemChanged(object sender, EventArgs e)
        {
            if (bdgSinistro.Current != null)
            {
                tfValorPorCota.EditValue = String.Format("{0:c2}",
                    ((sinistro)bdgSinistro.Current).valor_total / ((sinistro)bdgSinistro.Current).cotas_na_data);
            }
        }
    }
}
