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
using DevExpress.XtraSplashScreen;
using SysNorteGrupo.Reports.Gerencial;
using DevExpress.XtraReports.UI;
using WcfLibGrupo;
using EntitiesGrupo;
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.Reports
{
    public partial class RelatorioGerencialMensalSubForm : DevExpress.XtraEditors.XtraForm
    {
        IServiceGrupo conn;
        public RelatorioGerencialMensalSubForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            tfOrcamentosGrid.DisplayFormat.FormatString = "c3";
            tfOrcamentosGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tfPagamentosGrid.DisplayFormat.FormatString = "c3";
            tfPagamentosGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tfSubTotalGrid.DisplayFormat.FormatString = "c3";
            tfSubTotalGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            carregaSinistrosEmAndamento();
        }

        private void carregaSinistrosEmAndamento()
        {
            bdgSinistrosRelatorioGerencial.DataSource = new List<SinistrosRelatorioGerencial>();
            bdgSinistrosRelatorioGerencial.Clear();
            List<sinistro> listS = conn.listaDeSinistrosPorSituacao(0);
            foreach (sinistro s in listS)
            {
                bdgSinistrosRelatorioGerencial.List.Add(new SinistrosRelatorioGerencial()
                { 
                    clienteEPlacas = conn.retornaClientePorId(s.id_cliente).nome_completo + " / " 
                    + conn.retornaVeiculoPorId(s.id_veiculo).placa, 
                    cotas_na_data = s.cotas_na_data, 
                    valor_por_cota = s.valor_total / s.cotas_na_data
                });
            }

        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Image Files | *.jpg; *.png; *.gif; *.jpeg; *.bmp";
            DialogResult rs = image.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imagemExtrato.Image = Image.FromFile(image.FileName);
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            List<RelatorioGerencial> listaRelatorio = new List<RelatorioGerencial>();
            DateTime now = conn.retornaDataHoraLocal();
            try
            {
                SplashScreenManager.ShowForm(typeof(SysNorteGrupo.UI.Utils.PleaseWaitForm), false, false);
                decimal valor_bens = 0;
                foreach (veiculo v in conn.listaDeVeiculosPorInatividade(false))
                    valor_bens += v.valor;

                foreach (reboque r in conn.listaDeReboquesPorInatividade(false))
                    valor_bens += r.valor;

                foreach (cliente c in conn.listaDeTodosClientes())
                {
                    List<VeiculosEReboquesRelatorioGerencial> veiculosEReboques = new List<VeiculosEReboquesRelatorioGerencial>();
                    foreach (veiculo v in conn.listaDeVeiculosPorIdClienteEInatividade(c.id, false))
                    {
                        string placas = "";
                        decimal cotas_reboques = 0;
                        foreach (reboque r in conn.listaDeReboquesPorIdVeiculo(v.id, false))
                        {
                            placas += r.placa;
                            placas += " ";
                            cotas_reboques += r.valor / ConfigSistema.valor_por_cota;
                        }
                        veiculosEReboques.Add(new VeiculosEReboquesRelatorioGerencial() 
                        {
                            veiculosReboque = v.placa + " " + placas,
                            cotas = (v.valor / ConfigSistema.valor_por_cota) + cotas_reboques
                        });
                    }

                    listaRelatorio.Add(new RelatorioGerencial()
                    {
                        cliente = c.nome_completo,
                        datetimenow = now,
                        imagemExtratoBancario = imagemExtrato.Image,
                        valoresAintegralizar = Convert.ToDecimal(tfValoresAIntegralizar.EditValue),
                        valoresCapitalizadosNoGrupo = Convert.ToDecimal(tfValoresCapitalizados.EditValue),
                        valoresDepositadosBancos = Convert.ToDecimal(tfValoresDepositadosBanco.EditValue),
                        valoresPagosDeSinistrosAReintegralizar = Convert.ToDecimal(tfValoresPagosDeSinistrosAIntegralizar.EditValue),
                        valoresEmCaixa = Convert.ToDecimal(tfValoresEmCaixa.EditValue),
                        totalBensGrupo = valor_bens, 
                        totalCotasGrupo = valor_bens / ConfigSistema.valor_por_cota,
                        listVeiculosEReboques = veiculosEReboques,
                        listSinistros = (List<SinistrosRelatorioGerencial>)bdgSinistrosRelatorioGerencial.List
                    });
                }

                RelatorioGerencialMensal report = new RelatorioGerencialMensal();

                report.bdgRelatorio.DataSource = listaRelatorio;
                report.rodape.Value = "GERADO POR SYSNORTE TECNOLOGIA EM: " + now;
                foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                {
                    p.Visible = false;
                }
                ReportPrintTool tool = new ReportPrintTool(report);
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