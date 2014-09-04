using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfLibGrupo;
using DevExpress.XtraSplashScreen;
using SysNorteGrupo.Reports.Clientes;
using DevExpress.XtraReports.UI;
using SysNorteGrupo.Utils;
using EntitiesGrupo;

namespace SysNorteGrupo.Reports
{
    public partial class RelatorioClientesECotasSubForm : DevExpress.XtraEditors.XtraForm
    {
        IServiceGrupo conn;
        public RelatorioClientesECotasSubForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            rgTipo.EditValue = 0;
            tfDataInicial.DateTime = new DateTime(2014, 04, 01);
            tfDataFinal.DateTime = conn.retornaDataHoraLocal().Date;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rgTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(rgTipo.EditValue);
            if (i == 1)
            {
                panelDatas.Enabled = true;
            }
            else
            {
                panelDatas.Enabled = false;
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                int tipo = Convert.ToInt32(rgTipo.EditValue);
                SplashScreenManager.ShowForm(typeof(SysNorteGrupo.UI.Utils.PleaseWaitForm), false, false);
                bool inatividadeCliente = false;
                bool inatividadeItens = false;
                List<RelatorioClientesECotasModel> listReport = new List<RelatorioClientesECotasModel>();
                List<cliente> listClientes;
                decimal total_cotas_grupo;
                if (tipo == 0)
                {
                    listClientes = conn.listaDeClientesPorInatividade(inatividadeCliente);
                    total_cotas_grupo = conn.retornaTotalDeBensDaEmpresaPorInatividade(inatividadeItens) / ConfigSistema.valor_por_cota;
                }
                else
                {
                    listClientes = conn.listaDeClientesPorInatividadeEDataAtivacao(inatividadeCliente,
                        tfDataInicial.DateTime.Date, tfDataFinal.DateTime.Date);
                    total_cotas_grupo = conn.retornaTotalDeBensDaEmpresaPorInatividadeEDataAtivacao(inatividadeItens,
                        tfDataInicial.DateTime.Date, tfDataFinal.DateTime.Date) / ConfigSistema.valor_por_cota;
                }

                foreach (cliente c in listClientes)
                {                
                    decimal valor_veiculos;
                    decimal valor_reboques;
                    if (tipo == 0)
                    {                        
                        valor_veiculos = conn.somaValorTotalVeiculoPorIdClienteEInatividade(c.id, inatividadeItens);
                        valor_reboques = conn.somaValorTotalReboquesPorIdClienteEInatividade(c.id, inatividadeItens);
                    }
                    else
                    {
                        valor_veiculos = conn.somaValorTotalVeiculoPorIdClienteEInatividadeEDataAtivacao(c.id, inatividadeItens,
                        tfDataInicial.DateTime.Date, tfDataFinal.DateTime.Date);
                        valor_reboques = conn.somaValorTotalReboquesPorIdClienteEInatividadeEDataAtivacao(c.id, inatividadeItens,
                            tfDataInicial.DateTime.Date, tfDataFinal.DateTime.Date);
                    }
                    decimal valor_total_bens = valor_veiculos + valor_reboques;
                    decimal total_cotas = valor_total_bens / ConfigSistema.valor_por_cota;
                    decimal porcento_cotas = (total_cotas * 100) / total_cotas_grupo;

                    listReport.Add(new RelatorioClientesECotasModel()
                    {
                        nomeCliente = c.nome_completo,
                        dataAtivacao = c.data_ativacao,
                        cotas = total_cotas,
                        valorTotalDeBens = valor_total_bens,
                        percentCotas = porcento_cotas
                    });
                }

                RelatorioClientesECotas report = new RelatorioClientesECotas();
                report.bdgRelatorio.DataSource = listReport;
                report.dataRelatorio.Value = "RELATÓRIO GERADO EM: " + conn.retornaDataHoraLocal();
                report.assinatura.Value = "GERADO POR SYSNORTE TECNOLOGIA";
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }
                ReportPrintTool tool = new ReportPrintTool(report);
                Log.createLog(EventLog.visualized, String.Format("relatorios de clientes e cotas"));
                tool.ShowRibbonPreviewDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }
    }
}