using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysNorteGrupo.Utils
{
    public static class Util
    {

        public static string chaveSecureApp = "a1s2 d3f4&beguta";

        public static bool textFieldIsEmpty(TextEdit textField)
        {
            string t = textField.Text.Trim();
            try
            {
                if (t == null || t.Equals(String.Empty) || t.Equals("0"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static string GetIpHost()
        {
            IPHostEntry ipEntry = Dns.GetHostByName(GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            return addr[0].ToString();
        }

        public static string GetHostName()
        {
            return Dns.GetHostName();
        }
    }
}
