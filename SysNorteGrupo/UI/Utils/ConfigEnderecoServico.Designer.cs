namespace SysNorteGrupo.UI.Utils
{
    partial class ConfigEnderecoServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEnderecoServico));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.ckConectarSaida = new DevExpress.XtraEditors.CheckEdit();
            this.tfPorta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfIP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckConectarSaida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPorta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfIP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnAplicar);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.ckConectarSaida);
            this.panelControl1.Controls.Add(this.tfPorta);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tfIP);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(361, 128);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnAplicar.Image")));
            this.btnAplicar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAplicar.Location = new System.Drawing.Point(139, 78);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(104, 41);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "APLICAR";
            this.btnAplicar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(249, 78);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckConectarSaida
            // 
            this.ckConectarSaida.EditValue = true;
            this.ckConectarSaida.Location = new System.Drawing.Point(170, 39);
            this.ckConectarSaida.Name = "ckConectarSaida";
            this.ckConectarSaida.Properties.Caption = "TENTAR CONECTAR NA SAIDA?";
            this.ckConectarSaida.Size = new System.Drawing.Size(183, 19);
            this.ckConectarSaida.TabIndex = 2;
            // 
            // tfPorta
            // 
            this.tfPorta.Location = new System.Drawing.Point(90, 38);
            this.tfPorta.Name = "tfPorta";
            this.tfPorta.Properties.Mask.BeepOnError = true;
            this.tfPorta.Properties.Mask.EditMask = "\\d{4}";
            this.tfPorta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfPorta.Size = new System.Drawing.Size(74, 20);
            this.tfPorta.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "PORTA:";
            // 
            // tfIP
            // 
            this.tfIP.EditValue = "";
            this.tfIP.Location = new System.Drawing.Point(90, 12);
            this.tfIP.Name = "tfIP";
            this.tfIP.Properties.Mask.EditMask = "localhost|(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9" +
    "][0-9]?)){3}";
            this.tfIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfIP.Size = new System.Drawing.Size(263, 20);
            this.tfIP.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ENDEREÇO/IP:";
            // 
            // ConfigEnderecoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 128);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigEnderecoServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração de Endereço do Servidor";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckConectarSaida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPorta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfIP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfIP;
        private DevExpress.XtraEditors.TextEdit tfPorta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.CheckEdit ckConectarSaida;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
    }
}