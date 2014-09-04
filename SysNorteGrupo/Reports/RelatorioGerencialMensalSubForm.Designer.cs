namespace SysNorteGrupo.Reports
{
    partial class RelatorioGerencialMensalSubForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.imagemExtrato = new DevExpress.XtraEditors.PictureEdit();
            this.btnEscolherImagem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfValoresCapitalizados = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfValoresAIntegralizar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfValoresEmCaixa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfValoresPagosDeSinistrosAIntegralizar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tfValoresDepositadosBanco = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgSinistrosRelatorioGerencial = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclienteEPlacas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorcamentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfOrcamentosGrid = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colpagamentoMes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfPagamentosGrid = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colvalor_por_cota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcotas_na_data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfSubTotalGrid = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.btnGerarRelatorio = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagemExtrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresCapitalizados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresAIntegralizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresEmCaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresPagosDeSinistrosAIntegralizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresDepositadosBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSinistrosRelatorioGerencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOrcamentosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPagamentosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSubTotalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(518, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Imagem Extrato:";
            // 
            // imagemExtrato
            // 
            this.imagemExtrato.Location = new System.Drawing.Point(518, 33);
            this.imagemExtrato.Name = "imagemExtrato";
            this.imagemExtrato.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.imagemExtrato.Size = new System.Drawing.Size(244, 138);
            this.imagemExtrato.TabIndex = 1;
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEscolherImagem.Location = new System.Drawing.Point(605, 4);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(157, 23);
            this.btnEscolherImagem.TabIndex = 5;
            this.btnEscolherImagem.Text = "Escolher Imagem";
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Valores Capitalizados no Grupo:";
            // 
            // tfValoresCapitalizados
            // 
            this.tfValoresCapitalizados.Location = new System.Drawing.Point(218, 11);
            this.tfValoresCapitalizados.Name = "tfValoresCapitalizados";
            this.tfValoresCapitalizados.Properties.Mask.EditMask = "c2";
            this.tfValoresCapitalizados.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValoresCapitalizados.Size = new System.Drawing.Size(137, 20);
            this.tfValoresCapitalizados.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 40);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Valores a Integralizar:";
            // 
            // tfValoresAIntegralizar
            // 
            this.tfValoresAIntegralizar.Location = new System.Drawing.Point(218, 37);
            this.tfValoresAIntegralizar.Name = "tfValoresAIntegralizar";
            this.tfValoresAIntegralizar.Properties.Mask.EditMask = "c2";
            this.tfValoresAIntegralizar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValoresAIntegralizar.Size = new System.Drawing.Size(137, 20);
            this.tfValoresAIntegralizar.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Valores em Caixa:";
            // 
            // tfValoresEmCaixa
            // 
            this.tfValoresEmCaixa.Location = new System.Drawing.Point(218, 63);
            this.tfValoresEmCaixa.Name = "tfValoresEmCaixa";
            this.tfValoresEmCaixa.Properties.Mask.EditMask = "c2";
            this.tfValoresEmCaixa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValoresEmCaixa.Size = new System.Drawing.Size(137, 20);
            this.tfValoresEmCaixa.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 92);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(203, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Valores pagos de sinistros a reintegralizar:";
            // 
            // tfValoresPagosDeSinistrosAIntegralizar
            // 
            this.tfValoresPagosDeSinistrosAIntegralizar.Location = new System.Drawing.Point(218, 89);
            this.tfValoresPagosDeSinistrosAIntegralizar.Name = "tfValoresPagosDeSinistrosAIntegralizar";
            this.tfValoresPagosDeSinistrosAIntegralizar.Properties.Mask.EditMask = "c2";
            this.tfValoresPagosDeSinistrosAIntegralizar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValoresPagosDeSinistrosAIntegralizar.Size = new System.Drawing.Size(137, 20);
            this.tfValoresPagosDeSinistrosAIntegralizar.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 118);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(185, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Valores depositados Banco Santander:";
            // 
            // tfValoresDepositadosBanco
            // 
            this.tfValoresDepositadosBanco.Location = new System.Drawing.Point(218, 115);
            this.tfValoresDepositadosBanco.Name = "tfValoresDepositadosBanco";
            this.tfValoresDepositadosBanco.Properties.Mask.EditMask = "c2";
            this.tfValoresDepositadosBanco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfValoresDepositadosBanco.Size = new System.Drawing.Size(137, 20);
            this.tfValoresDepositadosBanco.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgSinistrosRelatorioGerencial;
            this.gridControl1.Location = new System.Drawing.Point(9, 177);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.tfOrcamentosGrid,
            this.tfPagamentosGrid,
            this.tfSubTotalGrid});
            this.gridControl1.Size = new System.Drawing.Size(753, 216);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdgSinistrosRelatorioGerencial
            // 
            this.bdgSinistrosRelatorioGerencial.DataSource = typeof(SysNorteGrupo.Reports.SinistrosRelatorioGerencial);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclienteEPlacas,
            this.colorcamentos,
            this.colpagamentoMes,
            this.colvalor_por_cota,
            this.colcotas_na_data,
            this.colsubTotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colclienteEPlacas
            // 
            this.colclienteEPlacas.Caption = "Cliente/Veiculos";
            this.colclienteEPlacas.FieldName = "clienteEPlacas";
            this.colclienteEPlacas.Name = "colclienteEPlacas";
            this.colclienteEPlacas.OptionsColumn.AllowEdit = false;
            this.colclienteEPlacas.Visible = true;
            this.colclienteEPlacas.VisibleIndex = 0;
            this.colclienteEPlacas.Width = 261;
            // 
            // colorcamentos
            // 
            this.colorcamentos.Caption = "Orçamentos";
            this.colorcamentos.ColumnEdit = this.tfOrcamentosGrid;
            this.colorcamentos.DisplayFormat.FormatString = "c2";
            this.colorcamentos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colorcamentos.FieldName = "orcamentos";
            this.colorcamentos.Name = "colorcamentos";
            this.colorcamentos.OptionsColumn.AllowEdit = false;
            this.colorcamentos.Visible = true;
            this.colorcamentos.VisibleIndex = 1;
            this.colorcamentos.Width = 93;
            // 
            // tfOrcamentosGrid
            // 
            this.tfOrcamentosGrid.AutoHeight = false;
            this.tfOrcamentosGrid.Name = "tfOrcamentosGrid";
            // 
            // colpagamentoMes
            // 
            this.colpagamentoMes.Caption = "Pagamentos Mês";
            this.colpagamentoMes.ColumnEdit = this.tfPagamentosGrid;
            this.colpagamentoMes.DisplayFormat.FormatString = "c2";
            this.colpagamentoMes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colpagamentoMes.FieldName = "pagamentoMes";
            this.colpagamentoMes.Name = "colpagamentoMes";
            this.colpagamentoMes.OptionsColumn.AllowEdit = false;
            this.colpagamentoMes.Visible = true;
            this.colpagamentoMes.VisibleIndex = 2;
            this.colpagamentoMes.Width = 93;
            // 
            // tfPagamentosGrid
            // 
            this.tfPagamentosGrid.AutoHeight = false;
            this.tfPagamentosGrid.Name = "tfPagamentosGrid";
            // 
            // colvalor_por_cota
            // 
            this.colvalor_por_cota.Caption = "Valor por Cota";
            this.colvalor_por_cota.DisplayFormat.FormatString = "c2";
            this.colvalor_por_cota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_por_cota.FieldName = "valor_por_cota";
            this.colvalor_por_cota.Name = "colvalor_por_cota";
            this.colvalor_por_cota.OptionsColumn.AllowEdit = false;
            this.colvalor_por_cota.Visible = true;
            this.colvalor_por_cota.VisibleIndex = 3;
            this.colvalor_por_cota.Width = 93;
            // 
            // colcotas_na_data
            // 
            this.colcotas_na_data.Caption = "Cotas na Data";
            this.colcotas_na_data.DisplayFormat.FormatString = "c3";
            this.colcotas_na_data.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcotas_na_data.FieldName = "cotas_na_data";
            this.colcotas_na_data.Name = "colcotas_na_data";
            this.colcotas_na_data.OptionsColumn.AllowEdit = false;
            this.colcotas_na_data.Visible = true;
            this.colcotas_na_data.VisibleIndex = 4;
            this.colcotas_na_data.Width = 93;
            // 
            // colsubTotal
            // 
            this.colsubTotal.Caption = "Sub. Total";
            this.colsubTotal.ColumnEdit = this.tfSubTotalGrid;
            this.colsubTotal.DisplayFormat.FormatString = "c2";
            this.colsubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsubTotal.FieldName = "subTotal";
            this.colsubTotal.Name = "colsubTotal";
            this.colsubTotal.OptionsColumn.AllowEdit = false;
            this.colsubTotal.Width = 102;
            // 
            // tfSubTotalGrid
            // 
            this.tfSubTotalGrid.AutoHeight = false;
            this.tfSubTotalGrid.Name = "tfSubTotalGrid";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGerarRelatorio.Location = new System.Drawing.Point(665, 399);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(97, 23);
            this.btnGerarRelatorio.TabIndex = 6;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // RelatorioGerencialMensalSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tfValoresDepositadosBanco);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tfValoresPagosDeSinistrosAIntegralizar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tfValoresEmCaixa);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tfValoresAIntegralizar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tfValoresCapitalizados);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnEscolherImagem);
            this.Controls.Add(this.imagemExtrato);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 462);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 462);
            this.Name = "RelatorioGerencialMensalSubForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatorio Gerencial Mensal";
            ((System.ComponentModel.ISupportInitialize)(this.imagemExtrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresCapitalizados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresAIntegralizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresEmCaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresPagosDeSinistrosAIntegralizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValoresDepositadosBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSinistrosRelatorioGerencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfOrcamentosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPagamentosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfSubTotalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit imagemExtrato;
        private DevExpress.XtraEditors.SimpleButton btnEscolherImagem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfValoresCapitalizados;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfValoresAIntegralizar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfValoresEmCaixa;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tfValoresPagosDeSinistrosAIntegralizar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tfValoresDepositadosBanco;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgSinistrosRelatorioGerencial;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colclienteEPlacas;
        private DevExpress.XtraGrid.Columns.GridColumn colorcamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colpagamentoMes;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_por_cota;
        private DevExpress.XtraGrid.Columns.GridColumn colcotas_na_data;
        private DevExpress.XtraGrid.Columns.GridColumn colsubTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit tfOrcamentosGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit tfPagamentosGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit tfSubTotalGrid;
        private DevExpress.XtraEditors.SimpleButton btnGerarRelatorio;
    }
}