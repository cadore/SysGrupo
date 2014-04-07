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
using SysNorteGrupo.UI.Utils;

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
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

                // The following line provides localization for the application's user interface. 
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");

                iniciaConexao();

                try
                {
                    ConfigSistema.carregaConfiguracoes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Ocorreu um erro no carregamento das configurações.\n\n{0}\n{1}", ex.Message, ex.InnerException));
                    Environment.Exit(0);
                }                
               
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
                    Log.usuario_ativo = usuario_instc;
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

        static void iniciaConexao()
        {
            try
            {
                GerenteDeConexoes.iniciaConexaoServico();
            }
            catch (Exception)
            {
                DialogResult rs = MessageBox.Show("Não foi possível conectar ao servidor.\nInforme o endereço e a porta para conectar!",
                    "SYSNORTE TECNOLOGIA", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    ConfigEnderecoServico ces = new ConfigEnderecoServico();
                    ces.ckConectarSaida.Enabled = false;
                    DialogResult dr = ces.ShowDialog();
                    if (dr == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
