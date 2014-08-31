﻿using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using EntitiesGrupo;
using HostWcfGrupo.UI.Utils;
using HostWcfGrupo.Utils;
using HostWcfGrupo.Utils.ValidacaoSistema;
using System;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using WcfLibGrupo;
using WcfLibGrupo.Utils;

namespace HostWcfGrupo.UI
{
    public partial class Form1 : Form
    {
        private ServiceHost host;
        private string status = "started";

        public Form1(int i)
        {
            InitializeComponent();
            notifyIcon.Icon = ((System.Drawing.Icon)new System.Drawing.Icon(Directory.GetCurrentDirectory() + "\\favicon.ico"));
            notifyIcon.Text = "SysNorteGrupo Server";
            try
            {                
                this.Text = "SysNorteGrupo Server";
                //if (verificaAutenticidade(i))
                //{
                    service(1);
                //}
            }
            catch (Exception ex)
            {
                btnStartStop.Enabled = false;
                tfStatus.Text += "\n\n" + ex.Message + "\n" + ex.InnerException;
            }
            Thread.Sleep(1500);
        }
        private bool verificaAutenticidade(int i){
            ServiceGrupo sg = new ServiceGrupo();
            DateTime dataUTC = new DateTime();
            try
            {
                dataUTC = sg.retornaDataHoraUTC();
            }
            catch (Exception){}
            try
            {
                btnStartStop.Enabled = true;
                try
                {
                    if(sg.retornaDataHoraLocal().Date != dataUTC.Date){
                        string execData = String.Format("Set-Date {0:yyyy-MM-dd}", dataUTC);
                        Util.execProcess(execData, null, true);
                    }
                    string execHora = String.Format("Set-Date {0:HH:mm:ss}", dataUTC);
                    Util.execProcess(execHora, null, true);
                }catch(Exception ex){
                    XtraMessageBox.Show("Ocorreu um erro, não foi possivel verificar a validade do sistema, verifique se a data da maquina esta correta e tente novamente.\n" + ex.Message);
                    Environment.Exit(0);
                    return false;
                }
                int VerificaOnline = verificaOnline();
                if(i > 0)
                {
                    DialogResult rs = XtraMessageBox.Show("Sistema iniciado em modo de autenticação local.\nSe você obtem o arquivo de liberação, pressione OK, caso contrario contate o suporte!",
                        "SYSNORTE TECNOLOGIA", MessageBoxButtons.OKCancel);
                    if (rs == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + @"\Documents\";
                    ofd.AutoUpgradeEnabled = true;
                    ofd.Filter = "Arquivo SYSNORTE|*.sysnorte";
                    DialogResult dr = ofd.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        string value = "";
                        if (InputBox.show("SYSNORTE TECNOLOGIA", "Informe a senha do arquivo:", ref value, true) == DialogResult.OK)
                        {
                            string senhaArquivo = value;
                            string arquivoSaida = UtilsSistemaServico.SUBDIR_TEMP_FILES + String.Format("{0:yyyy-MM-dd}_sysnorte", sg.retornaDataHoraLocal());
                            //Cryptology.DecryptFile(ofd.FileName, arquivoSaida, senhaArquivo);
                            StreamReader arquivo = new StreamReader(arquivoSaida);                            
                            //0               1               2          3       4      5
                            //SYSNORTE|01.345.678/0001-69|2014-03-16|2014-03-17|SYSGRUPO|SYSNORTE
                            string[] ta = arquivo.ReadToEnd().Split('|');
                            arquivo.Close();
                            File.Delete(arquivoSaida);
                            int arquivoValido = verificaArquivoValido(ta);
                            if (arquivoValido == 1)
                            {
                                empresa _empresa = sg.retornaEmpresa();
                                if(!ta[1].Equals(_empresa.cnpj))
                                {
                                    XtraMessageBox.Show("Arquivo inválido para numero de documento informado!");
                                    Environment.Exit(0);
                                }
                                if(sg.retornaDataHoraLocal() < DateTime.Parse(ta[2]) || sg.retornaDataHoraLocal() > DateTime.Parse(ta[3]) )
                                {
                                    XtraMessageBox.Show("Arquivo invalido para esta data!");
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Arquivo inválido!");
                            }

                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }                    
                if (VerificaOnline == 1)
                {
                    return true;
                }
                else if (VerificaOnline == 0)
                {                    
                    btnStartStop.Enabled = false;
                    tfStatus.Text = "Não foi possivel iniciar o serviço."
                        + "\nOcorreu um erro na verificação ou status esta definido como inativo, contate o suporte.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + Environment.NewLine + ex.InnerException);                
            }
            return false;
        }

        int verificaArquivoValido(string[] ta)
        {
            int flag = 0;
            try
            {
                /*MessageBox.Show(ta[0]);
                MessageBox.Show(ta[1]);
                MessageBox.Show(ta[2]);
                MessageBox.Show(ta[3]);
                MessageBox.Show(ta[4]);
                MessageBox.Show(ta[5]);
                MessageBox.Show(ta[6]);*/
                if (ta[0].Trim().Equals("SYSNORTE")
                    && !String.IsNullOrEmpty(ta[1])
                    && !String.IsNullOrEmpty(ta[2])
                    && !String.IsNullOrEmpty(ta[3])
                    && ta[4].Trim().Equals("SYSGRUPO")
                    && ta[5].Trim().Equals("SYSNORTE"))
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
            catch (Exception ex)
            {
                flag = -1;
                throw new Exception(ex.Message);
            }
            return flag;
        }

        private int verificaOnline()
        {            
            int flag = 0;
            try
            {
                ServiceGrupo sg = new ServiceGrupo();
                empresa _empresa = sg.retornaEmpresa();
                ValidacaoUtilizacao vu = new ValidacoesDAO().recuperarClientePorCnpj(_empresa.cnpj);
                if(_empresa.cnpj.Equals(vu.cnpj))
                {
                    if (vu.inativo == false && vu.data_expiracao.Date >= sg.retornaDataHoraLocal().Date)
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                    validacoes_sistema vs = new validacoes_sistema()
                    {
                        inativo = vu.inativo,
                        data_expiracao = vu.data_expiracao,
                        data_verificacao = sg.retornaDataHoraLocal()
                    };
                }
                else
                {
                    flag = 0;
                }
            }
            catch (Exception)
            {
                flag = 0;            
            }
            return flag;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if ("stopped".Equals(status))
                {
                    service(1);                    
                }
                else
                {
                    service(0);                    
                }
            }
            catch (Exception ex)
            {
                tfStatus.Text = null;
                btnStartStop.Enabled = false;
                throw new Exception(String.Format("Erro ao iniciar serviço/parar{0}EXCEPT: {1}{0}INNER EXCEPT: {2}", Environment.NewLine, ex.Message, ex.InnerException));
            }
        }

        private void service(int i)
        {
            string url = UtilsSistemaServico.enderecoServico;
            try
            {
                if (i == 1)
                {                    
                    host = new ServiceHost(typeof(ServiceGrupo));
                    var b = new NetTcpBinding(SecurityMode.None);
                    b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
                    b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
                    b.ReceiveTimeout = TimeSpan.FromMinutes(20);
                    b.Security.Message.ClientCredentialType = MessageCredentialType.None;
                    host.AddServiceEndpoint(typeof(IServiceGrupo), b, new Uri(url));
                    host.Open();                    
                    status = "started";
                    btnStartStop.Text = "Parar Serviço";
                    itemService.Text = btnStartStop.Text;
                    tfStatus.Text = "Serviço iniciado com sucesso.";
                }
                else if(i == 0)
                {
                    host.Abort();
                    host.Close();
                    status = "stopped";
                    btnStartStop.Text = "Iniciar Serviço";
                    itemService.Text = btnStartStop.Text;
                    tfStatus.Text = "Serviço parado com sucesso.";
                }
                else
                {
                    XtraMessageBox.Show("Ocorreu um erro.");
                }
            }
            catch (Exception ex)
            {
                btnStartStop.Enabled = false;
                tfStatus.Text = ex.Message;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            reloadNotifyIcons(false);
            DialogResult rs = XtraMessageBox.Show("O serviço sera parado e todos as maquinas clientes desconectadas.\nDeseja continuar?", "SYSNORTE",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(PleaseWaitForm), false, false);
                    /*DBTools.pathPgDump = UtilsSistemaServico.DIR_PG_DUMP;
                    DBTools.tempPathWithFile = UtilsSistemaServico.SUBDIR_TEMP_FILES + @"temp.sql";
                    DBTools.pathSaveBackup = UtilsSistemaServico.SUBDIR_BACKUP;
                    DBTools.passwordFile = "a1s2 d3f4&beguta";
                    DBTools.host = SysGrupoRepo.host;
                    DBTools.port = SysGrupoRepo.port;
                    DBTools.dataBase = SysGrupoRepo.db;
                    DBTools.user = SysGrupoRepo.user;
                    DBTools.password = SysGrupoRepo.passwd;
                    DBTools.backup();*/
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(String.Format("Ocorreu um erro.\n{0}\n\n{1}", ex.Message, ex.InnerException));
                }
                finally
                {
                    reloadNotifyIcons(true);
                    SplashScreenManager.CloseForm();
                }
            }
            else
            {
                reloadNotifyIcons(true);
            }
        }

        private void reloadNotifyIcons(bool p)
        {
            if (contextMenu.MenuItems.Count > 0)
            {
                foreach (MenuItem m in contextMenu.MenuItems)
                {
                    m.Enabled = p;
                }
            }
        }

        private void runProcess(string file_name, string working_directory, string line_arguments)
        {
            try
            {
                using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    startInfo.FileName = file_name;
                    startInfo.WorkingDirectory = working_directory;
                    if(!String.IsNullOrEmpty(line_arguments))
                    {
                        startInfo.Arguments = line_arguments;
                    }
                    process.StartInfo = startInfo;
                    process.Start();
                    process.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Focus();
        }

        private void itemRestart_Click(object sender, EventArgs e)
        {

        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Todos os serviços que estão"
                + " sendo executados serão parados e os dados perdidos.\n Você tem certeza que deseja sair?", "Confirmação de Saida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.No)
                return;
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.itemExit_Click(sender, e);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
