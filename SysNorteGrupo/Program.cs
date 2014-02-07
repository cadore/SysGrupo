using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using SysNorteGrupo.Utils;
using SysNorteGrupo.UI.Usuarios;
using EntitiesGrupo;
using WcfLibGrupo;

namespace SysNorteGrupo
{
    static class Program
    {

        public static usuario usuario_instc = null;
        public static permicoes_usuario permicao_instc = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World

            UtilsSistema uts = new UtilsSistema();
            IServiceGrupo conn = GerenteDeConexoes.iniciaConexao();
            UtilsSistema.backColorFoco = conn.backColorFoco();

            Application.Run(new FormPrincipal(new usuario(), new permicoes_usuario()));
            //startApplication();
        }

        public static void startApplication()
        {
            LoginForm frmLogin = new LoginForm();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormPrincipal(usuario_instc, permicao_instc));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
