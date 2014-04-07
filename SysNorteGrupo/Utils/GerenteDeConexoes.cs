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

        public static void carregaURL(string _ip, string _porta)
        {
            ipServico = _ip;
            porta = _porta;
            url = String.Format("net.tcp://{0}:{1}/grupo/service", ipServico, porta);
        }

        public static void iniciaConexaoServico()
        {
            /*vEndPoint = null;
            netTcpBinding = null;
            conn = null;*/
            try
            {
                ipServico = FilesINI.ReadValue("sistema", "ipServico");
                porta = FilesINI.ReadValue("sistema", "porta");
                carregaURL(ipServico, porta);

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
                //MessageBox.Show(ex.Message);
                throw new Exception(ex.Message, ex.InnerException);
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

