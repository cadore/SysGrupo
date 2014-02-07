using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SysNorteGrupo.Utils;
using System.IO;
using SysNorteGrupo.UI.Usuarios;
using SysNorteGrupo.UI.Clientes;
using SysNorteGrupo.UI.Veiculos;
using EntitiesGrupo;
using WcfLibGrupo;
using SysFileManager;

namespace SysNorteGrupo
{
    public partial class FormPricipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IServiceGrupo conn;

        public FormPricipal(usuario usuario_instc, permicoes_usuario permicao_instc)
        {
            if (usuario_instc == null)
            {
                Program.startApplication();
                this.Close();                
            }
            InitializeComponent();
            conn = GerenteDeConexoes.iniciaConexao();
            //carregaPermissoes(permicao_instc);
            this.Text = "SysNorteGrupo - SysNorte Tecnologia Copyright ©  2013 Versão: 1.0.0.0";            
        }
        
        private void loadImageBackground()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\images\\backgroundSystem.png";
                pnControl.ContentImage = Image.FromFile(path);

            }catch(Exception ex){
                MessageBox.Show(String.Format("{0}\n{1}", ex.Message, ex.InnerException));
            }
            
        }

        void carregaPermissoes(permicoes_usuario p)
        {            
            btnNovoCliente.Enabled = p.cadastrar_cliente;
            btnNovoVeiculo.Enabled = p.cadastrar_veiculo;
            ribUsuarios.Enabled = p.usuarios;
        }

        public void adicionarControleNavegacao(UserControl controle)
        {
            this.pnControl.Controls.Clear();
            if(controle != null){
                this.pnControl.Controls.Add(controle);
                this.MinimumSize = controle.Size + new Size(0, ribbon.Height) + new Size(20, 35);
            }            
        }

        private void btnBuscarUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaUsuariosForm frm = new BuscaUsuariosForm() { formPrincipal = this };
            adicionarControleNavegacao(frm);
        }

        private void btnNovoUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm(null) { formPrincipal = this };
            adicionarControleNavegacao(usuarioForm);
        } 

        private void pnControl_ControlAdded(object sender, ControlEventArgs e)
        {
            Centraliza.centralizaControlsPainel(pnControl);            
        }

        private void FormPricipal_SizeChanged(object sender, EventArgs e)
        {
            Centraliza.centralizaControlsPainel(pnControl);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pnControl.Controls.Clear();
        }

        private void btnBuscarCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaClienteForm buscaClienteForm = new BuscaClienteForm() { formPrincipal = this };
            adicionarControleNavegacao(buscaClienteForm);
        }

        private void btnClienteForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(null) { formPrincipal = this };
            adicionarControleNavegacao(clienteForm);
        }

        private void btnBuscarVeiculo_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaVeiculoForm buscaClienteForm = new BuscaVeiculoForm() { formPrincipal = this };
            adicionarControleNavegacao(buscaClienteForm);
        }

        private void btnNovoVeiculo_ItemClick(object sender, ItemClickEventArgs e)
        {
            VeiculosForm vf = new VeiculosForm(null) { formPrincipal = this };
            adicionarControleNavegacao(vf);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArquivosForm af = new ArquivosForm();
            af.conn = conn;
            af.DIRETORIO = conn.SUBDIR_EMPRESA();
            adicionarControleNavegacao(af);
            af.executaBusca();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }         
    }
}