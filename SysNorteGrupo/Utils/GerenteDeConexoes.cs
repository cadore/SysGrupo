using DevExpress.XtraSplashScreen;
using SysNorteGrupo.UI.Utils;
using SysNorteGrupo.Utils;
using System;
using System.ServiceModel;
using System.Windows;
using WcfLibGrupo;

namespace SysNorteGrupo
{
    public class GerenteDeConexoes
    {
        private static EndpointAddress vEndPoint;
        private static NetTcpBinding netTcpBinding;
        public static IServiceGrupo conn = null;
        private static string url;
        public static string ipServico;
        public static string porta;
        public static string link;

        public static void carregaURLServico(string _ip, string _porta, string _link)
        {
            ipServico = _ip;
            porta = _porta;
            link = _link;
            url = String.Format("net.tcp://{0}:{1}/cadoretecnologia/grupo/{2}", ipServico, porta, link);
        }

        public static void iniciaConexaoServico()
        {
            /*vEndPoint = null;
            netTcpBinding = null;
            conn = null;*/
            try
            {
                SplashScreenManager.ShowForm(typeof(PleaseWaitForm));

                string __ipServico = FilesINI.ReadValue("sistema", "ipServico");
                string __porta = FilesINI.ReadValue("sistema", "porta");
                string __link = FilesINI.ReadValue("sistema", "link");
                carregaURLServico(__ipServico, __porta, __link);
                netTcpBinding = new NetTcpBinding(SecurityMode.None);                
                netTcpBinding.MaxBufferPoolSize = netTcpBinding.MaxBufferPoolSize * 2552350000256000154;
                netTcpBinding.MaxReceivedMessageSize = netTcpBinding.MaxReceivedMessageSize * 5000;
                netTcpBinding.ReceiveTimeout = TimeSpan.FromMinutes(20);
                vEndPoint = new EndpointAddress(url);
                ChannelFactory<IServiceGrupo> cf = new ChannelFactory<IServiceGrupo>(netTcpBinding, vEndPoint);
                conn = cf.CreateChannel();
                conn.retornaDataHoraLocal();                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            finally
            {
                SplashScreenManager.CloseForm();
            }
        }

        public static IServiceGrupo conexaoServico()
        {
            try
            {
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}

