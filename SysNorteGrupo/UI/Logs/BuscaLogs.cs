using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using SysNorteGrupo.Utils;
using WcfLibGrupo;
using EntitiesGrupo;

namespace SysNorteGrupo.UI.Logs
{
    public partial class BuscaLogs : DevExpress.XtraEditors.XtraUserControl
    {
        public FormPrincipal dash = null;
        IServiceGrupo conn;
        public BuscaLogs()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            Log.createLog(EventLog.opened, "Formulario de Logs");
            loadItemsCombos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Log.createLog(EventLog.executedSearch, "-");
                bdgLog.DataSource = new Log().readLog(tfParameter.Text, cbEentoLog.Text, cbUsuario.Text);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Log.createLog(EventLog.exited, "Formulario de Logs");
            dash.fechaUtilFormAtual();
        }

        private void loadItemsCombos()
        {
            try
            {
                ComboBoxItemCollection collEventLog = cbEentoLog.Properties.Items;
                collEventLog.BeginUpdate();

                try
                {
                    collEventLog.Add("TODOS");
                    collEventLog.Add("abriu");
                    collEventLog.Add("registrou");
                    collEventLog.Add("editou");
                    collEventLog.Add("salvou edição");
                    collEventLog.Add("executou a pesquisa");
                    collEventLog.Add("visualizou");
                    collEventLog.Add("fechou");
                    collEventLog.Add("saiu");
                    collEventLog.Add("entrou");
                    collEventLog.Add("excluiu");
                    collEventLog.Add("exception");
                    collEventLog.Add("adicionou");
                    collEventLog.Add("baixou");
                    collEventLog.Add("nullo");
                }
                finally
                {
                    collEventLog.EndUpdate();
                }
                cbEentoLog.SelectedIndex = -1;

                ComboBoxItemCollection collUser = cbUsuario.Properties.Items;
                collUser.BeginUpdate();

                try
                {
                    collUser.Add("TODOS");
                    List<usuario> lisUsuario = conn.listaDeTodosUsuarios();
                    foreach (usuario u in lisUsuario)
                    {
                        collUser.Add(u.login);
                    }
                }
                finally
                {
                    collUser.EndUpdate();
                }
                cbEentoLog.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
