using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.UI.Utils
{
    public partial class UtilForm : DevExpress.XtraEditors.XtraForm
    {
        private FormPrincipal dash = null;
        public UtilForm(Control c, FormPrincipal _dash)
        {
            InitializeComponent();
            this.dash = _dash;
            panel.Controls.Add(c);
            Log.createLog(SysEventLog.opened, "Formulario de utilidades");
        }

        private void panel_ControlAdded(object sender, ControlEventArgs e)
        {
            foreach (Control con in panel.Controls)
            {
                this.Size = con.Size + new Size(20, 35);
            }
            Centraliza.centralizaControlsPainel(panel);
        }
        private void CloseForm()
        {
            this.Dispose();
            this.Close();
        }

        private void UtilForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}