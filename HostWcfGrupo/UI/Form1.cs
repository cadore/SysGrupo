using DevExpress.XtraEditors;
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
        private ServiceHost host1;
        private ServiceHost host2;
        private StatusService status;
        private int args;

        public enum StatusService
        {
            started = 0,
            stopped = 1
        }
        public Form1(int _i)
        {
            InitializeComponent();
            this.Text = "CadoreTecnologia - SysGrupo Server v3.0.1";
            notifyIcon.Icon = ((System.Drawing.Icon)new System.Drawing.Icon(Directory.GetCurrentDirectory() + "\\favicon.ico"));
            notifyIcon.Text = this.Text;
            args = _i;

            if (args == 0)
            {
                XtraMessageBox.Show("SysGrupo Server, é necessário informar a filial!\nEntre em contato com o suporte!", "Cadore Tecnologia");
                Environment.Exit(-2);
            }
            else if (args == 1)
            {
                SysGrupoRepo.StartDB("sysgrupodb_lucas");
                tfFilial.Text = "Filial Lucas do Rio Verde-MT";
                notifyIcon.Text = String.Format("CadoreTecnologia - SysGrupo Server\n{0}", tfFilial.Text);
            }
            else if (args == 2)
            {
                SysGrupoRepo.StartDB("sysgrupodb_sinop");
                tfFilial.Text = "Filial Sinop-MT";
                notifyIcon.Text = String.Format("CadoreTecnologia - SysGrupo Server\n{0}", tfFilial.Text);
            }

            try
            {               
                service(StatusService.stopped);
            }
            catch (Exception ex)
            {
                btnStartStop.Enabled = false;
                tfStatus.Text += "\n\n" + ex.Message + "\n" + ex.InnerException;
            }            
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == StatusService.stopped)
                {
                    service(StatusService.stopped);                    
                }
                else
                {
                    service(StatusService.started);                    
                }
            }
            catch (Exception ex)
            {
                tfStatus.Text = null;
                btnStartStop.Enabled = false;
                throw new Exception(String.Format("Erro ao iniciar/parar serviço{0}EXCEPT: {1}{0}INNER EXCEPT: {2}", Environment.NewLine, ex.Message, ex.InnerException));
            }
        }

        private void service(StatusService i)
        {
            try
            {
                if (i == StatusService.stopped)
                {
                    if (args == 1) startService1();
                    if (args == 2) startService2();

                    status = StatusService.started;
                    btnStartStop.Text = "Parar Serviço";
                    itemService.Text = btnStartStop.Text;
                    tfStatus.Text = "Serviço iniciado com sucesso.";
                }
                else if (i == StatusService.started)
                {
                    if (args == 1) stopService1();
                    if (args == 2) stopService2();

                    status = StatusService.stopped;
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

        private void startService1()
        {
            string urlservice1 = @"net.tcp://localhost:8001/cadoretecnologia/grupo/service1";
            host1 = new ServiceHost(typeof(ServiceGrupo));
            var b = new NetTcpBinding(SecurityMode.None);
            b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
            b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
            b.ReceiveTimeout = TimeSpan.FromMinutes(20);
            b.Security.Message.ClientCredentialType = MessageCredentialType.None;
            host1.AddServiceEndpoint(typeof(IServiceGrupo), b, new Uri(urlservice1));
            host1.Open();
        }
        private void stopService1()
        {
            host1.Abort();
            host1.Close();
        }

        private void startService2()
        {
            string urlservice2 = @"net.tcp://localhost:8002/cadoretecnologia/grupo/service2";
            host2 = new ServiceHost(typeof(ServiceGrupo));
            var b = new NetTcpBinding(SecurityMode.None);
            b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
            b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
            b.ReceiveTimeout = TimeSpan.FromMinutes(20);
            b.Security.Message.ClientCredentialType = MessageCredentialType.None;
            host2.AddServiceEndpoint(typeof(IServiceGrupo), b, new Uri(urlservice2));
            host2.Open();
        }
        private void stopService2()
        {
            host2.Abort();
            host2.Close();
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
