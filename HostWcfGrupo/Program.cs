using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using HostWcfGrupo.UI;
using HostWcfGrupo.UI.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");

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
            SplashScreenManager.ShowForm(typeof(SplashForm));
            System.Diagnostics.Process[] processosByName = System.Diagnostics.Process.GetProcessesByName("HostWcfGrupo");
            int ip = 0;
            foreach (System.Diagnostics.Process p in processosByName)
            {
                ip++;
            }
            if (ip <= 1)
            {
                UtilsSistemaServico.carregaConfigurações();
                new Form1(i);
                SplashScreenManager.CloseForm();
                Application.Run();
            }
        }
    }
}
