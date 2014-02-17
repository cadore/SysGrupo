using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfLibGrupo;
using EntitiesGrupo;
using SysNorteGrupo.UI.Veiculos;
using SysNorteGrupo.Utils;
using SysNorteGrupo.Reports.Clientes;
using DevExpress.XtraReports.UI;
using SysNorteGrupo.Reports;

namespace SysNorteGrupo.UI.Clientes
{
    public partial class BuscaClienteForm : XtraUserControl
    {

        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private int tipoPesquisa = -1;
        private bool _inativo = false;

        private Color backColor = UtilsSistema.backColorFoco;

        public BuscaClienteForm()
        {
            InitializeComponent();

            foreach (Control c in pbBotoes.Controls)
            {
                //foreach (Control item in c.Controls)
                //{
                preencheFundoControls(c);
                //}
            }

            conn = GerenteDeConexoes.iniciaConexao();
        }

        void preencheFundoControls(Control item)
        {
            switch (item.GetType().ToString())
            {
                case "DevExpress.XtraEditors.TextEdit": ((TextEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.SearchLookUpEdit": ((SearchLookUpEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.RadioGroup": ((RadioGroup)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.CheckEdit": ((CheckEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
            }
        }

        private void verificaTipoPesquisa(TextEdit t, int _tipoPesquisa)
        {
            string valor = t.Text;
            if (!valor.Equals(String.Empty))
            {
                tipoPesquisa = _tipoPesquisa;
            }
            else
            {
                tipoPesquisa = -1;
            }
        }

        private void executaBusca()
        {
            List<cliente> listCli = new List<cliente>();
            List<cliente> listRetorno = new List<cliente>();
            if (tipoPesquisa == 0)
            {
                listCli = conn.listaDeClientesPorId(Convert.ToInt64(tfId.Text));
            }
            else if (tipoPesquisa == 1)
            {
                listCli = conn.listaDeClientesPorNomeOuDocumento(tfNomeDocumento.Text, _inativo);
            }
            else
            {
                listCli = conn.listaDeClientesPorInatividade(_inativo);
            }
            foreach (cliente v in listCli)
            {
                decimal valor_veiculos = conn.somaValorTotalVeiculoPorIdClienteEInatividade(v.id, false);
                decimal valor_reboques = conn.somaValorTotalReboquesPorIdClienteEInatividade(v.id, false);
                decimal total_cotas = (valor_veiculos + valor_reboques) / UtilsSistema.valor_por_cota;
                v.cotas = total_cotas;
                v.valor_total = (valor_veiculos + valor_reboques);
                listRetorno.Add(v);
            }
            bdgCliente.DataSource = listRetorno;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            executaBusca();
        }

        private void tfId_KeyUp(object sender, KeyEventArgs e)
        {
            tfNomeDocumento.Text = "";
            verificaTipoPesquisa(tfId, 0);
        }

        private void tfNomeDocumento_KeyUp(object sender, KeyEventArgs e)
        {
            tfId.Text = "";
            verificaTipoPesquisa(tfNomeDocumento, 1);
        }

        private void ckAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckAtivo.CheckState == CheckState.Checked){
                ckInativo.CheckState = CheckState.Unchecked;
                _inativo = false;
                executaBusca();
            }            
        }

        private void ckInativo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckInativo.CheckState == CheckState.Checked){
                ckAtivo.CheckState = CheckState.Unchecked;
                _inativo = true;
                executaBusca();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cliente cli = (cliente) bdgCliente.Current;

            //MessageBox.Show(cli.id.ToString());

            ClienteForm cf = new ClienteForm(cli) { formPrincipal = formPrincipal };
            formPrincipal.adicionarControleNavegacao(cf);
        }

        private void btnImprimirContrato_Click(object sender, EventArgs e)
        {
            RelatorioRelacaoCliente report = new RelatorioRelacaoCliente();
            report.bdgVeiculosReboques.DataSource = listaFinal();
            report.dataRelatorio.Value = "RELATÓRIO GERADO EM: " + conn.retornaDataHoraLocal();
            //report.assinatura.Value = "GERADO POR SYSNORTE TECNOLOGIA";
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }

            /*PdfExportOptions po = new PdfExportOptions() {ImageQuality = PdfJpegImageQuality.Highest, Compressed = true };
            report.ExportToPdf("C:\\Users\\William\\Desktop\\testePDF.pdf", po);*/

            /*HtmlExportOptions htmlOptions = report.ExportOptions.Html;
            htmlOptions.CharacterSet = "UTF-8";
            htmlOptions.TableLayout = false;
            htmlOptions.RemoveSecondarySymbols = false;
            htmlOptions.Title = "Teste relatório HTML";
            htmlOptions.ExportMode = HtmlExportMode.SingleFilePageByPage;
            htmlOptions.PageBorderColor = Color.Blue;
            htmlOptions.PageBorderWidth = 3;            
            report.ExportToHtml("C:\\Users\\William\\Desktop\\testeHTML.html");*/
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowRibbonPreviewDialog();
        }

        decimal valor_por_cota = 0;

        List<ReboquesRelatorio> listaReboques(long id_veiculo)
        {
            List<ReboquesRelatorio> reboques = new List<ReboquesRelatorio>();
            foreach (reboque r in conn.listaDeReboquesPorIdVeiculo(id_veiculo, false))
            {
                decimal cotas = r.valor / UtilsSistema.valor_por_cota;
                reboques.Add(new ReboquesRelatorio()
                {
                    placa = r.placa,
                    modelo = r.modelo,
                    valor = r.valor,
                    cotas = (cotas).ToString(),
                    participacao = valor_por_cota * cotas
                });
            }
            return reboques;
        }

        List<VeiculosRelatorio> listaVeiculos(long id_cliente)
        {
            List<VeiculosRelatorio> veiculos = new List<VeiculosRelatorio>();
            foreach (veiculo v in conn.listaDeVeiculosPorIdCliente(id_cliente))
            {
                decimal cotas = v.valor / UtilsSistema.valor_por_cota;
                veiculos.Add(new VeiculosRelatorio()
                {
                    placa = v.placa,
                    modelo = conn.retornaModeloPorId(v.id_modelo_veiculos).nome,
                    valor = v.valor,
                    cotas = (cotas).ToString(),
                    //participacao = valor_por_cota * cotas,
                    listaReboques = listaReboques(v.id)
                });
            }

            return veiculos;
        }

        List<ListaClientesRateio> listaFinal()
        {
            List<ListaClientesRateio> principal = new List<ListaClientesRateio>();

            cliente c = (cliente)bdgCliente.Current;

            principal.Add(new ListaClientesRateio() { cliente = c.nome_completo, listaVeiculo = listaVeiculos(c.id), totalParticipacao = 0 });

            return principal;
        }
    }
}
