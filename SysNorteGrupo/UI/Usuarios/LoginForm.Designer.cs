using SysNorteGrupo.UI.Botoes;
namespace SysNorteGrupo.UI.Usuarios
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tfLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.lbAviso = new DevExpress.XtraEditors.LabelControl();
            this.btnEntrar = new BotaoEntrar();
            this.lbSenha = new DevExpress.XtraEditors.LabelControl();
            this.btnSair = new BotaoSair();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tfLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // tfLogin
            // 
            this.tfLogin.Location = new System.Drawing.Point(139, 31);
            this.tfLogin.Name = "tfLogin";
            this.tfLogin.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.tfLogin.Properties.Appearance.Options.UseBackColor = true;
            this.tfLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tfLogin.Size = new System.Drawing.Size(278, 20);
            this.tfLogin.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o Login ou E-Mail para logar-se.";
            this.validator.SetValidationRule(this.tfLogin, conditionValidationRule1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(90, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "LOGIN";
            // 
            // tfSenha
            // 
            this.tfSenha.Location = new System.Drawing.Point(139, 63);
            this.tfSenha.Name = "tfSenha";
            this.tfSenha.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.tfSenha.Properties.Appearance.Options.UseBackColor = true;
            this.tfSenha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tfSenha.Size = new System.Drawing.Size(278, 20);
            this.tfSenha.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a senha para logar-se.";
            this.validator.SetValidationRule(this.tfSenha, conditionValidationRule2);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(85, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "SENHA";
            // 
            // pnControl
            // 
            this.pnControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(155)))));
            this.pnControl.Appearance.Options.UseBackColor = true;
            this.pnControl.AutoSize = true;
            this.pnControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnControl.ContentImage = global::SysNorteGrupo.Properties.Resources.sigla_SysNorte;
            this.pnControl.Controls.Add(this.lbAviso);
            this.pnControl.Controls.Add(this.btnEntrar);
            this.pnControl.Controls.Add(this.lbSenha);
            this.pnControl.Controls.Add(this.btnSair);
            this.pnControl.Controls.Add(this.tfLogin);
            this.pnControl.Controls.Add(this.labelControl2);
            this.pnControl.Controls.Add(this.labelControl1);
            this.pnControl.Controls.Add(this.tfSenha);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(523, 239);
            this.pnControl.TabIndex = 2;
            // 
            // lbAviso
            // 
            this.lbAviso.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.lbAviso.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbAviso.Location = new System.Drawing.Point(12, 109);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(499, 39);
            this.lbAviso.TabIndex = 6;
            this.lbAviso.Text = "SISTEMA BLOQUEADO POR QUESTÕES DE SEGURANÇA, VOCÊ ESTEVE AUSENTE POR MUITO TEMPO." +
    "\r\nINFORME SUAS CREDENCIAIS PARA EFETUAR LOGIN NOVAMENTE.";
            this.lbAviso.Visible = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(12, 166);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(173, 61);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbSenha.Location = new System.Drawing.Point(193, 94);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(154, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "LOGIN OU SENHA INCORRETOS";
            this.lbSenha.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(338, 166);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(173, 61);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 239);
            this.ControlBox = false;
            this.Controls.Add(this.pnControl);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 278);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(539, 278);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tfLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.pnControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tfLogin;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfSenha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private BotaoSair btnSair;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.LabelControl lbSenha;
        private BotaoEntrar btnEntrar;
        public DevExpress.XtraEditors.LabelControl lbAviso;
    }
}