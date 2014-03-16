using EntitiesGrupo;
using HostWcfGrupo.Utils.ValidacaoSistema;
using System;
using System.Diagnostics;
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

        public Form1(int i)
        {
            InitializeComponent();
            try
            {                
                this.Text = "SysNorteGrupo Server";
                if (verificaAutenticidade())
                {
                    service(1);
                }
            }
            catch (Exception ex)
            {
                btnStartStop.Enabled = false;
                tfStatus.Text += "\n\n" + ex.Message + "\n" + ex.InnerException;
            }
        }
        private bool verificaAutenticidade(){
            ServiceGrupo sg = new ServiceGrupo();
            DateTime dataUTC = new DateTime();
            try
            {
                dataUTC = sg.retornaDataHoraUTC().Date;
            }
            catch (Exception ex){}
            try
            {
                btnStartStop.Enabled = true;                
                if (sg.retornaDataHoraLocal().Date != dataUTC)
                {
                    MessageBox.Show("Não foi possivel verificar a validade do sistema, verifique se a data da maquina esta correta e tente novamente.");
                    Environment.Exit(0);
                    return false;
                }
                if(sg.CountValidacoesSistema() > 100){
                    sg.excluiTodasValidacoes();
                }
                validacoes_sistema vs = sg.retornaUltimaValidacaoSistema();
                int VerificaOnline = verificaOnline();
                if (VerificaOnline == 1)
                {
                    return true;
                }
                else if (VerificaOnline == 0)
                {                    
                    btnStartStop.Enabled = false;
                    tfStatus.Text = "Não foi possivel iniciar o serviço."
                        + "\nStatus esta definido como inativo, contate o suporte.";
                    return false;
                }
                else if (VerificaOnline == -1)
                {
                    if(!vs.inativo && vs.data_expiracao >= sg.retornaDataHoraLocal()){
                        return true;
                    }
                    else
                    {
                        btnStartStop.Enabled = false;
                        tfStatus.Text = "Não foi possivel iniciar o serviço."
                            +"\nTentativa de verificação online falhou, e status local esta definido como inativo"
                            +"\nVerifique a conexao com a internet ou contate o suporte.";
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + Environment.NewLine + ex.InnerException);                
            }
            return false;
        }

        private int verificaOnline()
        {            
            int flag = 0;
            try
            {
                ServiceGrupo sg = new ServiceGrupo();
                empresa _empresa = sg.retornaEmpresa();
                ValidacaoUtilizacao vu = new ValidacoesDAO().recuperarPorNome(_empresa.razao_social);
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
                sg.salvarValidacaoSistema(vs);
            }
            catch (Exception ex)
            {
                flag = -1;            
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
            try
            {
                if (i == 1)
                {
                    host = new ServiceHost(typeof(ServiceGrupo));
                    var b = new NetTcpBinding(SecurityMode.None);
                    b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
                    b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
                    b.Security.Message.ClientCredentialType = MessageCredentialType.None;
                    host.AddServiceEndpoint(typeof(IServiceGrupo), b, new Uri("net.tcp://localhost:8001/grupo/service"));
                    host.Open();
                    UtilsSistemaServico.carregaConfigurações();
                    status = "started";
                    btnStartStop.Text = "Stop service";
                    tfStatus.Text = "Service started successfully.";
                }
                else if(i == 0)
                {
                    host.Abort();
                    host.Close();
                    status = "stopped";
                    btnStartStop.Text = "Start service";
                    tfStatus.Text = "Service stopped successfully.";
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro.");
                }
            }
            catch (Exception ex)
            {
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
