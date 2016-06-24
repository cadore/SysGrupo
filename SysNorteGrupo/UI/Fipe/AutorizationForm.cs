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

namespace SysNorteGrupo.UI.Fipe
{
    public partial class AutorizationForm : DevExpress.XtraEditors.XtraForm
    {
        public string Password { get; private set; }
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            Password = tfPassword.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AutorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnConfirm_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);
        }
    }
}