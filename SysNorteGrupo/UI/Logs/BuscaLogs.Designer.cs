using EntitiesGrupo;
using SysNorteGrupo.UI.Botoes;

namespace SysNorteGrupo.UI.Logs
{
    partial class BuscaLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaLogs));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bdgLog = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coleventLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbUsuario = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbEentoLog = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfParameter = new DevExpress.XtraEditors.TextEdit();
            this.bntBuscar = new BotaoBuscar();
            this.btnSair = new BotaoSair();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEentoLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfParameter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bdgLog;
            this.gridControl.Location = new System.Drawing.Point(0, 69);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(993, 504);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdgLog
            // 
            this.bdgLog.DataSource = typeof(EntitiesGrupo.log);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coleventLog,
            this.colmessage,
            this.coluser,
            this.coldateTime,
            this.colhost});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // coleventLog
            // 
            this.coleventLog.Caption = "Evento";
            this.coleventLog.FieldName = "eventLog";
            this.coleventLog.Name = "coleventLog";
            this.coleventLog.OptionsColumn.AllowEdit = false;
            this.coleventLog.Visible = true;
            this.coleventLog.VisibleIndex = 3;
            this.coleventLog.Width = 150;
            // 
            // colmessage
            // 
            this.colmessage.Caption = "Mensagem Final";
            this.colmessage.FieldName = "message";
            this.colmessage.Name = "colmessage";
            this.colmessage.OptionsColumn.AllowEdit = false;
            this.colmessage.Visible = true;
            this.colmessage.VisibleIndex = 4;
            this.colmessage.Width = 425;
            // 
            // coluser
            // 
            this.coluser.Caption = "Usuário";
            this.coluser.FieldName = "user";
            this.coluser.Name = "coluser";
            this.coluser.OptionsColumn.AllowEdit = false;
            this.coluser.Visible = true;
            this.coluser.VisibleIndex = 1;
            this.coluser.Width = 113;
            // 
            // coldateTime
            // 
            this.coldateTime.Caption = "Data/Hora";
            this.coldateTime.FieldName = "dateTime";
            this.coldateTime.Name = "coldateTime";
            this.coldateTime.OptionsColumn.AllowEdit = false;
            this.coldateTime.Visible = true;
            this.coldateTime.VisibleIndex = 0;
            this.coldateTime.Width = 116;
            // 
            // colhost
            // 
            this.colhost.Caption = "Host";
            this.colhost.FieldName = "host";
            this.colhost.Name = "colhost";
            this.colhost.OptionsColumn.AllowEdit = false;
            this.colhost.Visible = true;
            this.colhost.VisibleIndex = 2;
            this.colhost.Width = 171;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(155)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnSair);
            this.panelControl1.Controls.Add(this.bntBuscar);
            this.panelControl1.Controls.Add(this.cbUsuario);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cbEentoLog);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.tfParameter);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 69);
            this.panelControl1.TabIndex = 2;
            // 
            // cbUsuario
            // 
            this.cbUsuario.Location = new System.Drawing.Point(3, 26);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUsuario.Size = new System.Drawing.Size(114, 20);
            this.cbUsuario.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(4, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "USUÁRIO:";
            // 
            // cbEentoLog
            // 
            this.cbEentoLog.Location = new System.Drawing.Point(123, 26);
            this.cbEentoLog.Name = "cbEentoLog";
            this.cbEentoLog.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEentoLog.Size = new System.Drawing.Size(91, 20);
            this.cbEentoLog.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(124, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "EVENTO:";
            // 
            // tfParameter
            // 
            this.tfParameter.Location = new System.Drawing.Point(220, 26);
            this.tfParameter.Name = "tfParameter";
            this.tfParameter.Size = new System.Drawing.Size(484, 20);
            this.tfParameter.TabIndex = 2;
            // 
            // bntBuscar
            // 
            this.bntBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.bntBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.bntBuscar.ForeColor = System.Drawing.Color.White;
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(710, 5);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(133, 56);
            this.bntBuscar.TabIndex = 6;
            this.bntBuscar.Text = "Pesquisar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = false;
            this.bntBuscar.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(849, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 56);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // BuscaLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl);
            this.Name = "BuscaLogs";
            this.Size = new System.Drawing.Size(993, 573);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEentoLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfParameter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgLog;
        private DevExpress.XtraGrid.Columns.GridColumn coleventLog;
        private DevExpress.XtraGrid.Columns.GridColumn colmessage;
        private DevExpress.XtraGrid.Columns.GridColumn coluser;
        private DevExpress.XtraGrid.Columns.GridColumn coldateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colhost;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit tfParameter;
        private DevExpress.XtraEditors.ComboBoxEdit cbEentoLog;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private BotaoSair btnSair;
        private BotaoBuscar bntBuscar;
    }
}
