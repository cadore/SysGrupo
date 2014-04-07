using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using EntitiesGrupo;
using SecureApp;
using SysNorteGrupo.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;
using WcfLibGrupo;
namespace SysNorteGrupo.UI.Usuarios
{
    public partial class UsuarioForm : XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private CustomValidationRuleTamanhoSenha cVRTS;
        private CustomValidationRuleSenhaAtual cVRSA;
        private string status = "save";
        private usuario usr = null;
        private permicoes_usuario pu = null;
        private Color backColor = ConfigSistema.backColorFoco;

        public UsuarioForm(usuario _usr)
        {
            InitializeComponent();
            usr = _usr;
            conn = GerenteDeConexoes.conexaoServico();

            if(usr == null){
                usr = new usuario();
                pu = new permicoes_usuario() { financeiro = false, usuarios = false, relatorios = false, cadastrar_cliente = false, cadastrar_sinistro = false,
                    cadastrar_veiculo = false, inativar_cliente = false, inativar_sinistro = false, inativar_veiculo = false, finalizar_sinistro = false 
                };                
            }
            else
            {
                //carregaPermissoesPorIdUsuario(usr);
                pu = conn.recuperaPermicoesDoUsuarioPorIdUsuario(usr.id);                
                status = "update";
                pnControl.Enabled = false;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
                tfLogin.Properties.ReadOnly = true;
                tfSenhaAtual.Enabled = true;
            }
            bdgUsuarios.DataSource = usr;
            bdgPermicoes.DataSource = pu;
            tfSenhaAtual.Properties.UseSystemPasswordChar = true;
            tfNovaSenha.Properties.UseSystemPasswordChar = true;
            lbAlterarSenha.Visible = false;
        }

        public class CustomValidationRuleTamanhoSenha : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                if (str != null)
                {
                    if (str.Trim().Length >= 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        public class CustomValidationRuleSenhaAtual : ValidationRule, IDisposable
        {
            UsuarioForm form;
            public void Dispose()
            {
                if (form != null)
                {
                    form.Dispose();
                    form = null;
                }
            }
            public CustomValidationRuleSenhaAtual(UsuarioForm _form)
            {
                form = _form;
            }
            public override bool Validate(Control control, object value)
            {
                String str = value as String;
                if (form.usr.senha == null || form.usr.senha == "")
                {
                    return false;
                }

                DTICrypto crypto = new DTICrypto();
                string senha_cad = crypto.Cifrar(str, Util.chaveSecureApp);
                if (senha_cad.Equals(form.usr.senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void setValidationsSenha()
        {
            if (tfNovaSenha.Text.Trim().Length >= 1 || tfSenhaAtual.Text.Trim().Length >= 1)
            {
                if ("update".Equals(status))
                {
                    cVRSA = null;
                    cVRSA = new CustomValidationRuleSenhaAtual(this) { ErrorText = "Senha atual incorreta.", ErrorType = ErrorType.Critical };
                    dxValidationProvider.SetValidationRule(tfSenhaAtual, cVRSA);
                }
                else
                {
                    cVRSA = null;
                    dxValidationProvider.SetValidationRule(tfSenhaAtual, cVRSA);
                }
            }
            else
            {
                cVRSA = null;
                dxValidationProvider.SetValidationRule(tfSenhaAtual, cVRSA);
            }

            if ("save".Equals(status) || tfNovaSenha.Text.Trim().Length >= 1 || tfSenhaAtual.Text.Trim().Length >= 1)
            {
                cVRTS = null;
                cVRTS = new CustomValidationRuleTamanhoSenha() { ErrorText = "Senha deve ter no minimo 4 caracteres.", ErrorType = ErrorType.Critical };
                dxValidationProvider.SetValidationRule(tfNovaSenha, cVRTS);
            }
            else
            {
                cVRTS = null;
                dxValidationProvider.SetValidationRule(tfNovaSenha, cVRTS);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
            Log.createLog(EventLog.exited, String.Format("formulario de usuarios"));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnControl.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            lbAlterarSenha.Visible = true;
            Log.createLog(EventLog.edited, String.Format("usuario ID: {0}", tfId.Text));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            setValidationsSenha();
            if(dxValidationProvider.Validate()){
                try
                {
                    bool empty = Util.textFieldIsEmpty(tfId);

                    if(conn.verificaSeLoginEhUnico(tfLogin.Text, !empty) == false){
                        XtraMessageBox.Show("O LOGIN: "+tfLogin.Text+" JÁ ESTA CADASTRADO. VERIFIQUE!");
                        return;
                    }
                    DTICrypto crypto = new DTICrypto();
                    usuario user = (usuario) bdgUsuarios.Current;
                    permicoes_usuario pup = permicoes();
                    if(!tfNovaSenha.Text.Equals(String.Empty)){
                        user.senha = crypto.Cifrar(tfNovaSenha.Text, Util.chaveSecureApp);
                    }

                    if(empty){
                        user.inativo = false;
                    }
                    long id = conn.salvarUsuario(user, pup);
                    tfId.Text = id.ToString();
                    ((usuario)bdgUsuarios.Current).id = id;
                    Log.createLog(EventLog.saveEdited, String.Format("usuario ID: {0}", tfId.Text));

                    pnControl.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    tfSenhaAtual.Text = null;
                    tfNovaSenha.Text = null;
                    lbAlterarSenha.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n"+ex.Message);
                    formPrincipal.adicionarControleNavegacao(null);
                }
            }
        }
        private void btnSelecionarT_Click(object sender, EventArgs e)
        {
            bdgPermicoes.DataSource = new permicoes_usuario()
            {
                financeiro = true,
                usuarios = true,
                relatorios = true,
                cadastrar_cliente = true,
                cadastrar_sinistro = true,
                cadastrar_veiculo = true,
                inativar_cliente = true,
                inativar_sinistro = true,
                inativar_veiculo = true,
                finalizar_sinistro = true
            };
            //selecionaPermissoes(true);
        }
        private void btnDesmarcarT_Click(object sender, EventArgs e)
        {
            bdgPermicoes.DataSource = new permicoes_usuario()
            {
                financeiro = false,
                usuarios = false,
                relatorios = false,
                cadastrar_cliente = false,
                cadastrar_sinistro = false,
                cadastrar_veiculo = false,
                inativar_cliente = false,
                inativar_sinistro = false,
                inativar_veiculo = false,
                finalizar_sinistro = false
            };
        }
        private permicoes_usuario permicoes()
        {
            permicoes_usuario p = new permicoes_usuario() 
            { 
                id = pu.id,
                financeiro = ckFinanceiro.Checked, 
                usuarios = ckUsuarios.Checked, 
                relatorios = ckRelatorios.Checked, 
                cadastrar_cliente = ckCadCliente.Checked, 
                cadastrar_veiculo = ckCadVeiculo.Checked, 
                cadastrar_sinistro = ckCadSinistro.Checked, 
                inativar_cliente = ckInaCliente.Checked, 
                inativar_veiculo = ckInaVeiculo.Checked, 
                inativar_sinistro = ckInaSinistro.Checked, 
                finalizar_sinistro = ckFinSinistro.Checked 
            };
            return p;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(new UsuarioForm(null) { formPrincipal = formPrincipal});
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            UsuarioForm usr = new UsuarioForm(null) { formPrincipal = this.formPrincipal };
            Log.createLog(EventLog.opened, "novo formulario de usuario");
            formPrincipal.adicionarControleNavegacao(usr);
        }
    }
}
