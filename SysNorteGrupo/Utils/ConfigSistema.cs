using System;
using System.Drawing;
using WcfLibGrupo;
namespace SysNorteGrupo.Utils
{
    public class ConfigSistema
    {
        public static decimal valor_por_cota { get; set; }

        public static Color backColorFoco { get; set; }

        public static decimal franquiaSinistro { get; set; }

        public static int minutosIDLE { get; set; }

        public static void carregaConfiguracoes()
        {
            try
            {
                IServiceGrupo conn;                
                conn = GerenteDeConexoes.conexaoServico();
                backColorFoco = conn.backColorFoco();
                franquiaSinistro = conn.franquiaSinistro();
                valor_por_cota = conn.valorPorCota();
                minutosIDLE = Convert.ToInt32(FilesINI.ReadValue("sistema", "IDLE"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

    }
}
