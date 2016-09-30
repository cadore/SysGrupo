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
        private ServiceHost host;
        private StatusService status;

        public enum StatusService
        {
            started = 0,
            stopped = 1
        }
        public Form1(int i)
        {
            InitializeComponent();
            this.Text = "SysNorteGrupo Server v2.0.1";
            notifyIcon.Icon = ((System.Drawing.Icon)new System.Drawing.Icon(Directory.GetCurrentDirectory() + "\\favicon.ico"));
            notifyIcon.Text = this.Text;
            try
            {               
                service(StatusService.stopped);
            }
            catch (Exception ex)
            {
                btnStartStop.Enabled = false;
                tfStatus.Text += "\n\n" + ex.Message + "\n" + ex.InnerException;
            }
            Thread.Sleep(1500);
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
            string url = UtilsSistemaServico.enderecoServico;
            try
            {
                if (i == StatusService.stopped)
                {                    
                    host = new ServiceHost(typeof(ServiceGrupo));
                    var b = new NetTcpBinding(SecurityMode.None);
                    b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
                    b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
                    b.ReceiveTimeout = TimeSpan.FromMinutes(20);
                    b.Security.Message.ClientCredentialType = MessageCredentialType.None;
                    host.AddServiceEndpoint(typeof(IServiceGrupo), b, new Uri(url));
                    host.Open();
                    status = StatusService.started;
                    btnStartStop.Text = "Parar Serviço";
                    itemService.Text = btnStartStop.Text;
                    tfStatus.Text = "Serviço iniciado com sucesso.";
                }
                else if (i == StatusService.started)
                {
                    host.Abort();
                    host.Close();
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
    }
}
