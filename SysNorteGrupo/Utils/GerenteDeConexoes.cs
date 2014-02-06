using System.ServiceModel;
using WcfLibGrupo;

namespace SysNorteGrupo
{
    public class GerenteDeConexoes
    {
        private static EndpointAddress vEndPoint;
        private static IServiceGrupo conn = null;
        private static string URLstring = null;
        public static IServiceGrupo iniciaConexao()
        {
            URLstring = "http://localhost:8001/grupo/service";

            WSHttpBinding b = new WSHttpBinding(SecurityMode.None);
            b.MaxBufferPoolSize = b.MaxBufferPoolSize * 2552350000256000154;
            b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * 5000;
            vEndPoint = new EndpointAddress(URLstring);
            ChannelFactory<IServiceGrupo> cf = new ChannelFactory<IServiceGrupo>(b, vEndPoint);
            conn = cf.CreateChannel();
            return conn;
        }
    }
}
