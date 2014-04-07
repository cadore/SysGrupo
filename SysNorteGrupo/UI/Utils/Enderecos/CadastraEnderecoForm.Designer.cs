namespace SysNorteGrupo.UI.Utils.Enderecos
{
    partial class CadastraEnderecoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraEnderecoForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControls = new DevExpress.XtraEditors.GroupControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tfCep = new DevExpress.XtraEditors.TextEdit();
            this.bdgEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.tfEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbBairro = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControls)).BeginInit();
            this.groupControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControls
            // 
            this.groupControls.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControls.Controls.Add(this.btnSalvar);
            this.groupControls.Controls.Add(this.btnCancelar);
            this.groupControls.Controls.Add(this.tfCep);
            this.groupControls.Controls.Add(this.tfEndereco);
            this.groupControls.Controls.Add(this.labelControl3);
            this.groupControls.Controls.Add(this.lbBairro);
            this.groupControls.Controls.Add(this.labelControl2);
            this.groupControls.Controls.Add(this.labelControl1);
            this.groupControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControls.Location = new System.Drawing.Point(0, 0);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new System.Drawing.Size(520, 160);
            this.groupControls.TabIndex = 0;
            this.groupControls.Text = "CADASTRO DE NOVO ENDEREÇO";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(299, 114);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 41);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(409, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tfCep
            // 
            this.tfCep.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEndereco, "cep", true));
            this.tfCep.Location = new System.Drawing.Point(69, 78);
            this.tfCep.Name = "tfCep";
            this.tfCep.Properties.Mask.BeepOnError = true;
            this.tfCep.Properties.Mask.EditMask = "00.000-000";
            this.tfCep.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfCep.Size = new System.Drawing.Size(444, 20);
            this.tfCep.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o cep do endereço.";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.validator.SetValidationRule(this.tfCep, conditionValidationRule3);
            // 
            // bdgEndereco
            // 
            this.bdgEndereco.DataSource = typeof(EntitiesGrupo.endereco);
            // 
            // tfEndereco
            // 
            this.tfEndereco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgEndereco, "_endereco", true));
            this.tfEndereco.Location = new System.Drawing.Point(69, 52);
            this.tfEndereco.Name = "tfEndereco";
            this.tfEndereco.Size = new System.Drawing.Size(444, 20);
            this.tfEndereco.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o endereço.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.validator.SetValidationRule(this.tfEndereco, conditionValidationRule1);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "CEP:";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbBairro.Location = new System.Drawing.Point(54, 25);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(36, 13);
            this.lbBairro.TabIndex = 0;
            this.lbBairro.Text = "lbBairro";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "ENDEREÇO:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "BAIRRO:";
            // 
            // CadastraEnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 160);
            this.ControlBox = false;
            this.Controls.Add(this.groupControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraEnderecoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadastraEnderecoForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastraEnderecoForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControls)).EndInit();
            this.groupControls.ResumeLayout(false);
            this.groupControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControls;
        private DevExpress.XtraEditors.TextEdit tfEndereco;
        private DevExpress.XtraEditors.LabelControl lbBairro;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit tfCep;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.BindingSource bdgEndereco;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}