using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace SysNorteGrupo.Utils
{
    public class FilesINI
    {
        [DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
        private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString,
        int nSize, string lpFileName);

        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileString")]
        private static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        static string iniFile = Path.Combine(Directory.GetCurrentDirectory(), "config.sysini");

        public static String ReadValue(string session, string key)
        {
            return _GetIniValue(session, key, iniFile);
        }

        public static void WriteValue(string section, string Key, string Value)
        {
            WritePrivateProfileString(section, Key, Value, iniFile);
        }

        private static string _GetIniValue(string section, string key, string nomeArquivo)
        {
            const int chars = 1024;
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
