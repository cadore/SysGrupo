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
using WcfLibGrupo;
using EntitiesGrupo;
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.UI.Financeiro
{
    public partial class ParcelasVeiculosForm : DevExpress.XtraEditors.XtraUserControl
    {
        IServiceGrupo conn;
        public FormPrincipal desk = null;
        public ParcelasVeiculosForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            pesquisaVeiculos();
        }

        private void pesquisaVeiculos()
        {
            List<veiculo> listV = conn.listaDeVeiculosPorStatusParcela(false);
            for (int i = 0; i < listV.Count; i++)
            {
                listV[i].nome_cliente = conn.retornaClientePorId(listV[i].id_cliente).nome_completo;
            }
            bdgVeiculosList.DataSource = listV;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            desk.adicionarControleNavegacao(null);
        }

        private void btnGeraParcelas_Click(object sender, EventArgs e)
        {
            string erro = "";
            if (Convert.ToInt64(tfQntParcelasSinistro.EditValue) == 0)
            {
                erro += "- Informe a quatidade de parcelas\n";
            }
            if (Convert.ToDecimal(tfValorParcela.EditValue) <= 0)
            {
                erro += "- Informe o valor da parcela.\n";
            }
            if (Convert.ToInt32(tfMesInicioParcelaSinistro.EditValue) == 0 || Convert.ToInt32(tfMesInicioParcelaSinistro.EditValue) > 12)
            {
                erro += "- Informe um mes válido para inicio da geração das parcelas.\n";
            }
            if (!string.IsNullOrEmpty(erro))
            {
                XtraMessageBox.Show("Corrija os erros abaixo para continuar.\n\n" + erro, "Atenção", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            bdgParcelas.DataSource = new List<ParcelaUtil>();
            bdgParcelas.Clear();
            List<decimal> p = Util.parcelar(Convert.ToDecimal(tfValorParcela.EditValue), Convert.ToInt32(tfQntParcelasSinistro.EditValue));
            int i = 1;
            DateTime dt = new DateTime(conn.retornaDataHoraLocal().Year, Convert.ToInt32(tfMesInicioParcelaSinistro.EditValue), 1);
            foreach (decimal v in p)
            {
                bdgParcelas.List.Add(new ParcelaUtil() { numero_parcelas = i++, mes_parcela = dt.Month, ano_parcela = dt.Year, valor = v });
                dt = dt.AddDays(31);
            }
            tfMesInicioParcelaSinistro.EditValue = 0;
            tfQntParcelasSinistro.EditValue = 0;
            tfValorParcela.EditValue = 0;
        }

        private void cbVeiculo_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbVeiculo.EditValue) > 0)
            {
                veiculo v = conn.retornaVeiculoPorId(Convert.ToInt64(cbVeiculo.EditValue));
                tfId.EditValue = v.id;
                tfDataAtivacao.EditValue = String.Format("{0:dd/MM/yyyy}", v.data_ativacao);
                tfDataCadastro.EditValue = String.Format("{0:dd/MM/yyyy}", v.data_cadastro);    
                bdgVeiculos.DataSource = v;
                pnParcelas.Enabled = true;
            }
            else
            {
                pnParcelas.Enabled = false;
                tfDataAtivacao.EditValue = null;
                tfDataCadastro.EditValue = null;
                tfId.EditValue = null;
            }
        }

        private void btnLimparParcelas_Click(object sender, EventArgs e)
        {
            bdgParcelas.Clear();
        }

        private void btnSalvarParcelas_Click(object sender, EventArgs e)
        {
            if (bdgParcelas.List.Count <= 0)
            {
                XtraMessageBox.Show("É necessário no mínimo um parcelamento para salvar.", "Atenção");
                return;
            }

            try
            {
                veiculo v = (veiculo)bdgVeiculos.Current;
                List<parcelas_veiculos_cc> pv = new List<parcelas_veiculos_cc>();
                foreach (ParcelaUtil pu in bdgParcelas.List)
                {
                    pv.Add(new parcelas_veiculos_cc()
                    {
                        ano_parcela = pu.ano_parcela,
                        mes_parcela = pu.mes_parcela,
                        id_cliente = v.id_cliente,
                        id_veiculo = v.id,
                        numero_parcela = pu.numero_parcelas,
                        valor = pu.valor
                    });
                }
                if (XtraMessageBox.Show("Confirma a geração das parcelas para o veiculo?"
                    + "\nNão será possivel gerar outras parcelas para este veículo.",
                    "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                conn.salvaParcelasVeiculosCC(pv, (veiculo)bdgVeiculos.Current);
                XtraMessageBox.Show("Parcelas salvas com sucesso para o sinistro selecionado.", "Atenção");
                cbVeiculo.EditValue = 0;
                bdgVeiculos.Clear();
                bdgParcelas.Clear();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n{0}\n\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void bdgVeiculos_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}
