namespace SysNorteGrupo.UI
{
    partial class ConfigBackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigBackupForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfDirBackup = new DevExpress.XtraEditors.TextEdit();
            this.tfDirPgDump = new DevExpress.XtraEditors.TextEdit();
            this.btnDirBackup = new DevExpress.XtraEditors.SimpleButton();
            this.botaoSair1 = new SysNorteGrupo.UI.Utils.Botoes.BotaoSair();
            ((System.ComponentModel.ISupportInitialize)(this.tfDirBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDirPgDump.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Diretorio de Backup:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Diretorio \'bin\' PostgreSQL:";
            // 
            // tfDirBackup
            // 
            this.tfDirBackup.Location = new System.Drawing.Point(12, 31);
            this.tfDirBackup.Name = "tfDirBackup";
            this.tfDirBackup.Properties.ReadOnly = true;
            this.tfDirBackup.Size = new System.Drawing.Size(329, 20);
            this.tfDirBackup.TabIndex = 1;
            // 
            // tfDirPgDump
            // 
            this.tfDirPgDump.Location = new System.Drawing.Point(12, 86);
            this.tfDirPgDump.Name = "tfDirPgDump";
            this.tfDirPgDump.Properties.ReadOnly = true;
            this.tfDirPgDump.Size = new System.Drawing.Size(329, 20);
            this.tfDirPgDump.TabIndex = 1;
            // 
            // btnDirBackup
            // 
            this.btnDirBackup.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDirBackup.Location = new System.Drawing.Point(347, 29);
            this.btnDirBackup.Name = "btnDirBackup";
            this.btnDirBackup.Size = new System.Drawing.Size(75, 23);
            this.btnDirBackup.TabIndex = 2;
            this.btnDirBackup.Text = "Escolher";
            this.btnDirBackup.Click += new System.EventHandler(this.btnDirBackup_Click);
            // 
            // botaoSair1
            // 
            this.botaoSair1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.botaoSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSair1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.botaoSair1.ForeColor = System.Drawing.Color.White;
            this.botaoSair1.Image = ((System.Drawing.Image)(resources.GetObject("botaoSair1.Image")));
            this.botaoSair1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSair1.Location = new System.Drawing.Point(347, 130);
            this.botaoSair1.Name = "botaoSair1";
            this.botaoSair1.Size = new System.Drawing.Size(113, 44);
            this.botaoSair1.TabIndex = 3;
            this.botaoSair1.Text = "Sair";
            this.botaoSair1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSair1.UseVisualStyleBackColor = false;
            this.botaoSair1.Click += new System.EventHandler(this.botaoSair1_Click);
            // 
            // ConfigBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 186);
            this.ControlBox = false;
            this.Controls.Add(this.botaoSair1);
            this.Controls.Add(this.btnDirBackup);
            this.Controls.Add(this.tfDirPgDump);
            this.Controls.Add(this.tfDirBackup);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "ConfigBackupForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações de Backup";
            ((System.ComponentModel.ISupportInitialize)(this.tfDirBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDirPgDump.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfDirBackup;
        private DevExpress.XtraEditors.TextEdit tfDirPgDump;
        private DevExpress.XtraEditors.SimpleButton btnDirBackup;
        private Utils.Botoes.BotaoSair botaoSair1;
    }
}