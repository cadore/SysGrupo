using ServicosSysFileManager;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace WcfLibGrupo.Utils
{
    public static class UtilsSistemaServico
    {
        #region sistema

        public static Color backColorFoco;

        #endregion

        #region email

        public static string smtpServer;
        public static bool ssl;
        public static int porta;
        public static string usuario;
        public static string senha;
        public static string email_de;
        public static string nome_email;

        #endregion

        #region diretorios
        public static string diretorio_raiz_documentos;

        public static string SUBDIR_EMPRESA;
        public static string SUBDIR_CLIENTES;
        public static string SUBDIR_VEICULOS;
        public static string SUBDIR_REBOQUES;
        public static string SUBDIR_SINISTROS;            
        #endregion


        public static void carregaConfigurações(){
            SysFile sf = new SysFile();
            diretorio_raiz_documentos = LeitorINI.ReadValue("diretorios", "diretorio_raiz_documentos");
            smtpServer = LeitorINI.ReadValue("email", "smtpServer");
            ssl = Convert.ToBoolean(LeitorINI.ReadValue("email", "ssl"));
            porta = Convert.ToInt32(LeitorINI.ReadValue("email", "porta"));
            usuario = LeitorINI.ReadValue("email", "usuario");
            senha = LeitorINI.ReadValue("email", "senha");
            email_de = LeitorINI.ReadValue("email", "email_de");
            nome_email = LeitorINI.ReadValue("email", "nome_email");
            backColorFoco = Color.FromArgb(Convert.ToInt32(LeitorINI.ReadValue("backColorFoco", "backColorFocoR")),
                Convert.ToInt32(LeitorINI.ReadValue("backColorFoco", "backColorFocoG")),
                Convert.ToInt32(LeitorINI.ReadValue("backColorFoco", "backColorFocoB")));

            SUBDIR_EMPRESA = diretorio_raiz_documentos + @"\empresa\";
            SUBDIR_CLIENTES = diretorio_raiz_documentos + @"\clientes\";
            SUBDIR_VEICULOS = diretorio_raiz_documentos + @"\veiculos\";
            SUBDIR_REBOQUES = diretorio_raiz_documentos + @"\reboques\";
            SUBDIR_SINISTROS = diretorio_raiz_documentos + @"\sinistros\";

            if(!sf.verificaDiretorioExistente(diretorio_raiz_documentos)){
                sf.criaDiretorio(diretorio_raiz_documentos);
                sf.criaDiretorio(SUBDIR_EMPRESA);
                sf.criaDiretorio(SUBDIR_CLIENTES);
                sf.criaDiretorio(SUBDIR_VEICULOS);
                sf.criaDiretorio(SUBDIR_REBOQUES);
                sf.criaDiretorio(SUBDIR_SINISTROS);
            }
        }
    }
}
