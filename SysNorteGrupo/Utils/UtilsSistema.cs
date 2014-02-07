using System;
using System.Drawing;
namespace SysNorteGrupo.Utils
{
    public class UtilsSistema
    {
        public static decimal valor_por_cota { get; set; }

        public static Color backColorFoco { get; set; }

        public UtilsSistema()
        {
            valor_por_cota = Convert.ToDecimal(10000.00);
        }
    }
}
