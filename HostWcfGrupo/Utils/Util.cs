using System;
using System.Diagnostics;
namespace HostWcfGrupo.Utils
{
    public class Util
    {
        public static void executeProcess(string exec, string workingDirectory, bool window)
        {
            using (Process process = new Process())
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                if (window)
                {
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                }
                else
                {
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                }
                startInfo.FileName = "powershell.exe";
                startInfo.UseShellExecute = true;
                if (!String.IsNullOrEmpty(workingDirectory))
                {
                    startInfo.WorkingDirectory = workingDirectory;
                }
                startInfo.Arguments = exec;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
