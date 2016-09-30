namespace SysNorteGrupo.Reports
{
    partial class RelatorioClientesECotasSubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioClientesECotasSubForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ckLoadAll = new DevExpress.XtraEditors.CheckEdit();
            this.panelDatas = new DevExpress.XtraEditors.PanelControl();
            this.tfDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.tfDataInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rgTipo = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnGerarRelatorio = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckLoadAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDatas)).BeginInit();
            this.panelDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ckLoadAll);
            this.panelControl1.Controls.Add(this.panelDatas);
            this.panelControl1.Controls.Add(this.rgTipo);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(435, 138);
            this.panelControl1.TabIndex = 0;
            // 
            // ckLoadAll
            // 
            this.ckLoadAll.Location = new System.Drawing.Point(5, 117);
            this.ckLoadAll.Name = "ckLoadAll";
            this.ckLoadAll.Properties.Caption = "Mostrar Clientes com cotas em R$0,00";
            this.ckLoadAll.Size = new System.Drawing.Size(221, 15);
            this.ckLoadAll.TabIndex = 4;
            // 
            // panelDatas
            // 
            this.panelDatas.Controls.Add(this.tfDataFinal);
            this.panelDatas.Controls.Add(this.tfDataInicial);
            this.panelDatas.Controls.Add(this.labelControl2);
            this.panelDatas.Controls.Add(this.labelControl1);
            this.panelDatas.Enabled = false;
            this.panelDatas.Location = new System.Drawing.Point(5, 81);
            this.panelDatas.Name = "panelDatas";
            this.panelDatas.Size = new System.Drawing.Size(428, 30);
            this.panelDatas.TabIndex = 3;
            // 
            // tfDataFinal
            // 
            this.tfDataFinal.EditValue = null;
            this.tfDataFinal.Location = new System.Drawing.Point(322, 5);
            this.tfDataFinal.Name = "tfDataFinal";
            this.tfDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataFinal.Size = new System.Drawing.Size(100, 20);
            this.tfDataFinal.TabIndex = 1;
            this.tfDataFinal.EditValueChanged += new System.EventHandler(this.tfDataFinal_EditValueChanged);
            // 
            // tfDataInicial
            // 
            this.tfDataInicial.EditValue = null;
            this.tfDataInicial.Location = new System.Drawing.Point(70, 5);
            this.tfDataInicial.Name = "tfDataInicial";
            this.tfDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataInicial.Size = new System.Drawing.Size(100, 20);
            this.tfDataInicial.TabIndex = 1;
            this.tfDataInicial.EditValueChanged += new System.EventHandler(this.tfDataInicial_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(264, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Data Final:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data Inicial:";
            // 
            // rgTipo
            // 
            this.rgTipo.Location = new System.Drawing.Point(2, 47);
            this.rgTipo.Name = "rgTipo";
            this.rgTipo.Properties.Columns = 2;
            this.rgTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Completo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Período")});
            this.rgTipo.Size = new System.Drawing.Size(431, 28);
            this.rgTipo.TabIndex = 2;
            this.rgTipo.SelectedIndexChanged += new System.EventHandler(this.rgTipo_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnGerarRelatorio);
            this.panelControl2.Controls.Add(this.btnCancel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(431, 39);
            this.panelControl2.TabIndex = 1;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarRelatorio.Image")));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(223, 5);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(121, 30);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(350, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RelatorioClientesECotasSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 138);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.MaximumSize = new System.Drawing.Size(451, 154);
            this.MinimumSize = new System.Drawing.Size(451, 154);
            this.Name = "RelatorioClientesECotasSubForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckLoadAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDatas)).EndInit();
            this.panelDatas.ResumeLayout(false);
            this.panelDatas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGerarRelatorio;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.RadioGroup rgTipo;
        private DevExpress.XtraEditors.PanelControl panelDatas;
        private DevExpress.XtraEditors.DateEdit tfDataFinal;
        private DevExpress.XtraEditors.DateEdit tfDataInicial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ckLoadAll;
    }
}