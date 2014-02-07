using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace WcfLibGrupo.Utils
{
    public class LeitorINI
    {
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString,
        int nSize, string lpFileName);

        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        static string iniFile = Path.Combine(Directory.GetCurrentDirectory(), "configServico.sysn");

        public static string getCaminhoArquivoINI(string caminhoArquivo)
        {
            if (caminhoArquivo.IndexOf("\\bin\\Debug") != -1)
            {
                caminhoArquivo = caminhoArquivo.Replace("\\bin\\Debug", "");
            }
            else if (caminhoArquivo.IndexOf("\\bin\\Release") != -1)
            {
                caminhoArquivo = caminhoArquivo.Replace("\\bin\\Release", "");
            }
            return caminhoArquivo;
        }

        public static String ReadValue(string section, string key)
        {
            return GetIniValue(section, key, iniFile);
        }

        public static void WriteValue(string section, string Key, string Value)
        {
            WritePrivateProfileString(section, Key, Value, iniFile);
        }

        public static string GetIniValue(string section, string key, string nomeArquivo)
        {
            const int chars = 256;
            StringBuilder buffer = new StringBuilder(chars);
            const string sDefault = "";
            if (GetPrivateProfileString(section, key, sDefault, buffer, chars, nomeArquivo) != 0)
            {
                return buffer.ToString();
            }
            else
            {
                // Verifica o último erro Win32.
                int err = Marshal.GetLastWin32Error();
                return null;
            }
        }
    }
}
