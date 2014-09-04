using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using EntitiesGrupo;
using SysNorteGrupo.Reports;
using SysNorteGrupo.Reports.Clientes;
using SysNorteGrupo.UI.Utils.Enderecos;
using SysNorteGrupo.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WcfLibGrupo;

namespace SysNorteGrupo.UI.Clientes
{
    public partial class ClienteForm : XtraUserControl
    {
        public FormPrincipal formPrincipal = null;

        //public cliente cliente_instc { get; set; }

        IServiceGrupo conn = null;

        private System.Drawing.Color backColor = ConfigSistema.backColorFoco;

        public ClienteForm(cliente cliente_instc)
        {
            InitializeComponent();
            button1.Visible = false;
            conn = GerenteDeConexoes.conexaoServico();

            arquivosFormCli.conn = conn;

            //recuperar estados
            bdgEstados.DataSource = conn.listaDeEstados();

            //acrescentar id_estados
            //cbEstados.EditValue = cliente_instc.
            //cbEstados_EditValueChanged(null, null);
            //cbCidade_EditValueChanged(null, null);

            //XtraMessageBox.Show(cliente_instc.id.ToString());

            if(cliente_instc == null){
                cliente_instc = new cliente() { isento_ICMS = false, cotas = 0, valor_total = 0 };
                panelArquivos.Enabled = false;
            }

            bdgCliente.DataSource = cliente_instc;
            //bdgCliente.Clear();
            //bdgCliente.Add(cliente_instc);

            foreach (PanelControl c in panelCadastro.Controls)
            {
                foreach (Control item in c.Controls)
                {
                    preencheFundoControls(item);
                }
            }

            foreach (Control item in panelComponentes.Controls)
            {
                preencheFundoControls(item);
            }

            foreach (XtraTabControl tab in panelReferencias.Controls)
            {
                foreach (XtraTabPage page in tab.Controls)
                {
                    foreach (Control item in page.Controls)
                    {
                        preencheFundoControls(item);
                    }
                }
            }

            //Console.WriteLine(cliente_instc.id);
            
            ValidadorCPFCNPJ vldDocumento = new ValidadorCPFCNPJ() { ErrorText = "O CPF/CNPJ informado é inválido.", ErrorType = ErrorType.Warning };
            validador.SetValidationRule(tfDocumento, vldDocumento);

            if (cliente_instc.id == 0)
            {
                reabilitarPaineis(false);
                arquivosFormCli.Enabled = false;
            }
            else
            {
                panelArquivos.Enabled = true;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
                panelComponentes.Enabled = false;

                arquivosFormCli.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_CLIENTES(), cliente_instc.id);
                arquivosFormCli.executaBusca();
                arquivosFormCli.Enabled = true;

                //carregar cidades pelo estado, bairros endereços
                try
                {
                    bdgCidades.Clear();
                    bdgCidades.DataSource = conn.listaDeCidadesPorEstado(cliente_instc.uf_estado);
                    cbCidade.Enabled = true;
                    cbCidade.EditValue = cliente_instc.id_cidades;
                    grpTipo.EditValue = Convert.ToChar(cliente_instc.tipo_cliente); 
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao recuperar lista de cidades: " + ex.Message, "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bdgCidades.DataSource = null;
                    bdgBairros.DataSource = null;
                    bdgEnderecos.DataSource = null;
                    cbCidade.Enabled = false;
                }

                try
                {
                    bdgBairros.DataSource = conn.listaDeBairrosPorCidade(Convert.ToInt64(cbCidade.EditValue));
                    bdgEnderecos.DataSource = conn.listaDeEnderecosPorCidade(Convert.ToInt64(cbCidade.EditValue));

                    cbBairro.Enabled = true;
                    cbEndereco.Enabled = true;

                    cbBairro.EditValue = cliente_instc.id_bairros;
                    cbEndereco.EditValue = cliente_instc.id_enderecos;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao recuperar lista de bairros e endereços: " + ex.Message, "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bdgBairros.DataSource = null;
                    bdgEnderecos.DataSource = null;
                    cbBairro.Enabled = false;
                    cbEndereco.Enabled = false;
                }
                btnImprimirContrato.Visible = true;
            }
        }

        private void reabilitarPaineis(bool flag)
        {
            panelCadastro.Enabled = flag;
            panelReferencias.Enabled = flag;
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

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            reabilitarPaineis(true);
            panelArquivos.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            panelComponentes.Enabled = true;
            arquivosFormCli.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_CLIENTES(), ((cliente)bdgCliente.Current).id);
            arquivosFormCli.executaBusca();
            arquivosFormCli.Enabled = true;
            Log.createLog(EventLog.edited, String.Format("cliente ID: {0}", tfId.Text));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool vazio = Util.textFieldIsEmpty(tfId);
            if (!ckIsento.Checked && tfInscricao.Text == String.Empty)
            {
                XtraMessageBox.Show("Informe o RG / INSCRIÇÃO caso o cliente não seja isento ou caso seja pessoa física.", "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tfInscricao.Focus();
                return;
            }

            if (validador.Validate())
            {

                if (Convert.ToChar(grpTipo.EditValue) == 'j' && !ckIsento.Checked && !Validations.validIE(tfInscricao.EditValue.ToString()
                    .Replace('.', ' ').Replace('-', ' ').Trim(), cbEstados.Text))
                {
                    XtraMessageBox.Show("O INSCRIÇÃO ESTADUAL informada é inválida ou não foi selecionado um ESTADO para o endereço. Verifique!", "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tfInscricao.Focus();
                    return;
                }

                if (!conn.verificaSeCpfCnpjEhUnico(tfDocumento.EditValue.ToString(), !vazio))
                {
                    XtraMessageBox.Show("O CPF/CNPJ informado já encontra-se cadastrado. Verifique!", "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tfDocumento.Focus();
                    return;
                }

                if (!conn.verificaSeInscricaoRgEhUnico(tfInscricao.EditValue.ToString(), !vazio))
                {
                    XtraMessageBox.Show("A INSCRIÇÃO/RG informado(a) já encontra-se cadastrado(a). Verifique!", "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tfInscricao.Focus();
                    return;
                }

                int index_princ = tfEmailPrincipal.Text.IndexOf("@");
                string _email_principal = tfEmailPrincipal.Text.Insert(index_princ, "@");

                if (!conn.verificaSeEmailPrincipalEhUnico(_email_principal, !vazio))
                {
                    XtraMessageBox.Show("O Email principal informado já encontra-se cadastrado. Verifique!", "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tfEmailPrincipal.Focus();
                    return;
                }

                try
                {
                    cliente cli = (cliente)bdgCliente.Current;

                    cli.tipo_cliente = Convert.ToString(grpTipo.EditValue);

                    if (cli.id == 0)
                    {
                        cli.data_cadastro = DateTime.Now;
                        cli.data_ativacao = DateTime.Now.Date.AddDays(1);
                    }

                    cli.inativo = false;
                    long id = conn.salvarCliente(cli);
                    ((cliente)bdgCliente.Current).id = id;
                    tfId.Text = id.ToString();
                    btnImprimirContrato.Visible = true;
                    Log.createLog(EventLog.saveEdited, String.Format("cliente ID: {0}", id));

                    reabilitarPaineis(false);
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    panelArquivos.Enabled = false;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao salvar novo cliente: " + ex.Message, "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grpTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tfDocumento.EditValue = string.Empty;
            tfInscricao.EditValue = string.Empty;

            if (Convert.ToChar(grpTipo.EditValue) == 'f')
            {
                this.tfDocumento.Properties.Mask.EditMask = "000.000.000-00";

                ckIsento.Checked = false;
                ckIsento.Enabled = false;
            }
            else
            {
                this.tfDocumento.Properties.Mask.EditMask = "00.000.000/0000-00";

                ckIsento.Checked = false;
                ckIsento.Enabled = true;
            }

            this.tfDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;

            reabilitarPaineis(true);

            /*bdgCidades.Clear();
            bdgBairros.Clear();
            bdgEnderecos.Clear();
            cbCidade.Enabled = false;
            cbBairro.Enabled = false;
            cbEndereco.Enabled = false;*/

            tfNome.Focus();
        }

        private void ckIsento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckIsento.Checked)
            {
                tfInscricao.Enabled = false;
            }
            else
            {
                tfInscricao.Enabled = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
            Log.createLog(EventLog.executedSearch, "formulario de clientes");
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            //recuperar estados
            //bdgEstados.DataSource = conn.listaDeEstados();
        }

        private void cbEstados_EditValueChanged(object sender, EventArgs e)
        {
            if (cbEstados.EditValue != null)
            {
                try
                {
                    bdgCidades.Clear();
                    bdgCidades.DataSource = conn.listaDeCidadesPorEstado(cbEstados.Text);

                    cbCidade.Enabled = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao recuperar lista de cidades: " + ex.Message, "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    bdgCidades.DataSource = null;
                    bdgBairros.DataSource = null;
                    bdgEnderecos.DataSource = null;

                    cbCidade.Enabled = false;
                }
            }
            else
            {
                bdgCidades.DataSource = null;
                bdgBairros.DataSource = null;
                bdgEnderecos.DataSource = null;

                cbCidade.Enabled = false;
            }
        }

        private void cbCidade_EditValueChanged(object sender, EventArgs e)
        {
            //if (cbCidade.EditValue != null || cbCidade.EditValue != DBNull.Value || Convert.ToInt32(cbCidade.EditValue) > 0)
            if (cbCidade.EditValue != null || Convert.ToInt64(cbCidade.EditValue) > 0)
            {
                //XtraMessageBox.Show(cbCidade.EditValue.ToString());
                try
                {
                    bdgBairros.DataSource = conn.listaDeBairrosPorCidade(Convert.ToInt64(cbCidade.EditValue));
                    bdgEnderecos.DataSource = conn.listaDeEnderecosPorCidade(Convert.ToInt64(cbCidade.EditValue));

                    cbBairro.Enabled = true;
                    cbEndereco.Enabled = true;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Erro ao recuperar lista de bairros e endereços: " + ex.Message, "SYSNORTE GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    cbBairro.Enabled = false;
                    cbEndereco.Enabled = false;
                }
            }
            else
            {
                cbBairro.Enabled = false;
                cbEndereco.Enabled = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(new ClienteForm(null) { formPrincipal = formPrincipal });
            Log.createLog(EventLog.opened, String.Format("novo formulario de clientes"));
           /* //remover eventos combobox
            this.cbEstados.EditValueChanged -= new EventHandler(this.cbEstados_EditValueChanged);
            this.cbCidade.EditValueChanged -= new EventHandler(this.cbCidade_EditValueChanged);
            
            bdgCliente.Clear();

            grpTipo.SelectedIndex = -1;

            //cliente_instc = new cliente() { isento_ICMS = false };
            bdgCliente.DataSource = new cliente() { isento_ICMS = false };

            //reabilitar eventos combobox
            this.cbEstados.EditValueChanged += new EventHandler(this.cbEstados_EditValueChanged);
            this.cbCidade.EditValueChanged += new EventHandler(this.cbCidade_EditValueChanged);

            //recuperar estados
            bdgEstados.DataSource = conn.listaDeEstados();

            reabilitarPaineis(false);

            panelArquivos.Enabled = false;

            //limpar validações
            FieldInfo fi = typeof(DXValidationProvider).GetField("errorProvider", BindingFlags.NonPublic | BindingFlags.Instance);
            DXErrorProvider errorProvier = fi.GetValue(validador) as DXErrorProvider;

            foreach (Control c in validador.GetInvalidControls())
            {
                errorProvier.SetError(c, null);
            }
            //fim*/
        }

        public class ValidadorCPFCNPJ : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                string str = value == DBNull.Value ? string.Empty : (string)value;

                bool res = false;

                if (Validations.isCPFCNPJ(str, false))
                    res = true;
                else
                    res = false;

                return res;
            }
        }

        private void cbEndereco_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbEndereco.EditValue) > 0)
            {
                endereco end = (endereco)bdgEnderecos.Current;
                ((cliente)bdgCliente.Current).cep = end.cep;
                tfCep.Text = end.cep;
            }
            //formPrincipal.adicionarControleNavegacao(new ClienteForm(null) { formPrincipal = formPrincipal });
        }

        private void btnImprimirContrato_Click(object sender, EventArgs e)
        {
            RelatorioInclusãoCliente report = new RelatorioInclusãoCliente();
            report.bdgClientesLista.DataSource = listaFinal();
            report.dataRelatorio.Value = "RELATÓRIO GERADO EM: " + conn.retornaDataHoraLocal();
            report.assinatura.Value = "GERADO POR SYSNORTE TECNOLOGIA";
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            ReportPrintTool tool = new ReportPrintTool(report);
            Log.createLog(EventLog.visualized, String.Format("relatorios de bens, cliente ID: {0}", tfId.Text));
            tool.ShowRibbonPreviewDialog();
        }
        List<ListaClientesInclusao> listaFinal()
        {
            List<ListaClientesInclusao> principal = new List<ListaClientesInclusao>();

            cliente c = (cliente)bdgCliente.Current;

            principal.Add(new ListaClientesInclusao() { 
                cliente = c.nome_completo,
                listaVeiculo = listaVeiculos(c.id),
                totalDeBens = Convert.ToDecimal(tfTotalBens.Text),
                totalDeCotas = Convert.ToDecimal(tfTotalCotas.Text),
                dataInclusao = c.data_ativacao
            });

            return principal;
        }
        List<VeiculosRelatorio> listaVeiculos(long id_cliente)
        {
            List<VeiculosRelatorio> veiculos = new List<VeiculosRelatorio>();
            foreach (veiculo v in conn.listaDeVeiculosPorIdCliente(id_cliente, false))
            {
                decimal cotas = v.valor / ConfigSistema.valor_por_cota;
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

        decimal valor_por_cota = 0;
        List<ReboquesRelatorio> listaReboques(long id_veiculo)
        {
            List<ReboquesRelatorio> reboques = new List<ReboquesRelatorio>();
            foreach (reboque r in conn.listaDeReboquesPorIdVeiculoEInatividade(id_veiculo, false))
            {
                decimal cotas = r.valor / ConfigSistema.valor_por_cota;
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

        private void btnCadBairro_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbCidade.EditValue) > 0)
            {
                CadastraBairroForm cbf = new CadastraBairroForm(this, cbCidade.Text, Convert.ToInt64(cbCidade.EditValue));
                DialogResult rs = cbf.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show(String.Format("SELECIONE A CIDADE CORRENSPONDENTE AO BAIRRO PARA PODER CADASTRAR NOVO."));
            }
        }

        private void btnCadEndereco_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(cbBairro.EditValue) > 0)
            {
                CadastraEnderecoForm cef = new CadastraEnderecoForm(this, cbBairro.Text, Convert.ToInt64(cbBairro.EditValue), Convert.ToInt64(cbCidade.EditValue));
                DialogResult rs = cef.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show(String.Format("SELECIONE O BAIRRO CORRENSPONDENTE AO ENDEREÇO PARA PODER CADASTRAR NOVO."));
            }
        }

        public void carregaBairrosPorIdCidade()
        {
            bdgBairros.DataSource = conn.listaDeBairrosPorCidade(Convert.ToInt64(cbCidade.EditValue));
        }

        public void carregaEnderecosPorIdCidade()
        {        
            bdgEnderecos.DataSource = conn.listaDeEnderecosPorCidade(Convert.ToInt64(cbCidade.EditValue));
        }


        /*partial class clienteteste
        {
            public decimal valor { get; set; }
            public string cliente { get; set; }
        }

        partial class geradorpdf
        {
            public string diretorio { get; set; }
            public string cliente { get; set; }
        }*/


        /*List<geradorpdf> pdfs = new List<geradorpdf>();
        private void button1_Click(object sender, EventArgs e)
        {
            var currentDirectory = Directory.GetCurrentDirectory() + @"\pdf\wkhtmltopdf.exe";

            List<clienteteste> cls = new List<clienteteste>();
            cls.Add(new clienteteste() { cliente = "CLIENTE1", valor = Convert.ToDecimal(1225) });
            cls.Add(new clienteteste() { cliente = "CLIENTE2", valor = Convert.ToDecimal(1500) });
            cls.Add(new clienteteste() { cliente = "CLIENTE3", valor = Convert.ToDecimal(1800) });
            cls.Add(new clienteteste() { cliente = "CLIENTE4", valor = Convert.ToDecimal(1900) });
            cls.Add(new clienteteste() { cliente = "CLIENTE5", valor = Convert.ToDecimal(900) });
            cls.Add(new clienteteste() { cliente = "CLIENTE6", valor = Convert.ToDecimal(1100) });
            cls.Add(new clienteteste() { cliente = "CLIENTE7", valor = Convert.ToDecimal(825) });
            cls.Add(new clienteteste() { cliente = "CLIENTE8", valor = Convert.ToDecimal(740) });

            List<BoletoBancario> boletos = new List<BoletoBancario>();
            

            foreach (clienteteste c in cls)
            {

                Instrucao_Itau instrucao = new Instrucao_Itau() { Descricao = "Não receber após o vencimento." };

                BoletoUtil bu = new BoletoUtil()
                {
                    aceite = "N",
                    carteiraBoleto = "109",
                    codigoBancoBoleto = 341,
                    dataProcessamento = conn.retornaDataHoraLocal(),
                    dataVencimento = conn.retornaDataHoraLocal().Date.AddDays(15),
                    nossoNumeroBoleto = "22222222",
                    percMulta = 5,
                    especieDocumento = new EspecieDocumento_Itau("99"),
                    instrucaoBoleto = instrucao,
                    jurosMora = 28,
                    mostrarCodigoCarteira = true,
                    mostrarComprovanteEntrega = true,
                    numeroDocumento = "00018438463",
                    numeroParcela = 1,
                    percJurosMora = Convert.ToDecimal(0.02),
                    valorBoleto = c.valor,
                    diretorioNome = String.Format(@"C:\Users\Ganzer\Documents\boletos\Boleto{0}.html", c.cliente)

                };

                SacadoUtil su = new SacadoUtil()
                {
                    enderecoSacado = "Av Mato Grosso SN",
                    bairroSacado = "Centro",
                    cepSacado = "78.455-000",
                    cidadeSacado = "Lucas Do Rio Verde",
                    cpfCnpjSacado = "125.652.598-65",
                    nomeSacado = c.cliente,
                    ufSacado = "MT"
                };

                CedenteUtil ceu = new CedenteUtil()
                {
                    nomeCedente = "SYS NORTE TECNOLOGIA",
                    cpfCnpjCedente = "00.021.001/0001-06",
                    codigoCedente = "001",
                    agenciaCedente = "0810",
                    contaCedente = "4022800",
                    digitoContaCedente = "9"
                };

                pdfs.Add(new geradorpdf() { cliente = c.cliente, diretorio = bu.diretorioNome });
                BoletoBancario bl = new GerenteDeBoletos().geraBoleto(bu, ceu, su);

                bl.MontaHtmlNoArquivoLocal(bu.diretorioNome);
                boletos.Add(bl);
            }

            foreach (geradorpdf bb in pdfs)
            {
                //Console.WriteLine(currentDirectory);
                try
                {
                    Process p = new Process();
                    //string str = System.Web.HttpContext.Current.Server.MapPath("wkhtmltopdf.exe");

                    p.StartInfo.FileName = currentDirectory;
                    p.StartInfo.Arguments = String.Format(" \"{0}\" {1}", bb.diretorio, String.Format(@"C:\Users\Ganzer\Documents\boletos\Boleto{0}.pdf", bb.cliente));
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();

                    p.WaitForExit();
                    //System.Threading.Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                finally
                {
                    if(File.Exists(bb.diretorio))
                    {
                        File.Delete(bb.diretorio);
                    }
                }
            }

            print();
        }
        
        public void print()
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Ganzer\Documents\boletos\");
            foreach (FileInfo f in dir.GetFiles())
            {

                PdfFilePrinter.AdobeReaderPath = @"C:\Program Files (x86)\Adobe\Reader 11.0\Reader\AcroRd32.exe";

                PdfFilePrinter printer = new PdfFilePrinter(f.FullName, "Microsoft XPS Document Writer");

                try
                {
                    printer.Print();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
            
        }*/ 
    }
}
