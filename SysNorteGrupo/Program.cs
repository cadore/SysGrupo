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
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                BonusSkins.Register();
                SkinManager.EnableFormSkins();
                UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World



                // The following line provides localization for data formats. 
                System.Threading.Thread.CurrentThread.CurrentCulture =
                    new System.Globalization.CultureInfo("pt-BR");

                // The following line provides localization for the application's user interface. 
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo("pt-BR");

                GerenteDeConexoes.iniciaConexao();
                IServiceGrupo conn = GerenteDeConexoes.recuperaConexao();

                UtilsSistema.backColorFoco = conn.backColorFoco();
                UtilsSistema.franquiaSinistro = conn.franquiaSinistro();
                UtilsSistema.valor_por_cota = conn.valorPorCota();

                //Application.Run(new FormPrincipal(new usuario(), new permicoes_usuario()));
                startApplication();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void startApplication()
        {
            try
            {
                Log.createLog(EventLog.entered, String.Format("ao sistema, aguardando autenticação"));
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
