using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfLibGrupo.Utils;

namespace HostWcfGrupo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int i = 0;
            if(args.Length != 0){
                if (args[0].Equals("local"))
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
            }
            UtilsSistemaServico.carregaConfigurações();
            Application.Run(new Form1(i));
        }
    }
}
