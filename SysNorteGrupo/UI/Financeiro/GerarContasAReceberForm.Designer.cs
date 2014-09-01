namespace SysNorteGrupo.UI.Financeiro
{
    partial class GerarContasAReceberForm
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarContasAReceberForm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bdgContasAReceber = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldata_vencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfDataVencimentoGridC = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colvalor_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgerado_boleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colnome_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.tfAno = new DevExpress.XtraEditors.SpinEdit();
            this.tfMes = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.tfDataVencimento = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLimpar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGerarContas = new DevExpress.XtraEditors.SimpleButton();
            this.checkListClientes = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.validadorGeracao = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgContasAReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimentoGridC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimentoGridC.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfAno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validadorGeracao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(963, 474);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.checkListClientes);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 41);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(959, 428);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gridControl);
            this.panelControl4.Controls.Add(this.panelControl5);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl4.Location = new System.Drawing.Point(237, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(720, 424);
            this.panelControl4.TabIndex = 2;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bdgContasAReceber;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(2, 41);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tfDataVencimentoGridC,
            this.repositoryItemTextEdit1});
            this.gridControl.Size = new System.Drawing.Size(716, 381);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdgContasAReceber
            // 
            this.bdgContasAReceber.DataSource = typeof(EntitiesGrupo.contas_a_receber);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldata_vencimento,
            this.colvalor_total,
            this.colgerado_boleto,
            this.coldescricao,
            this.colnome_cliente});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coldata_vencimento
            // 
            this.coldata_vencimento.Caption = "Data Vencimento";
            this.coldata_vencimento.ColumnEdit = this.tfDataVencimentoGridC;
            this.coldata_vencimento.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldata_vencimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldata_vencimento.FieldName = "data_vencimento";
            this.coldata_vencimento.Name = "coldata_vencimento";
            this.coldata_vencimento.Visible = true;
            this.coldata_vencimento.VisibleIndex = 1;
            this.coldata_vencimento.Width = 101;
            // 
            // tfDataVencimentoGridC
            // 
            this.tfDataVencimentoGridC.AutoHeight = false;
            this.tfDataVencimentoGridC.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataVencimentoGridC.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataVencimentoGridC.Name = "tfDataVencimentoGridC";
            // 
            // colvalor_total
            // 
            this.colvalor_total.Caption = "Valor total";
            this.colvalor_total.DisplayFormat.FormatString = "c2";
            this.colvalor_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_total.FieldName = "valor_total";
            this.colvalor_total.Name = "colvalor_total";
            this.colvalor_total.OptionsColumn.AllowEdit = false;
            this.colvalor_total.Visible = true;
            this.colvalor_total.VisibleIndex = 2;
            this.colvalor_total.Width = 94;
            // 
            // colgerado_boleto
            // 
            this.colgerado_boleto.Caption = "Gerado Boleto?";
            this.colgerado_boleto.FieldName = "gerado_boleto";
            this.colgerado_boleto.Name = "colgerado_boleto";
            this.colgerado_boleto.OptionsColumn.AllowEdit = false;
            this.colgerado_boleto.Visible = true;
            this.colgerado_boleto.VisibleIndex = 4;
            this.colgerado_boleto.Width = 81;
            // 
            // coldescricao
            // 
            this.coldescricao.Caption = "Descrição";
            this.coldescricao.ColumnEdit = this.repositoryItemTextEdit1;
            this.coldescricao.FieldName = "descricao";
            this.coldescricao.Name = "coldescricao";
            this.coldescricao.Visible = true;
            this.coldescricao.VisibleIndex = 3;
            this.coldescricao.Width = 199;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colnome_cliente
            // 
            this.colnome_cliente.Caption = "Cliente";
            this.colnome_cliente.FieldName = "nome_cliente";
            this.colnome_cliente.Name = "colnome_cliente";
            this.colnome_cliente.OptionsColumn.AllowEdit = false;
            this.colnome_cliente.Visible = true;
            this.colnome_cliente.VisibleIndex = 0;
            this.colnome_cliente.Width = 216;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.tfAno);
            this.panelControl5.Controls.Add(this.tfMes);
            this.panelControl5.Controls.Add(this.tfDataVencimento);
            this.panelControl5.Controls.Add(this.labelControl2);
            this.panelControl5.Controls.Add(this.labelControl1);
            this.panelControl5.Controls.Add(this.btnLimpar);
            this.panelControl5.Controls.Add(this.btnGerarContas);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(716, 39);
            this.panelControl5.TabIndex = 0;
            // 
            // tfAno
            // 
            this.tfAno.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tfAno.Location = new System.Drawing.Point(237, 9);
            this.tfAno.Name = "tfAno";
            this.tfAno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfAno.Properties.IsFloatValue = false;
            this.tfAno.Properties.Mask.EditMask = "d";
            this.tfAno.Size = new System.Drawing.Size(56, 20);
            this.tfAno.TabIndex = 4;
            // 
            // tfMes
            // 
            this.tfMes.Location = new System.Drawing.Point(120, 9);
            this.tfMes.Name = "tfMes";
            this.tfMes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfMes.Size = new System.Drawing.Size(111, 20);
            this.tfMes.TabIndex = 3;
            // 
            // tfDataVencimento
            // 
            this.tfDataVencimento.EditValue = null;
            this.tfDataVencimento.Location = new System.Drawing.Point(364, 9);
            this.tfDataVencimento.Name = "tfDataVencimento";
            this.tfDataVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataVencimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDataVencimento.Size = new System.Drawing.Size(107, 20);
            this.tfDataVencimento.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe a data de vencimento das contas.";
            this.validadorGeracao.SetValidationRule(this.tfDataVencimento, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(109, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mês/Ano competência:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(299, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Vencimento:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(636, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            // 
            // btnGerarContas
            // 
            this.btnGerarContas.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGerarContas.Image = ((System.Drawing.Image)(resources.GetObject("btnGerarContas.Image")));
            this.btnGerarContas.Location = new System.Drawing.Point(477, 4);
            this.btnGerarContas.Name = "btnGerarContas";
            this.btnGerarContas.Size = new System.Drawing.Size(153, 30);
            this.btnGerarContas.TabIndex = 0;
            this.btnGerarContas.Text = "Gerar Contas a Receber";
            this.btnGerarContas.Click += new System.EventHandler(this.btnGerarContas_Click);
            // 
            // checkListClientes
            // 
            this.checkListClientes.Location = new System.Drawing.Point(1, 2);
            this.checkListClientes.Name = "checkListClientes";
            this.checkListClientes.Size = new System.Drawing.Size(237, 424);
            this.checkListClientes.TabIndex = 1;
            this.checkListClientes.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkListClientes_ItemCheck);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSalvar);
            this.panelControl2.Controls.Add(this.btnSair);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(959, 39);
            this.panelControl2.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(758, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 30);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(859, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 30);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // GerarContasAReceberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "GerarContasAReceberForm";
            this.Size = new System.Drawing.Size(963, 474);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgContasAReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimentoGridC.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimentoGridC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfAno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfMes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDataVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validadorGeracao)).EndInit();
            this.ResumeLayout(false);

        }       

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSair;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl checkListClientes;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btnLimpar;
        private DevExpress.XtraEditors.SimpleButton btnGerarContas;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource bdgContasAReceber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_vencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_total;
        private DevExpress.XtraGrid.Columns.GridColumn colgerado_boleto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_cliente;
        private DevExpress.XtraEditors.DateEdit tfDataVencimento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit tfDataVencimentoGridC;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validadorGeracao;
        private DevExpress.XtraScheduler.UI.MonthEdit tfMes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit tfAno;
    }
}
