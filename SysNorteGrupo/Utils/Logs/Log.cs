using EntitiesGrupo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfLibGrupo;

namespace SysNorteGrupo.Utils
{
    public class Log
    {
        private static usuario usuario_ativo = Program.usuario_instc;
        public static void createLog(String _eventLog, String _message)
        {
            int i;
            /*
             * 0 = erro, 1 = sucesso.
             * ira fazer 3 tentavivas, caso não conseguir em nenhuma das tentavivas,
             * deixa a Thread rodar e ignora o Log.
            */
            //tentativa 1
            i = generateLog(_eventLog, _message);
            if (i == 0)
            {
                //tentativa 2
                i = generateLog(_eventLog, _message);
            }
            if (i == 0)
            {
                //tentativa 3
                i = generateLog(_eventLog, _message);
            }
        }

        private static int generateLog(String _eventLog, String _message)
        {
            IServiceGrupo conn = GerenteDeConexoes.recuperaConexao();
            string _ip = Util.GetIpHost();
            string _host = Util.GetHostName();
            string _user = String.Empty;
            if (usuario_ativo != null)
            {
                _user = usuario_ativo.login;
            }
            log _log = new log() { dateTime = conn.retornaDataHoraLocal().ToString(), user = _user, host = String.Format("{0}({1})", _host, _ip), eventLog = _eventLog, message = _message };
            int countLog = conn.createLog(_log);
            return countLog;
        }

        public List<log> readLog(string parameter, string parameterTwo, string parameterThree)
        {
            IServiceGrupo conn = GerenteDeConexoes.recuperaConexao();
            return conn.ReadLog(parameter, parameterTwo, parameterThree);
        }
    }

    public class EventLog
    {
        public static string empty = "nullo";
        public static string opened = "abriu";
        public static string registered = "registrou";
        public static string edited = "editou";
        public static string saveEdited = "salvou edição";
        public static string executedSearch = "executou a pesquisa";
        public static string visualized = "visualizou";
        public static string inatived = "inativou";
        public static string cloused = "fechou";
        public static string exited = "saiu";
        public static string entered = "entrou";
        public static string exception = "exception";

        public static string deleted = "excluiu";
        public static string added = "adicionou";
        public static string downloaded = "baixou";
    }
    /*
    public partial class log
    {
        public string eventLog { get; set; }
        public string message { get; set; }
        public string user { get; set; }
        public DateTime dateTime { get; set; }
        public string host { get; set; }
    }*/
}
