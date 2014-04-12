using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;

namespace SysNorteGrupo.Utils
{
    public class Centraliza
    {
        private static Point centralizaUserControl(PanelControl p, Control u)
        {
            Point point = new Point((p.ClientSize.Width - u.Width) / 2, (p.ClientSize.Height - u.Height) / 2);
            return point;
        }

        public static void centralizaControlsPainel(PanelControl p)
        {
            foreach (Control cp in p.Controls)
            {
                cp.Location = centralizaUserControl(p, cp);
            }
        }
    }
}
