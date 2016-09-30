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
using WcfLibGrupo;
using WcfLibGrupo.Utils;

namespace SysNorteGrupo.UI
{
    public partial class ConfigBackupForm : DevExpress.XtraEditors.XtraForm
    {
        IServiceGrupo conn;
        public ConfigBackupForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            tfDirBackup.EditValue = LeitorINI.ReadValue("diretorios", "diretorio2_backup2");
            tfDirPgDump.EditValue = conn.DIR_PG_DUMP();
        }

        private void btnDirBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Escolha o diretório para Backup";
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                LeitorINI.WriteValue("diretorios", "diretorio2_backup2", fbd.SelectedPath);
                tfDirBackup.EditValue = LeitorINI.ReadValue("diretorios", "diretorio2_backup2");
            }
        }

        private void botaoSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}