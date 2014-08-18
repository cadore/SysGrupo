using EntitiesGrupo;
using SecureApp;
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
        public static string enderecoServico;
        public static decimal valor_cota { get; set; }
        public static decimal franquiaSinistro { get; set; }

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

        public static string SUBDIR_FILES_EMPRESA;
        public static string SUBDIR_FILES_CLIENTES;
        public static string SUBDIR_FILES_VEICULOS;
        public static string SUBDIR_FILES_REBOQUES;
        public static string SUBDIR_FILES_SINISTROS;
        public static string SUBDIR_TEMP_FILES;
        public static string SUBDIR_LOG;
        public static string SUBDIR_BACKUP;
        public static string DIR_PG_DUMP;
        #endregion

        public static void carregaConfigurações(){
            SysFile sf = new SysFile();
            valor_cota = Convert.ToDecimal(10000.00);
            franquiaSinistro = Convert.ToDecimal(5);            
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
            enderecoServico = LeitorINI.ReadValue("sistema", "enderecoServico");

            /*SysGrupoRepo.host = new DTICrypto().Decifrar(LeitorINI.ReadValue("dbdata", "host"), "a1s2 d3f4&beguta");
            SysGrupoRepo.port = new DTICrypto().Decifrar(LeitorINI.ReadValue("dbdata", "port"), "a1s2 d3f4&beguta");
            SysGrupoRepo.db = new DTICrypto().Decifrar(LeitorINI.ReadValue("dbdata", "db"), "a1s2 d3f4&beguta");
            SysGrupoRepo.user = new DTICrypto().Decifrar(LeitorINI.ReadValue("dbdata", "user"), "a1s2 d3f4&beguta");
            SysGrupoRepo.passwd = new DTICrypto().Decifrar(LeitorINI.ReadValue("dbdata", "passwd"), "a1s2 d3f4&beguta");*/

            SUBDIR_FILES_EMPRESA = diretorio_raiz_documentos + @"\files\empresa\";
            SUBDIR_FILES_CLIENTES = diretorio_raiz_documentos + @"\files\clientes\";
            SUBDIR_FILES_VEICULOS = diretorio_raiz_documentos + @"\files\veiculos\";
            SUBDIR_FILES_REBOQUES = diretorio_raiz_documentos + @"\files\reboques\";
            SUBDIR_FILES_SINISTROS = diretorio_raiz_documentos + @"\files\sinistros\";
            SUBDIR_LOG = diretorio_raiz_documentos + @"\log\";
            SUBDIR_TEMP_FILES = diretorio_raiz_documentos + @"\temp\";
            SUBDIR_BACKUP = diretorio_raiz_documentos + @"\backup\";
            DIR_PG_DUMP = LeitorINI.ReadValue("diretorios", "diretorio_pg_dump");

            if(!sf.verificaDiretorioExistente(diretorio_raiz_documentos)){
                sf.criaDiretorio(diretorio_raiz_documentos);
                sf.criaDiretorio(SUBDIR_FILES_EMPRESA);
                sf.criaDiretorio(SUBDIR_FILES_CLIENTES);
                sf.criaDiretorio(SUBDIR_FILES_VEICULOS);
                sf.criaDiretorio(SUBDIR_FILES_REBOQUES);
                sf.criaDiretorio(SUBDIR_FILES_SINISTROS);
                sf.criaDiretorio(SUBDIR_TEMP_FILES);
                sf.criaDiretorio(SUBDIR_LOG);
                sf.criaDiretorio(SUBDIR_BACKUP);
            }
        }
    }
}
