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
using SysNorteGrupo.UI.Utils;

namespace SysNorteGrupo.Reports
{
    public partial class RelatorioGerencialMensalSubForm : DevExpress.XtraEditors.XtraForm
    {
        IServiceGrupo conn;
        DateTime now;
        public RelatorioGerencialMensalSubForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            now = conn.retornaDataHoraLocal();
            tfOrcamentosGrid.DisplayFormat.FormatString = "c2";
            tfOrcamentosGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tfPagamentosGrid.DisplayFormat.FormatString = "c2";
            tfPagamentosGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            tfSubTotalGrid.DisplayFormat.FormatString = "c2";
            tfSubTotalGrid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            carregaSinistrosEmAndamento();
        }

        private void carregaSinistrosEmAndamento()
        {
            bdgSinistrosRelatorioGerencial.DataSource = new List<SinistrosRelatorioGerencial>();
            bdgSinistrosRelatorioGerencial.Clear();
            List<sinistro> listS = conn.listaDeSinistrosPorSituacao(1);
            foreach (sinistro s in listS)
            {
                decimal parcela = 0;
                List<parcelas_sinistros> listParc = conn.listaDeParcelasSinistrosPorIdSinistro(s.id);
                foreach (parcelas_sinistros ps in listParc)
                {
                    if (ps.mes_parcela == now.Month && ps.ano_parcela == now.Year)
                    {
                        parcela = ps.valor;
                    }
                }

                if (listParc.Count > 0)
                {
                    bdgSinistrosRelatorioGerencial.List.Add(new SinistrosRelatorioGerencial()
                    {
                        id_sinistro = s.id,
                        clienteEPlacas = conn.retornaClientePorId(s.id_cliente).nome_completo + " / "
                        + conn.retornaVeiculoPorId(s.id_veiculo).placa,
                        cotas_na_data = s.cotas_na_data,
                        valor_por_cota = parcela / s.cotas_na_data,
                        orcamentos = s.valor_total,
                        pagamentoMes = parcela
                    });
                }
            }

        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Image Files | *.jpg; *.png; *.gif; *.jpeg; *.bmp";
            DialogResult rs = image.ShowDialog();
            if (rs == DialogResult.OK)
            {
                SplashScreenManager.ShowForm(typeof(PleaseWaitForm), false, false);
                imagemExtrato.Image = Image.FromFile(image.FileName);
                SplashScreenManager.CloseForm(false);
            }
            else
            {
                imagemExtrato.Image = null;
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            List<RelatorioGerencial> listaRelatorio = new List<RelatorioGerencial>();
            DateTime now = conn.retornaDataHoraLocal();
            try
            {
                SplashScreenManager.ShowForm(typeof(PleaseWaitForm), false, false);
                decimal valor_bens = 0;
                foreach (veiculo v in conn.listaDeVeiculosPorInatividade(false))
                    valor_bens += v.valor;

                foreach (reboque r in conn.listaDeReboquesPorInatividade(false))
                    valor_bens += r.valor;

                foreach (cliente c in conn.listaDeTodosClientes())
                {
                    List<SinistrosRelatorioGerencial> listSin = new List<SinistrosRelatorioGerencial>();
                    foreach (SinistrosRelatorioGerencial s in bdgSinistrosRelatorioGerencial.List)
                    {
                        s.clienteEPlacas = c.nome_completo;
                        s.subTotal = s.valor_por_cota * (conn.somaDeBensClientePorIdSinistroEIdCliente(s.id_sinistro, c.id)
                            / ConfigSistema.valor_por_cota);
                        listSin.Add(s);
                    }
                    int vr = 1;
                    List<VeiculosEReboquesRelatorioGerencial> veiculosEReboques = new List<VeiculosEReboquesRelatorioGerencial>();
                    
                    foreach (veiculo v in conn.listaDeVeiculosPorIdClienteEInatividade(c.id, false))
                    {
                        string placas = "";
                        decimal cotas_reboques = 0;
                        foreach (reboque r in conn.listaDeReboquesPorIdVeiculoEInatividade(v.id, false))
                        {
                            placas += " / " + r.placa;
                            cotas_reboques += r.valor / ConfigSistema.valor_por_cota;
                        }
                        veiculosEReboques.Add(new VeiculosEReboquesRelatorioGerencial() 
                        {
                            numero = vr++,
                            veiculosReboque = v.placa + placas,
                            cotas = (v.valor / ConfigSistema.valor_por_cota) + cotas_reboques,
                        });
                    }

                    ClienteRelatorio client = new ClienteRelatorio()
                    {
                        listSin = listSin, 
                        listVeiculosEReboques = veiculosEReboques,
                        nome_cliente = c.nome_completo
                    };
                    
                    listaRelatorio.Add(new RelatorioGerencial()
                    {
                        datetimenow = now,
                        imagemExtratoBancario = imagemExtrato.Image,
                        valoresAintegralizar = Convert.ToDecimal(tfValoresAIntegralizar.EditValue),
                        valoresCapitalizadosNoGrupo = Convert.ToDecimal(tfValoresCapitalizados.EditValue),
                        valoresDepositadosBancos = Convert.ToDecimal(tfValoresDepositadosBanco.EditValue),
                        valoresPagosDeSinistrosAReintegralizar = Convert.ToDecimal(tfValoresPagosDeSinistrosAIntegralizar.EditValue),
                        valoresEmCaixa = Convert.ToDecimal(tfValoresEmCaixa.EditValue),
                        totalBensGrupo = valor_bens,
                        totalCotasGrupo = valor_bens / ConfigSistema.valor_por_cota,
                        cliente = client
                    });
                }
                RelatorioGerencialMensal report = new RelatorioGerencialMensal();

                report.bdgRelatorio.DataSource = listaRelatorio;
                report.rodape.Value = "GERADO POR SYSNORTE TECNOLOGIA EM: " + now;
                string mes = String.Format("{0:MMMM}", now);
                report.cabecalho.Value = String.Format("RELATÓRIO GERENCIAL {0} {1:yyyy}", mes.ToUpper(), now);
                report.list();
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