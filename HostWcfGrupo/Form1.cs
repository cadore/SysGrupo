using System;
using System.ServiceModel;
using System.Windows.Forms;
using WcfLibGrupo;
using WcfLibGrupo.Utils;

namespace HostWcfGrupo
{
    public partial class Form1 : Form
    {
        private ServiceHost host;
        private string status = "started";

        public Form1()
        {
            InitializeComponent();
            this.Text = "SysNorteGrupo Server";
            service(1);
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            try
            {
                if ("stopped".Equals(status))
                {
                    service(1);
                    status = "started";
                    btnStartStop.Text = "Stop service";
                    tfStatus.Text = "Service started successfully.";
                }
                else
                {
                    service(0);
                    status = "stopped";
                    btnStartStop.Text = "Start service";
                    tfStatus.Text = "Service stopped successfully.";
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
            try
            {
                if (i == 1)
                {
                    host = new ServiceHost(typeof(ServiceGrupo));
                    var b = new WSHttpBinding(SecurityMode.None);
                    b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
                    b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
                    b.Security.Message.ClientCredentialType = MessageCredentialType.None;
                    host.AddServiceEndpoint(typeof(IServiceGrupo), b, new Uri("http://localhost:8001/grupo/service"));
                    host.Open();
                    UtilsSistemaServico.carregaConfigurações();
                }
                else if(i == 0)
                {
                    host.Abort();
                    host.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro.");
                }
            }
            catch (Exception ex)
            {
                tfStatus.Text = null;
                btnStartStop.Enabled = false;
                tfStatus.Text = ex.Message;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            service(0);
        }
    }
}
