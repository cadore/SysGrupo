﻿using System;
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
using SysNorteGrupo.UI.Sinistros;
using SysNorteGrupo.UI.Veiculos.Reboques;
using SysNorteGrupo.UI.Logs;

namespace SysNorteGrupo
{
    public partial class FormPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private IServiceGrupo conn;
        UtilForm utilForm;

        public FormPrincipal(usuario usuario_instc, permicoes_usuario permicao_instc)
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
            Log.createLog(EventLog.opened, "formulario de busca de usuario");
        }

        private void btnNovoUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            UsuarioForm usuarioForm = new UsuarioForm(null) { formPrincipal = this };
            adicionarControleNavegacao(usuarioForm);
            Log.createLog(EventLog.opened, "formulario de usuarios");
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
            Log.createLog(EventLog.opened, "formulario de busca de clientes");
        }

        private void btnClienteForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm(null) { formPrincipal = this };
            adicionarControleNavegacao(clienteForm);
            Log.createLog(EventLog.opened, "formulario de clientes");
        }

        private void btnBuscarVeiculo_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaVeiculoForm buscaVeiculoForm = new BuscaVeiculoForm() { formPrincipal = this };
            adicionarControleNavegacao(buscaVeiculoForm);
            Log.createLog(EventLog.opened, "formulario de busca de veiculos");
        }

        private void btnNovoVeiculo_ItemClick(object sender, ItemClickEventArgs e)
        {
            VeiculosForm vf = new VeiculosForm(null) { formPrincipal = this };
            adicionarControleNavegacao(vf);
            Log.createLog(EventLog.opened, "formulario de veiculos");
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArquivosForm af = new ArquivosForm();
            af.conn = conn;
            af.DIRETORIO = conn.SUBDIR_EMPRESA();
            adicionarControleNavegacao(af);
            Log.createLog(EventLog.opened, "formulario de arquivos empresa");
            af.executaBusca();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            SinistrosForm sf = new SinistrosForm(null) { formPrincipal = this};
            adicionarControleNavegacao(sf);
            Log.createLog(EventLog.opened, "formulario de sinistros");
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReboqueForm rf = new ReboqueForm(null) { formPrincipal = this };
            adicionarControleNavegacao(rf);
            Log.createLog(EventLog.opened, "formulario de reboques");
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaSinistrosForm bsf = new BuscaSinistrosForm() { formPrincipal = this};
            adicionarControleNavegacao(bsf);
            Log.createLog(EventLog.opened, "formulario de busca de sinistros");
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaReboqueForm brf = new BuscaReboqueForm() { formPrincipal = this};
            adicionarControleNavegacao(brf);
            Log.createLog(EventLog.opened, "formulario de reboques");
        }

        public void fechaUtilFormAtual()
        {
            if (utilForm != null)
            {
                utilForm.Close();
                Log.createLog(EventLog.cloused, "Formulario de utilidades");
                utilForm = null;
            }
        }

        private void btnLogs_ItemClick(object sender, ItemClickEventArgs e)
        {
            BuscaLogs sl = new BuscaLogs();
            sl.dash = this;
            utilForm = new UtilForm(sl, this);
            utilForm.ShowDialog();
        }

        private void btnCriaBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DateTime inic = DateTime.Now;
                Log.createLog(EventLog.opened, "criação de backup.");
                IServiceGrupo conn = GerenteDeConexoes.iniciaConexao();
                string dir = conn.createBackup("p@ssw0rd");
                if (!String.IsNullOrEmpty(dir))
                {
                    DateTime fim = DateTime.Now;
                    TimeSpan ts = fim.Subtract(inic);
                    Log.createLog(EventLog.cloused, String.Format("concluiu criação de backup em: {0} segundos", ts.TotalSeconds));
                    MessageBox.Show("Backup criado com sucesso!");
                }
            }catch(Exception)
            {
                MessageBox.Show("Erro ao criar backup, tente novamente\nse o problema persistir, contate o suporte.");
            }
        }
    }
}