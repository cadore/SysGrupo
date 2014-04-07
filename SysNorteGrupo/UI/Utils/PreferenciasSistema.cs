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
    public partial class PreferenciasSistema : DevExpress.XtraEditors.XtraForm
    {
        public PreferenciasSistema()
        {
            InitializeComponent();
            spMinutos.Value = ConfigSistema.minutosIDLE;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            ConfigSistema.minutosIDLE = Convert.ToInt32(spMinutos.Value);
            FilesINI.WriteValue("sistema", "IDLE", spMinutos.Value.ToString());
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}