using System;
using System.Diagnostics;
namespace HostWcfGrupo.Utils
{
    public class Util
    {
        public static int execProcess(string exec, string workingDirectory, bool window)
        {
            using (Process process = new Process())
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                if (window)
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                else
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;                
                if (!String.IsNullOrEmpty(workingDirectory))
                    startInfo.WorkingDirectory = workingDirectory;
                if (!String.IsNullOrEmpty(exec))
                    startInfo.Arguments = exec;
                startInfo.FileName = "powershell.exe";
                startInfo.UseShellExecute = true;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                return process.ExitCode;
            }
        }
    }
}
