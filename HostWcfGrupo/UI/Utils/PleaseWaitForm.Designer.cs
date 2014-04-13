namespace HostWcfGrupo.UI.Utils
{
    partial class PleaseWaitForm
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
            this.panelProgesso = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProgesso
            // 
            this.panelProgesso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelProgesso.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelProgesso.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            panelProgesso.Appearance.Options.UseBackColor = true;
            this.panelProgesso.Appearance.Options.UseFont = true;
            this.panelProgesso.Appearance.Options.UseForeColor = true;
            this.panelProgesso.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelProgesso.AppearanceCaption.Options.UseFont = true;
            this.panelProgesso.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelProgesso.AppearanceDescription.Options.UseFont = true;
            this.panelProgesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelProgesso.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelProgesso.Caption = "Por favor, aguarde.";
            this.panelProgesso.Description = "Carregando...";
            this.panelProgesso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProgesso.ImageHorzOffset = 20;
            this.panelProgesso.Location = new System.Drawing.Point(0, 17);
            this.panelProgesso.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.panelProgesso.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelProgesso.LookAndFeel.UseWindowsXPTheme = true;
            this.panelProgesso.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelProgesso.Name = "panelProgesso";
            this.panelProgesso.Size = new System.Drawing.Size(264, 52);
            this.panelProgesso.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelProgesso, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 86);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PleaseWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(264, 86);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "PleaseWaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DevExpress.XtraWaitForm.ProgressPanel panelProgesso;
    }
}
