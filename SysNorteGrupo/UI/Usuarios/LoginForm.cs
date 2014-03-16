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
using System.Threading;
using EntitiesGrupo;
using SysNorteGrupo.Utils;
using SecureApp;

namespace SysNorteGrupo.UI.Usuarios
{
    public partial class LoginForm : Form
    {

        private IServiceGrupo conn = null;
        private Color backColor = UtilsSistema.backColorFoco;

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "SysNorteGrupo Login - SysNorte Tecnologia Copyright ©  2013 Versão: 1.0.0.0";
            tfSenha.Properties.UseSystemPasswordChar = true;
            conn = GerenteDeConexoes.iniciaConexao();

            foreach (Control c in pnControl.Controls)
            {
                preencheFundoControls(c);
            }

            lbSenha.Visible = false;

            /*tfLogin.Text = "admin";
            tfSenha.Text = "admin";*/
        }

        void executaLogin()
        {
            DTICrypto crypto = new DTICrypto();
            string senha = crypto.Cifrar(tfSenha.Text, Util.chaveSecureApp);
            string login = tfLogin.Text;
            lbSenha.Visible = false;
            if (validator.Validate())
            {
                try
                {
                    bool flag = conn.verificaUsuarioAtivoPorLoginESenha(login, senha);                    
                    if (flag)
                    {
                        usuario usuario_instc = conn.recuperaUsuarioPorLoginEhSenha(login, senha);
                        permicoes_usuario permicoes_instc = conn.recuperaPermicoesDoUsuarioPorIdUsuario(usuario_instc.id);
                        Program.usuario_instc = usuario_instc;
                        Program.permicao_instc = permicoes_instc;

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        Program.usuario_instc = null;
                        Program.permicao_instc = null;
                        lbSenha.Visible = true;
                        tfSenha.Focus();
                        tfSenha.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        void preencheFundoControls(Control item)
        {
            switch (item.GetType().ToString())
            {
                case "DevExpress.XtraEditors.TextEdit": ((TextEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.SearchLookUpEdit": ((SearchLookUpEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.RadioGroup": ((RadioGroup)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.CheckEdit": ((CheckEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {            
                executaLogin();
        }
        
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                executaLogin();

            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }
    }
}