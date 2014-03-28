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

        public static void iniciaConexao()
        {
            try
            {
                vEndPoint = null;
                netTcpBinding = null;
                url = null;
                conn = null;

                netTcpBinding = new NetTcpBinding(SecurityMode.None);
                url = FilesINI.ReadValue("sistema", "enderecoServico");
                netTcpBinding.MaxBufferPoolSize = netTcpBinding.MaxBufferPoolSize * 2552350000256000154;
                netTcpBinding.MaxReceivedMessageSize = netTcpBinding.MaxReceivedMessageSize * 5000;
                netTcpBinding.ReceiveTimeout = TimeSpan.FromMinutes(20);
                vEndPoint = new EndpointAddress(url);
                ChannelFactory<IServiceGrupo> cf = new ChannelFactory<IServiceGrupo>(netTcpBinding, vEndPoint);
                conn = cf.CreateChannel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static IServiceGrupo recuperaConexao()
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

