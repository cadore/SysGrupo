using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SysNorteGrupo.Utils;
using System.IO;
using SysNorteGrupo.UI.Usuarios;
using SysNorteGrupo.UI.Clientes;
using SysNorteGrupo.UI.Veiculos;
using EntitiesGrupo;
using WcfLibGrupo;
using SysFileManager;
using SysNorteGrupo.UI.Sinistros;
using SysNorteGrupo.UI.Veiculos.Reboques;
using SysNorteGrupo.UI.Logs;
using UserIdle;
using System.Collections.Generic;
using SysNorteGrupo.Reports.Clientes;
using SysNorteGrupo.Reports;
using DevExpress.XtraReports.UI;

namespace SysNorteGrupo
{
    public partial class FormPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IServiceGrupo conn;
        private UtilForm utilForm;
        private string tituloJanela;
        public UserControl controleAtual = null;
        public bool thisIDLE = false;        
        
        public FormPrincipal(usuario usuario_instc, permicoes_usuario permicao_instc)
        {
            var userIdleDetect = UserIdleDetect.StartDetection(UserIdleDetect.minutes(3));            
            userIdleDetect.UserIdleDetected += userIdleDetect_UserIdleDetected;
            if (usuario_instc == null)
            {
                Program.startApplication();
                this.Close();                
            }
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            //carregaPermissoes(permicao_instc);
            this.Text = tituloJanela = "SysNorteGrupo - SysNorte Tecnologia Copyright ©  2013 Versão: 1.0.0.0";            
        }


        void userIdleDetect_UserIdleDetected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                IDLE(true);
            });
        }       

        void IDLE(bool idle)
        {
            //MessageBox.Show(idle.ToString() + " \n" + thisIDLE.ToString());
            if(idle && !thisIDLE)
            {
                Log.createLog(EventLog.empty, String.Format("bloqueou aplicação por estar mais que 3 minutos inativo"));
                thisIDLE = true;
                this.pnControl.Controls.Clear();
                LoginForm loginFormIDLE = new LoginForm();
                loginFormIDLE.formPrincipal = this;
                loginFormIDLE.lbAviso.Visible = true;
                loginFormIDLE.ShowDialog();
            }            
        }
        
        private void loadImageBackground()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\images\\backgroundSystem.png";
                pnControl.ContentImage = Image.FromFile(path);

            }catch(Exception ex){
                MessageBox.Show(String.Format("{0}\n{1}", ex.Message, ex.InnerException));
            }
            
        }

        void carregaPermissoes(permicoes_usuario p)
        {            
            btnNovoCliente.Enabled = p.cadastrar_cliente;
            btnNovoVeiculo.Enabled = p.cadastrar_veiculo;
            ribUsuarios.Enabled = p.usuarios;
        }

        public void adicionarControleNavegacao(UserControl controle)
        {
            this.pnControl.Controls.Clear();
            if(controle != null){
                this.pnControl.Controls.Add(controle);
                this.MinimumSize = controle.Size + new Size(0, ribbon.Height) + new Size(20, 35);
            }
            controleAtual = controle;
        }

        private void btnBuscarUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaUsuariosForm frm = new BuscaUsuariosForm() { formPrincipal = this };
            adicionarControleNavegacao(frm);
            Log.createLog(EventLog.opened, "formulario de busca de usuario");
        }

        private void btnNovoUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm(null) { formPrincipal = this };
            adicionarControleNavegacao(usuarioForm);
            Log.createLog(EventLog.opened, "formulario de usuarios");
        } 

        private void pnControl_ControlAdded(object sender, ControlEventArgs e)
        {
            Centraliza.centralizaControlsPainel(pnControl);            
        }

        private void FormPricipal_SizeChanged(object sender, EventArgs e)
        {
            Centraliza.centralizaControlsPainel(pnControl);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pnControl.Controls.Clear();
        }

        private void btnBuscarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaClienteForm buscaClienteForm = new BuscaClienteForm() { formPrincipal = this };
            adicionarControleNavegacao(buscaClienteForm);
            Log.createLog(EventLog.opened, "formulario de busca de clientes");
        }

        private void btnClienteForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(null) { formPrincipal = this };
            adicionarControleNavegacao(clienteForm);
            Log.createLog(EventLog.opened, "formulario de clientes");
        }

        private void btnBuscarVeiculo_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaVeiculoForm buscaVeiculoForm = new BuscaVeiculoForm() { formPrincipal = this };
            adicionarControleNavegacao(buscaVeiculoForm);
            Log.createLog(EventLog.opened, "formulario de busca de veiculos");
        }

        private void btnNovoVeiculo_ItemClick(object sender, ItemClickEventArgs e)
        {
            VeiculosForm vf = new VeiculosForm(null) { formPrincipal = this };
            adicionarControleNavegacao(vf);
            Log.createLog(EventLog.opened, "formulario de veiculos");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArquivosForm af = new ArquivosForm();
            af.conn = conn;
            af.DIRETORIO = conn.SUBDIR_EMPRESA();
            adicionarControleNavegacao(af);
            Log.createLog(EventLog.opened, "formulario de arquivos empresa");
            af.executaBusca();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            SinistrosForm sf = new SinistrosForm(null) { formPrincipal = this};
            adicionarControleNavegacao(sf);
            Log.createLog(EventLog.opened, "formulario de sinistros");
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReboqueForm rf = new ReboqueForm(null) { formPrincipal = this };
            adicionarControleNavegacao(rf);
            Log.createLog(EventLog.opened, "formulario de reboques");
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaSinistrosForm bsf = new BuscaSinistrosForm() { formPrincipal = this};
            adicionarControleNavegacao(bsf);
            Log.createLog(EventLog.opened, "formulario de busca de sinistros");
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaReboqueForm brf = new BuscaReboqueForm() { formPrincipal = this};
            adicionarControleNavegacao(brf);
            Log.createLog(EventLog.opened, "formulario de reboques");
        }

        public void fechaUtilFormAtual()
        {
            if (utilForm != null)
            {
                utilForm.Close();
                Log.createLog(EventLog.cloused, "Formulario de utilidades");
                utilForm = null;
            }
        }

        private void btnLogs_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaLogs sl = new BuscaLogs();
            sl.dash = this;
            utilForm = new UtilForm(sl, this);
            Log.createLog(EventLog.opened, "formulario de visualização de log");
            utilForm.ShowDialog();
        }

        private void btnCriaBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DateTime inic = DateTime.Now;
                Log.createLog(EventLog.opened, "criação de backup.");
                IServiceGrupo conn = GerenteDeConexoes.conexaoServico();
                string fileBackup = conn.createBackup("p@ssw0rd");
                if (!String.IsNullOrEmpty(fileBackup))
                {
                    DateTime fim = DateTime.Now;
                    TimeSpan ts = fim.Subtract(inic);
                    Log.createLog(EventLog.cloused, String.Format("concluiu criação de backup em: {0} segundos", ts.TotalSeconds));
                    DialogResult rs = MessageBox.Show("Backup criado com sucesso!\nDeseja exportar arquivo para um local?",
                        "SYSNORTE TECNOLOGIA", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        MessageBox.Show("0");
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.AutoUpgradeEnabled = true;
                        sfd.Title = "Salvar Arquivo";
                        sfd.InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + @"\Documents\";
                        sfd.Filter = "Arquivo de backup SYSNORTE|*.syscrypt";
                        sfd.FileName = String.Format(@"backupSystem{0:yyyy-MM-dd_HH-mm}.syscrypt", fim);
                        MessageBox.Show("1");
                        DialogResult dr = sfd.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            MessageBox.Show("2");
                            Byte[] by = conn.download(fileBackup);
                            MessageBox.Show("3");
                            File.WriteAllBytes(sfd.FileName, by);
                            MessageBox.Show("4");
                            Log.createLog(EventLog.empty, String.Format("Exportou arquivo de backup."));
                            MessageBox.Show("Arquivo salvo com sucesso.", "SYSNORTE TECNOLOGIA");
                        }
                        else
                        {
                            MessageBox.Show("else");
                        }
                    }
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Erro ao criar backup, tente novamente\nse o problema persistir, contate o suporte.");
            }
        }

        private void btnReiniciaConexao_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Log.createLog(EventLog.empty, "tentativa de reiniciar a conexão com o servidor");
                GerenteDeConexoes.iniciaConexaoServico();
                Log.createLog(EventLog.empty, "conexão reiniciada com sucesso");
                MessageBox.Show("Conexão reiniciada com sucesso!");
            }
            catch (Exception ex)
            {
                Log.createLog(EventLog.exception, "Ocorreu um erro na tentativa de reiniciar a conexão.\n" + ex.Message);
                MessageBox.Show("Ocorreu um erro na tentativa de reiniciar a conexão.\n" + ex.Message);
            }            
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.createLog(EventLog.cloused, "aplicação no formulário principal.");
        }

        private void btnRelClientesECotas_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                bool inatividadeCliente = false;
                bool inatividadeItens = false;
                List<RelatorioClientesECotasModel> listReport = new List<RelatorioClientesECotasModel>();
                List<cliente> listClientes = conn.listaDeClientesPorInatividade(inatividadeCliente);
                decimal total_cotas_grupo = conn.retornaTotalDeBensDaEmpresaPorInatividade(inatividadeItens) / UtilsSistema.valor_por_cota;
                foreach (cliente c in listClientes)
                {
                    decimal valor_veiculos = conn.somaValorTotalVeiculoPorIdClienteEInatividade(c.id, inatividadeItens);
                    decimal valor_reboques = conn.somaValorTotalReboquesPorIdClienteEInatividade(c.id, inatividadeItens);
                    decimal valor_total_bens = valor_veiculos + valor_reboques;
                    decimal total_cotas = valor_total_bens / UtilsSistema.valor_por_cota;
                    decimal porcento_cotas = (total_cotas * 100) / total_cotas_grupo;

                    listReport.Add(new RelatorioClientesECotasModel()
                    {
                        nomeCliente = c.nome_completo,
                        dataInclusao = c.data_ativacao,
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}