namespace SysNorteGrupo.UI.Utils.Enderecos
{
    partial class CadastraBairroForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraBairroForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tfNomeBairro = new DevExpress.XtraEditors.TextEdit();
            this.lbNomeCidade = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.bdgBairro = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfNomeBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl
            // 
            this.groupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl.Appearance.ForeColor = System.Drawing.Color.Black;
            this.groupControl.Appearance.Options.UseBackColor = true;
            this.groupControl.Appearance.Options.UseForeColor = true;
            this.groupControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl.Controls.Add(this.btnSalvar);
            this.groupControl.Controls.Add(this.btnCancelar);
            this.groupControl.Controls.Add(this.tfNomeBairro);
            this.groupControl.Controls.Add(this.lbNomeCidade);
            this.groupControl.Controls.Add(this.labelControl3);
            this.groupControl.Controls.Add(this.labelControl1);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(426, 147);
            this.groupControl.TabIndex = 0;
            this.groupControl.Text = "CADASTRO DE NOVO BAIRRO";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(205, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 41);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(315, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tfNomeBairro
            // 
            this.tfNomeBairro.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgBairro, "nome_bairro", true));
            this.tfNomeBairro.Location = new System.Drawing.Point(54, 54);
            this.tfNomeBairro.Name = "tfNomeBairro";
            this.tfNomeBairro.Size = new System.Drawing.Size(365, 20);
            this.tfNomeBairro.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o bairro.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.validator.SetValidationRule(this.tfNomeBairro, conditionValidationRule1);
            // 
            // lbNomeCidade
            // 
            this.lbNomeCidade.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbNomeCidade.Location = new System.Drawing.Point(53, 24);
            this.lbNomeCidade.Name = "lbNomeCidade";
            this.lbNomeCidade.Size = new System.Drawing.Size(68, 13);
            this.lbNomeCidade.TabIndex = 0;
            this.lbNomeCidade.Text = "lbNomeCidade";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "BAIRRO:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CIDADE:";
            // 
            // bdgBairro
            // 
            this.bdgBairro.DataSource = typeof(EntitiesGrupo.bairro);
            // 
            // CadastraBairroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 147);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastraBairroForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastraBairroForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfNomeBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl;
        private System.Windows.Forms.BindingSource bdgBairro;
        private DevExpress.XtraEditors.LabelControl lbNomeCidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfNomeBairro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
    }
}
