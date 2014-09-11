using System.IO;
using System.Windows.Forms;
namespace HostWcfGrupo.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.itemOpen = new System.Windows.Forms.MenuItem();
            this.itemService = new System.Windows.Forms.MenuItem();
            this.itemBackup = new System.Windows.Forms.MenuItem();
            this.itemExit = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.tfStatus = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenu = this.contextMenu;
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.itemOpen_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itemOpen,
            this.itemService,
            this.itemBackup,
            this.itemExit});
            // 
            // itemOpen
            // 
            this.itemOpen.Index = 0;
            this.itemOpen.Text = "Abrir Servidor";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemService
            // 
            this.itemService.Index = 1;
            this.itemService.Text = "Parar Serviço";
            this.itemService.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // itemBackup
            // 
            this.itemBackup.Index = 2;
            this.itemBackup.Text = "Realizar Backup";
            this.itemBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // itemExit
            // 
            this.itemExit.Index = 3;
            this.itemExit.Text = "Sair";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeral);
            this.tabControl1.Controls.Add(this.tabBackup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 235);
            this.tabControl1.TabIndex = 3;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.panelControl1);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(410, 209);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.panelControl1.Controls.Add(this.btnStartStop);
            this.panelControl1.Controls.Add(this.tfStatus);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(404, 203);
            this.panelControl1.TabIndex = 0;
            // 
            // btnStartStop
            // 
            this.btnStartStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStartStop.Location = new System.Drawing.Point(5, 8);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(397, 43);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "Parar Serviço";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // tfStatus
            // 
            this.tfStatus.Location = new System.Drawing.Point(5, 77);
            this.tfStatus.Name = "tfStatus";
            this.tfStatus.ReadOnly = true;
            this.tfStatus.Size = new System.Drawing.Size(392, 119);
            this.tfStatus.TabIndex = 5;
            this.tfStatus.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status:";
            // 
            // tabBackup
            // 
            this.tabBackup.BackColor = System.Drawing.Color.Transparent;
            this.tabBackup.Controls.Add(this.btnBackup);
            this.tabBackup.Location = new System.Drawing.Point(4, 22);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackup.Size = new System.Drawing.Size(410, 209);
            this.tabBackup.TabIndex = 1;
            this.tabBackup.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(8, 6);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(394, 58);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Criar Backup do Banco de Dados";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(318, 237);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(96, 32);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(216, 237);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(96, 32);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.Text = "Minimizar";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(434, 314);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(434, 314);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tabBackup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.Button btnBackup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.RichTextBox tfStatus;
        private System.Windows.Forms.Label label1;

        /* notify icon */
        public NotifyIcon notifyIcon;
        public ContextMenu contextMenu;
        public MenuItem itemOpen, itemExit, itemBackup, itemService;
        private Button btnSair;
        private Button btnMinimizar;
    }
}

