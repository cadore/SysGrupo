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
using WcfLibGrupo;
using EntitiesGrupo;
using DevExpress.XtraSplashScreen;
using SysNorteGrupo.UI.Utils;

namespace SysNorteGrupo.UI.Financeiro
{
    public partial class GerarContasAReceberForm : DevExpress.XtraEditors.XtraUserControl
    {
        public FormPrincipal desk = null;
        IServiceGrupo conn;
        public GerarContasAReceberForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            carregaListaClientes();
        }

        void carregaListaClientes()
        {
            List<cliente> listaC = conn.listaDeTodosClientes();
            MessageBox.Show(listaC.Count.ToString());
            foreach (cliente c in listaC)
            {
                checkListClientes.Items.Add(c.id, c.nome_completo, CheckState.Checked, true);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            desk.adicionarControleNavegacao(null);
        }

        private void checkListClientes_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (checkListClientes.Items.GetCheckedValues().Count > 0)
            {
                btnGerarContas.Enabled = true;
            }
            else
            {
                btnGerarContas.Enabled = false;
            }
        }

        private void btnGerarContas_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(PleaseWaitForm), false, false);
            List<cliente> listaCli = new List<cliente>();
            for (int i = 0; i < checkListClientes.Items.Count; i++)
            {
                if (checkListClientes.Items[i].CheckState == CheckState.Checked)
                    listaCli.Add(conn.retornaClientePorId(Convert.ToInt64(checkListClientes.Items[i].Value)));
            }
            foreach (cliente c in listaCli)
            {

            }
            SplashScreenManager.CloseForm(false);
        }
    }
}
