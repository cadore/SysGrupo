using SysNorteGrupo.Utils;
using System.ServiceModel;
using System.Windows;
using WcfLibGrupo;

namespace SysNorteGrupo
{
    public class GerenteDeConexoes
    {
        private static EndpointAddress vEndPoint;
        private static IServiceGrupo conn = null;
        private static string url;
        public static IServiceGrupo iniciaConexao()
        {
            url = FilesINI.ReadValue("sistema", "enderecoServico");
            NetTcpBinding b = new NetTcpBinding(SecurityMode.None);
            b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
            b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
            
            //b.CloseTimeout
            //b.OpenTimeout
            //b.ReceiveTimeout
            //b.SendTimeout
            //b.ReliableSession
            
            
            vEndPoint = new EndpointAddress(url);
            ChannelFactory<IServiceGrupo> cf = new ChannelFactory<IServiceGrupo>(b, vEndPoint);
            conn = cf.CreateChannel();
            return conn;
        }
    }
}

