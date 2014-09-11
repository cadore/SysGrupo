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
using DevExpress.XtraSplashScreen;
using SysNorteGrupo.UI.Utils;
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.UI.Financeiro
{
    public partial class GerarContasAReceberForm : DevExpress.XtraEditors.XtraUserControl
    {
        public FormPrincipal desk = null;
        IServiceGrupo conn;
        DateTime now;

        List<parcelas_veiculos_cc> pvTemp = new List<parcelas_veiculos_cc>();
        List<historico_pagamento_sinistros_clientes> psTemp = new List<historico_pagamento_sinistros_clientes>();
        public GerarContasAReceberForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            now = conn.retornaDataHoraLocal();
            configuraComponentes();
            carregaListaClientes();            
        }

        private void configuraComponentes()
        {
            tfDataVencimento.Properties.MinValue = now.Date;
            tfDataVencimentoGridC.MinValue = tfDataVencimento.Properties.MinValue;

            tfMes.EditValue = now.Month;

            tfAno.Properties.MinValue = now.Year - 1;
            tfAno.Properties.MaxValue = now.Year + 1;
            tfAno.EditValue = now.Year;
        }

        void carregaListaClientes()
        {
            List<cliente> listaC = conn.listaDeTodosClientes();
            foreach (cliente c in listaC)
            {
                checkListClientes.Items.Add(c.id, c.nome_completo, CheckState.Checked, true);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            desk.adicionarControleNavegacao(null);
        }

        private void checkListClientes_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (checkListClientes.Items.GetCheckedValues().Count > 0)
            {
                btnGerarContas.Enabled = true;
            }
            else
            {
                btnGerarContas.Enabled = false;
            }
        }

        private void btnGerarContas_Click(object sender, EventArgs e)
        {
            if (!validadorGeracao.Validate())
                return;
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            List<cliente> listaCli = new List<cliente>();
            List<contas_a_receber> contas = new List<contas_a_receber>();
            for (int i = 0; i < checkListClientes.Items.Count; i++)
            {
                if (checkListClientes.Items[i].CheckState == CheckState.Checked)
                    listaCli.Add(conn.retornaClientePorId(Convert.ToInt64(checkListClientes.Items[i].Value)));
            }
            decimal valor_cliente = 0;
            foreach (cliente c in listaCli)
            {
                foreach (parcelas_veiculos_cc pv in conn.listaDeParcelasVeiculosCCPorIdClienteEMesAno(c.id,
                    Convert.ToInt32(tfMes.EditValue), Convert.ToInt32(tfAno.EditValue)))
                {
                    if (!pv.gerado_conta_receber)
                    {
                        valor_cliente += pv.valor;
                        pvTemp.Add(pv);
                    }                       
                }
                
                foreach (parcelas_sinistros ps in conn.listaDeParcelasSinistrosPorIdClienteEMesAno(c.id,
                    Convert.ToInt32(tfMes.EditValue), Convert.ToInt32(tfAno.EditValue)))
                {
                    if (!conn.verificaGeracaoParcelasPorIdParcelaEIdCliente(ps.id, c.id))
                    {
                        sinistro s = conn.retornaSinistroPorId(ps.id_sinistro);
                        decimal valor_bens_cliente = conn.somaDeBensClientePorIdSinistroEIdClienteEInatividadeBens
                            (ps.id_sinistro, c.id, false);
                        decimal valor_cota = (ps.valor / s.cotas_na_data);

                        valor_cliente += ((valor_bens_cliente / ConfigSistema.valor_por_cota) * valor_cota);
                        psTemp.Add(new historico_pagamento_sinistros_clientes()
                        {
                            id_cliente = c.id,
                            id_parcela = ps.id, 
                            id_sinistro = ps.id_sinistro
                        });
                    }
                }
                if (valor_cliente > 0)
                {
                    contas.Add(new contas_a_receber()
                    {
                        data_documento = now.Date,
                        data_vencimento = tfDataVencimento.DateTime.Date,
                        valor_total = valor_cliente,
                        id_cliente = c.id,
                        nome_cliente = c.nome_completo
                    });
                }
                valor_cliente = 0;
            }
            if (contas.Count <= 0)
            {
                XtraMessageBox.Show("Não existe contas à serem geradas.");
                return;
            }
            bdgContasAReceber.DataSource = contas;
            SplashScreenManager.CloseForm(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Confirma a geração das contas à receber?\nNão será possível reverter esta ação!",
                "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs != DialogResult.OK)
                return;
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                conn.salvaContasAReceber((List<contas_a_receber>)bdgContasAReceber.List, pvTemp, psTemp);
                XtraMessageBox.Show("Contas à receber geradas com sucesso!");
                bdgContasAReceber.Clear();
                tfDataVencimento.EditValue = null;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n{0}\n\n{1}", ex.Message, ex.InnerException));
                return;
            }
            finally
            {
                SplashScreenManager.CloseForm(false);
            }
        }
    }
}
