using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using HostWcfGrupo.UI;
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
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

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
