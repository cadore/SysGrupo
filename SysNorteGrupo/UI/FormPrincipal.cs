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
using SysNorteGrupo.UI.Utils;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using System.Threading;
using SysNorteGrupo.UI.Financeiro;
using SysNorteGrupo.Reports.Gerencial;

namespace SysNorteGrupo
{
    public partial class FormPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IServiceGrupo conn;
        private UtilForm utilForm;
        public UserControl controleAtual = null;
        public bool thisIDLE = false;
        private Thread threadHora;
        private Thread threadInfo;
        
        public FormPrincipal(usuario usuario_instc)
        {
            SplashScreenManager.ShowForm(typeof(SplashForm), false, false);
            startIDLE();
            if (usuario_instc == null)
            {
                Program.startApplication();
                this.Dispose();                
            }
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            //carregaPermissoes(permicao_instc);
            this.Text = String.Format("SysNorte Tecnologia Copyright © 2014 | SysNorteGrupo | Usuário: {0} | Versão: 1.0.0.0", usuario_instc.login);
            iniciaThreadRecarregaInformacoesDesktop();
            iniciaThreadDataHora();
            SplashScreenManager.CloseForm();
        }

        public void iniciaThreadDataHora()
        {
            Thread _newThread = new Thread(new ThreadStart(carregaDataHora));
            threadHora = _newThread;
            threadHora.Start();
        }

        void carregaDataHora()
        {
            try
            {
                while (true)
                {
                    if (DateTime.Now.Second == 1 || lbDataHora.Caption.Equals("lbDataHora"))
                    {
                        DateTime dataHoraServidor = conn.retornaDataHoraLocal();
                        string dataHora = String.Format("{0:dddd, dd/MM/yyyy HH:mm}", dataHoraServidor);

                        char primeiraLetra = char.ToUpper(dataHora[0]);
                        dataHora = primeiraLetra + dataHora.Substring(1);
                        lbDataHora.Caption = dataHora;
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception)
            {
                threadHora.Abort("Thread aborted");
                XtraMessageBox.Show("Ocorreu um problema ao verificar a Data/Hora do servidor");
            }
        }

        public void iniciaThreadRecarregaInformacoesDesktop()
        {
            Thread _newThread = new Thread(new ThreadStart(subThreadRecarregaInformacoesDesktop));
            threadInfo = _newThread;
            threadInfo.Start();
        }

        void subThreadRecarregaInformacoesDesktop()
        {
            try
            {
                while (true)
                {
                    if (ckMostrarPainelInformacoes.Checked)
                    {
                        recarregaInformacoesDesktop();
                    }
                    Thread.Sleep(60000);
                }
            }
            catch (Exception)
            {
                threadInfo.Abort("Thread aborted");
                XtraMessageBox.Show("Ocorreu um problema ao verificar a as informações do Desktop automaticamente.");
            }
        }

        private void recarregaInformacoesDesktop()
        {
            try
            {
                long clientes_ativos = conn.totalDeClientesPorInatividade(false);
                long clientes_inativos = conn.totalDeClientesPorInatividade(true);
                lbTotal_clientes.Text = String.Format("{0} CLIENTE(S)", clientes_ativos + clientes_inativos);
                lbClientes_ativos.Text = String.Format("{0} ATIVO(S)", clientes_ativos);
                lbClientes_inativos.Text = String.Format("{0} INATIVO(S)", clientes_inativos);


                long veiculos_ativos = conn.totalDeVeiculosPorInatividade(false);
                long veiculos_inativos = conn.totalDeVeiculosPorInatividade(true);
                lbTotal_veiculos.Text = String.Format("{0} VEÍCULO(S)", veiculos_ativos + veiculos_inativos);
                lbVeiculos_ativos.Text = String.Format("{0} ATIVO(S)", veiculos_ativos);
                lbVeiculos_inativos.Text = String.Format("{0} INATIVO(S)", veiculos_inativos);

                long reboques_ativos = conn.totalDeReboquesPorInatividade(false);
                long reboques_inativos = conn.totalDeReboquesPorInatividade(true);
                lbTotal_reboques.Text = String.Format("{0} REBOQUE(S)", reboques_ativos + reboques_inativos);
                lbReboques_ativos.Text = String.Format("{0} ATIVO(S)", reboques_ativos);
                lbReboques_inativos.Text = String.Format("{0} INATIVO(S)", reboques_inativos);

                long sinistros_concluidos = conn.totalDeSinistrosPorSituacao(1);
                long sinistros_em_andamento = conn.totalDeSinistrosPorSituacao(0);
                lbTotal_sinistros.Text = String.Format("{0} SINISTRO(S)", sinistros_concluidos + sinistros_em_andamento);
                lbSinistros_concluidos.Text = String.Format("{0} CONCLUIDO(S)", sinistros_concluidos);
                lbSinistros_em_andamento.Text = String.Format("{0} EM ANDAMENTO", sinistros_em_andamento);

                decimal total_bens_ativos = conn.somaDeValoresDeReboquesPorInatividade(false) 
                    + conn.somaDeValoresDeVeiculosPorInatividade(false);
                decimal total_bens_inativos = conn.somaDeValoresDeReboquesPorInatividade(true)
                    + conn.somaDeValoresDeVeiculosPorInatividade(true);

                lbTotalDeBens.Text = String.Format("{0:c} EM BENS", total_bens_ativos + total_bens_inativos);
                lbBensAtivos.Text = String.Format("{0:c} ATIVOS", total_bens_ativos);
                lbBensInativos.Text = String.Format("{0:c} INATIVOS", total_bens_inativos);

                lbTotalCotas.Text = String.Format("{0:n2} COTAS", (total_bens_ativos + total_bens_inativos) / ConfigSistema.valor_por_cota);
                lbCotasAtivas.Text = String.Format("{0:n2} ATIVAS", total_bens_ativos / ConfigSistema.valor_por_cota);
                lbCotasInativas.Text = String.Format("{0:n2} INATIVAS", total_bens_inativos / ConfigSistema.valor_por_cota);
            }
            catch (Exception)
            {
                //XtraMessageBox.Show(String.Format("Ocorreu um problema ao recuperar as informações da area de trabalho."));

                lbTotal_clientes.Text = String.Format("{0:n} CLIENTE(S)", 0);
                lbClientes_ativos.Text = String.Format("{0:n} ATIVO(S)", 0);
                lbClientes_inativos.Text = String.Format("{0:n} INATIVO(S)", 0);

                lbTotal_veiculos.Text = String.Format("{0:n} VEÍCULO(S)", 0);
                lbVeiculos_ativos.Text = String.Format("{0:n} ATIVO(S)", 0);
                lbVeiculos_inativos.Text = String.Format("{0:n} INATIVO(S)", 0);

                lbTotal_reboques.Text = String.Format("{0:n} REBOQUE(S)", 0);
                lbReboques_ativos.Text = String.Format("{0:n} ATIVO(S)", 0);
                lbReboques_inativos.Text = String.Format("{0:n} INATIVO(S)", 0);

                lbTotal_sinistros.Text = String.Format("{0:n} SINISTRO(S)", 0);
                lbSinistros_concluidos.Text = String.Format("{0:n} CONCLUIDO(S)", 0);
                lbSinistros_em_andamento.Text = String.Format("{0:n} EM ANDAMENTO", 0);

                lbTotalDeBens.Text = String.Format("{0:c} EM BENS", 0);
                lbBensAtivos.Text = String.Format("{0:c} ATIVOS", 0);
                lbBensInativos.Text = String.Format("{0:c} INATIVOS", 0);

                lbTotalCotas.Text = String.Format("{0:n2} COTAS", 0);
                lbCotasAtivas.Text = String.Format("{0:n2} ATIVAS", 0);
                lbCotasInativas.Text = String.Format("{0:n2} INATIVAS", 0);
                if (this.IsDisposed)
                    Application.Exit();
            }
        }

        void startIDLE()
        {
            int minutos = 5;
            if (ConfigSistema.minutosIDLE > 0)
            {
                minutos = ConfigSistema.minutosIDLE;
            }

            var userIdleDetect = UserIdleDetect.StartDetection(UserIdleDetect.minutes(minutos));
            userIdleDetect.UserIdleDetected += userIdleDetect_UserIdleDetected;
        }

        void userIdleDetect_UserIdleDetected(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                bool idle = true;
                if (idle && !thisIDLE)
                {
                    Log.createLog(EventLog.empty, String.Format("bloqueou aplicação por estar mais que {0} minutos inativo", FilesINI.ReadValue("sistema", "IDLE")));
                    thisIDLE = true;
                    this.pnControl.Controls.Clear();
                    LoginForm loginFormIDLE = new LoginForm();
                    loginFormIDLE.formPrincipal = this;
                    loginFormIDLE.lbAviso.Visible = true;
                    loginFormIDLE.ShowDialog();
                }
            });
        }

        void carregaPermissoes(permicoes_usuario p)
        {            
            btnNovoCliente.Enabled = p.cadastrar_cliente;
            btnNovoVeiculo.Enabled = p.cadastrar_veiculo;
            ribUsuarios.Enabled = p.usuarios;
            rpFinanceiro.Visible = p.financeiro;
        }
        public void adicionarControleNavegacao(UserControl controle)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(SysNorteGrupo.UI.Utils.PleaseWaitForm), false, false, false);                
                this.pnControl.Controls.Clear();
                if (controle != null)
                {
                    controle.Visible = false;
                    this.pnControl.Controls.Add(controle);
                    this.MinimumSize = controle.Size + new Size(0, ribbon.Height) + new Size(20, 35);
                }
                else
                {
                    this.MinimumSize = new Size(720, 561);
                    recarregaInformacoesDesktop();
                }
                controleAtual = controle;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro durante a solicitação.\n" + ex.Message);
            }
            finally
            {
                if (controle != null)
                {
                    controle.Visible = true;
                }
                this.pnControl.Controls.Add(this.pnInformacoes);
                this.pnInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
                SplashScreenManager.CloseForm(false);
            }
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
            af.Height = 400;
            adicionarControleNavegacao(af);
            Log.createLog(EventLog.opened, "formulario de arquivos empresa");
            af.executaBusca();
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
            BuscaLogs bl = new BuscaLogs();
            bl.dash = this;
            Log.createLog(EventLog.opened, "formulario de visualização de log");
            utilForm = new UtilForm(bl, this);
            utilForm.ShowDialog();
        }

        private void btnCriaBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            /*DialogResult drc = XtraMessageBox.Show("Confirma criação de backup?\nO servidor será parado durante a operação.", "SYSNORTE TECNOLOGIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (drc == DialogResult.OK)
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof (PleaseWaitForm));
                    DateTime inic = DateTime.Now;
                    Log.createLog(EventLog.opened, "criação de backup.");
                    IServiceGrupo conn = GerenteDeConexoes.conexaoServico();
                    string fileBackup = conn.createBackup("p@ssw0rd");
                    SplashScreenManager.CloseForm();
                    if (!String.IsNullOrEmpty(fileBackup))
                    {
                        DateTime fim = DateTime.Now;
                        TimeSpan ts = fim.Subtract(inic);
                        Log.createLog(EventLog.cloused, String.Format("concluiu criação de backup em: {0} segundos", ts.TotalSeconds));
                        DialogResult rs = XtraMessageBox.Show("Backup criado com sucesso!\nDeseja exportar arquivo para um local?",
                            "SYSNORTE TECNOLOGIA", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            SaveFileDialog sfd = new SaveFileDialog();
                            sfd.AutoUpgradeEnabled = true;
                            sfd.Title = "Salvar Arquivo";
                            sfd.InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + @"\Documents\";
                            sfd.Filter = "Arquivo de backup SYSNORTE|*.syscrypt";
                            sfd.FileName = String.Format(@"backupSystem{0:yyyy-MM-dd_HH-mm}.syscrypt", fim);
                            DialogResult dr = sfd.ShowDialog();
                            if (dr == DialogResult.OK)
                            {
                                Byte[] by = conn.download(fileBackup);
                                File.WriteAllBytes(sfd.FileName, by);
                                Log.createLog(EventLog.empty, String.Format("Exportou arquivo de backup."));
                                XtraMessageBox.Show("Arquivo salvo com sucesso.", "SYSNORTE TECNOLOGIA");
                            }
                        }
                    }

                }
                catch (Exception)
                {
                    //SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Erro ao criar backup, tente novamente\nse o problema persistir, contate o suporte.");
                }
            }*/
        }

        private void btnReiniciaConexao_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Log.createLog(EventLog.empty, "tentativa de reiniciar a conexão com o servidor");
                GerenteDeConexoes.iniciaConexaoServico();
                conn = GerenteDeConexoes.conexaoServico();
                Log.createLog(EventLog.empty, "conexão reiniciada com sucesso");
                XtraMessageBox.Show("Conexão reiniciada com sucesso!");
            }
            catch (Exception ex)
            {
                Log.createLog(EventLog.exception, "Ocorreu um erro na tentativa de reiniciar a conexão.\n" + ex.Message);
                XtraMessageBox.Show("Ocorreu um erro na tentativa de reiniciar a conexão.\n" + ex.Message);
            }            
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult rs = XtraMessageBox.Show("TEM CERTEZA QUE DESEJA SAIR DO SISTEMA?", "SYSNORTE TECNOLOGIA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Log.createLog(EventLog.cloused, "aplicação no formulário principal.");
                    //threadHora.Abort("Thread aborted");
                    //threadInfo.Abort("Thread aborted");
                    this.Hide();
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("OCORREU UM ERRO AO FINALIZAR O SISTEMA, FORÇANDO PARADA DO PROCESSO\n\n{0}", ex.Message));
                Environment.Exit(0);
            }
        }

        private void btnRelClientesECotas_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(SysNorteGrupo.UI.Utils.PleaseWaitForm), false, false);
                bool inatividadeCliente = false;
                bool inatividadeItens = false;
                List<RelatorioClientesECotasModel> listReport = new List<RelatorioClientesECotasModel>();
                List<cliente> listClientes = conn.listaDeClientesPorInatividade(inatividadeCliente);
                decimal total_cotas_grupo = conn.retornaTotalDeBensDaEmpresaPorInatividade(inatividadeItens) / ConfigSistema.valor_por_cota;
                foreach (cliente c in listClientes)
                {
                    decimal valor_veiculos = conn.somaValorTotalVeiculoPorIdClienteEInatividade(c.id, inatividadeItens);
                    decimal valor_reboques = conn.somaValorTotalReboquesPorIdClienteEInatividade(c.id, inatividadeItens);
                    decimal valor_total_bens = valor_veiculos + valor_reboques;
                    decimal total_cotas = valor_total_bens / ConfigSistema.valor_por_cota;
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
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        private void btnConfigEnderecoServico_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConfigEnderecoServico ces = new ConfigEnderecoServico();
            ces.ShowDialog();
        }

        private void btnPrefSistema_ItemClick(object sender, ItemClickEventArgs e)
        {
            PreferenciasSistema ps = new PreferenciasSistema();
            ps.ShowDialog();
        }

        private void btnAtualizaInformacoes_ItemClick(object sender, ItemClickEventArgs e)
        {
            recarregaInformacoesDesktop();
        }

        private void ckMostrarPainelInformacoes_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (ckMostrarPainelInformacoes.Checked)
            {
                subPanelInformacoes.Visible = true;
                btnAtualizaInformacoes.Enabled = true;
                recarregaInformacoesDesktop();
            }
            else
            {
                subPanelInformacoes.Visible = false;
                btnAtualizaInformacoes.Enabled = false;
            }
        }

        private void btnLimparAreaDeTrabalho_ItemClick(object sender, ItemClickEventArgs e)
        {
            adicionarControleNavegacao(null);
        }

        private void btnGerarCobrancaSinistro_ItemClick(object sender, ItemClickEventArgs e)
        {
            PagamentosSinistrosForm psf = new PagamentosSinistrosForm() { desk = this };
            adicionarControleNavegacao(psf);
        }

        private void btnGerarParcelasVeiculos_ItemClick(object sender, ItemClickEventArgs e)
        {
            ParcelasVeiculosForm pvf = new ParcelasVeiculosForm() { desk = this };
            adicionarControleNavegacao(pvf);
        }

        private void btnGerarContasAReceber_ItemClick(object sender, ItemClickEventArgs e)
        {
            GerarContasAReceberForm gcrf = new GerarContasAReceberForm() { desk = this };
            adicionarControleNavegacao(gcrf);
        }

        private void btnRelGerencialMensal_ItemClick(object sender, ItemClickEventArgs e)
        {
            RelatorioGerencialMensalSubForm rel = new RelatorioGerencialMensalSubForm();
            rel.ShowDialog();
        }
    }
}