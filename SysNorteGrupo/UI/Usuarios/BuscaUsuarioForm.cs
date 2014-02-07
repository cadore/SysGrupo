using DevExpress.XtraEditors;
using EntitiesGrupo;
using SysNorteGrupo.UI.Usuarios;
using SysNorteGrupo.Utils;
using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;
using WcfLibGrupo;

namespace SysNorteGrupo.UI.Usuarios
{
    public partial class BuscaUsuariosForm : XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private int tipoPesquisa = -1;
        private Color backColor = UtilsSistema.backColorFoco;

        public BuscaUsuariosForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.iniciaConexao();
        }

        private void executaBusca()
        {
            if (tipoPesquisa == 0)
            {
                bindingSource.DataSource = conn.listaDeUsuariosAtivosPorId(Convert.ToInt64(tfId.Text));
            }
            else if (tipoPesquisa == 1)
            {
                bindingSource.DataSource = conn.listaDeUsuariosAtivosPorNomeOuLogin(tfNomeLogin.Text);
            }
            else
            {
                bindingSource.DataSource = conn.listaDeUsuariosAtivos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            executaBusca();
        }

        private void verificaTipoPesquisa(TextEdit t, int _tipoPesquisa)
        {
            string valor = t.Text;
            if(!valor.Equals(String.Empty)){
                tipoPesquisa = _tipoPesquisa;
            }
            else
            {
                tipoPesquisa = -1;
            }
        }

        private void carregaUsuarioNoForm(usuario u)
        {
            UsuarioForm usuarioForm = new UsuarioForm(u) { formPrincipal = formPrincipal };
            formPrincipal.adicionarControleNavegacao(usuarioForm);
        }

        private void tfNomeLogin_KeyUp(object sender, KeyEventArgs e)
        {
            tfId.Text = "";
            verificaTipoPesquisa(tfNomeLogin, 1);
        }

        private void tfId_KeyUp(object sender, KeyEventArgs e)
        {
            tfNomeLogin.Text = "";
            verificaTipoPesquisa(tfId, 0);
        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            usuario u = new usuario();
            u = (usuario)bindingSource.Current;
            carregaUsuarioNoForm(u);
        }
        
        private void gridControl_DoubleClick(object sender, MouseEventArgs e)
        {
            usuario u = new usuario();
            u = (usuario)bindingSource.Current;
            carregaUsuarioNoForm(u);
        }

        private void tfId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                executaBusca();
            }
        }

        private void tfNomeLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                executaBusca();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
        }
    }
}
