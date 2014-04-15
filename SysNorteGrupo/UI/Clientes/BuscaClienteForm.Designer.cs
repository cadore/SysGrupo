using SysNorteGrupo.UI.Utils.Botoes;
namespace SysNorteGrupo.UI.Clientes
{
    partial class BuscaClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaClienteForm));
            this.pbBotoes = new DevExpress.XtraEditors.PanelControl();
            this.btnFechar = new SysNorteGrupo.UI.Utils.Botoes.BotaoSair();
            this.btnBuscar = new SysNorteGrupo.UI.Utils.Botoes.BotaoBuscar();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ckInativo = new DevExpress.XtraEditors.CheckEdit();
            this.ckAtivo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfNomeDocumento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bdgCliente = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome_completo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinscricao_rg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisento_ICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefone_fixo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefone_celular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail_principal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail_secundario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontato_referencia_comercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia_de_servico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontato_referencia_de_servico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colreferencia_de_transporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcontato_referencia_de_transporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacoes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_cadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_ativacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_inativacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_enderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bairros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_total = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotoes)).BeginInit();
            this.pbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckInativo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAtivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNomeDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBotoes
            // 
            this.pbBotoes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(155)))));
            this.pbBotoes.Appearance.Options.UseBackColor = true;
            this.pbBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pbBotoes.Controls.Add(this.btnFechar);
            this.pbBotoes.Controls.Add(this.btnBuscar);
            this.pbBotoes.Controls.Add(this.panelControl2);
            this.pbBotoes.Controls.Add(this.labelControl2);
            this.pbBotoes.Controls.Add(this.tfNomeDocumento);
            this.pbBotoes.Controls.Add(this.labelControl1);
            this.pbBotoes.Controls.Add(this.tfId);
            this.pbBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBotoes.Location = new System.Drawing.Point(0, 0);
            this.pbBotoes.Name = "pbBotoes";
            this.pbBotoes.Size = new System.Drawing.Size(1021, 56);
            this.pbBotoes.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(912, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 44);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Sair";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(592, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 44);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.ckInativo);
            this.panelControl2.Controls.Add(this.ckAtivo);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(434, 6);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(153, 44);
            this.panelControl2.TabIndex = 4;
            // 
            // ckInativo
            // 
            this.ckInativo.Location = new System.Drawing.Point(77, 20);
            this.ckInativo.Name = "ckInativo";
            this.ckInativo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ckInativo.Properties.Appearance.Options.UseForeColor = true;
            this.ckInativo.Properties.Caption = "INATIVOS";
            this.ckInativo.Size = new System.Drawing.Size(75, 19);
            this.ckInativo.TabIndex = 2;
            this.ckInativo.CheckedChanged += new System.EventHandler(this.ckInativo_CheckedChanged);
            // 
            // ckAtivo
            // 
            this.ckAtivo.EditValue = true;
            this.ckAtivo.Location = new System.Drawing.Point(5, 20);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ckAtivo.Properties.Appearance.Options.UseForeColor = true;
            this.ckAtivo.Properties.Caption = "ATIVOS";
            this.ckAtivo.Size = new System.Drawing.Size(67, 19);
            this.ckAtivo.TabIndex = 0;
            this.ckAtivo.CheckedChanged += new System.EventHandler(this.ckAtivo_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(28, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "STATUS DO CLIENTE";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(97, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "NOME OU DOCUMENTO:";
            // 
            // tfNomeDocumento
            // 
            this.tfNomeDocumento.Location = new System.Drawing.Point(97, 30);
            this.tfNomeDocumento.Name = "tfNomeDocumento";
            this.tfNomeDocumento.Properties.Mask.EditMask = "\\d+";
            this.tfNomeDocumento.Size = new System.Drawing.Size(331, 20);
            this.tfNomeDocumento.TabIndex = 0;
            this.tfNomeDocumento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tfNomeDocumento_KeyUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(9, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "COD:";
            // 
            // tfId
            // 
            this.tfId.Location = new System.Drawing.Point(9, 30);
            this.tfId.Name = "tfId";
            this.tfId.Properties.Mask.EditMask = "\\d+";
            this.tfId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfId.Size = new System.Drawing.Size(82, 20);
            this.tfId.TabIndex = 0;
            this.tfId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tfId_KeyUp);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bdgCliente;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl.Location = new System.Drawing.Point(0, 56);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1021, 466);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControl_MouseDoubleClick);
            // 
            // bdgCliente
            // 
            this.bdgCliente.DataSource = typeof(EntitiesGrupo.cliente);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnome_completo,
            this.coltipo_cliente,
            this.coldocumento,
            this.colinscricao_rg,
            this.colisento_ICMS,
            this.coltelefone_fixo,
            this.coltelefone_celular,
            this.colemail_principal,
            this.colemail_secundario,
            this.colnumero,
            this.colcomplemento,
            this.colcep,
            this.colreferencia_comercial,
            this.colcontato_referencia_comercial,
            this.colreferencia_de_servico,
            this.colcontato_referencia_de_servico,
            this.colreferencia_de_transporte,
            this.colcontato_referencia_de_transporte,
            this.colobservacoes,
            this.coldata_cadastro,
            this.coldata_ativacao,
            this.coldata_inativacao,
            this.colinativo,
            this.colid_cidades,
            this.colid_enderecos,
            this.colid_bairros,
            this.colcotas,
            this.colvalor_total});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colcontato_referencia_de_transporte, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colid
            // 
            this.colid.Caption = "COD.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 33;
            // 
            // colnome_completo
            // 
            this.colnome_completo.Caption = "NOME COMPLETO";
            this.colnome_completo.FieldName = "nome_completo";
            this.colnome_completo.Name = "colnome_completo";
            this.colnome_completo.OptionsColumn.AllowEdit = false;
            this.colnome_completo.Visible = true;
            this.colnome_completo.VisibleIndex = 1;
            this.colnome_completo.Width = 265;
            // 
            // coltipo_cliente
            // 
            this.coltipo_cliente.FieldName = "tipo_cliente";
            this.coltipo_cliente.Name = "coltipo_cliente";
            this.coltipo_cliente.OptionsColumn.AllowEdit = false;
            this.coltipo_cliente.Width = 88;
            // 
            // coldocumento
            // 
            this.coldocumento.Caption = "DOCUMENTO Nº.";
            this.coldocumento.FieldName = "documento";
            this.coldocumento.Name = "coldocumento";
            this.coldocumento.OptionsColumn.AllowEdit = false;
            this.coldocumento.Visible = true;
            this.coldocumento.VisibleIndex = 2;
            this.coldocumento.Width = 125;
            // 
            // colinscricao_rg
            // 
            this.colinscricao_rg.Caption = "I.E./RG.";
            this.colinscricao_rg.FieldName = "inscricao_rg";
            this.colinscricao_rg.Name = "colinscricao_rg";
            this.colinscricao_rg.OptionsColumn.AllowEdit = false;
            this.colinscricao_rg.Width = 79;
            // 
            // colisento_ICMS
            // 
            this.colisento_ICMS.FieldName = "isento_ICMS";
            this.colisento_ICMS.Name = "colisento_ICMS";
            this.colisento_ICMS.OptionsColumn.AllowEdit = false;
            // 
            // coltelefone_fixo
            // 
            this.coltelefone_fixo.Caption = "TELEFONE FIXO.";
            this.coltelefone_fixo.FieldName = "telefone_fixo";
            this.coltelefone_fixo.Name = "coltelefone_fixo";
            this.coltelefone_fixo.OptionsColumn.AllowEdit = false;
            this.coltelefone_fixo.Width = 103;
            // 
            // coltelefone_celular
            // 
            this.coltelefone_celular.Caption = "TELEFONE CELULAR";
            this.coltelefone_celular.FieldName = "telefone_celular";
            this.coltelefone_celular.Name = "coltelefone_celular";
            this.coltelefone_celular.OptionsColumn.AllowEdit = false;
            this.coltelefone_celular.Width = 117;
            // 
            // colemail_principal
            // 
            this.colemail_principal.Caption = "EMAIL PRINCIPAL";
            this.colemail_principal.FieldName = "email_principal";
            this.colemail_principal.Name = "colemail_principal";
            this.colemail_principal.OptionsColumn.AllowEdit = false;
            this.colemail_principal.Visible = true;
            this.colemail_principal.VisibleIndex = 3;
            this.colemail_principal.Width = 140;
            // 
            // colemail_secundario
            // 
            this.colemail_secundario.FieldName = "email_secundario";
            this.colemail_secundario.Name = "colemail_secundario";
            this.colemail_secundario.OptionsColumn.AllowEdit = false;
            // 
            // colnumero
            // 
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.OptionsColumn.AllowEdit = false;
            // 
            // colcomplemento
            // 
            this.colcomplemento.FieldName = "complemento";
            this.colcomplemento.Name = "colcomplemento";
            this.colcomplemento.OptionsColumn.AllowEdit = false;
            // 
            // colcep
            // 
            this.colcep.FieldName = "cep";
            this.colcep.Name = "colcep";
            this.colcep.OptionsColumn.AllowEdit = false;
            // 
            // colreferencia_comercial
            // 
            this.colreferencia_comercial.FieldName = "referencia_comercial";
            this.colreferencia_comercial.Name = "colreferencia_comercial";
            this.colreferencia_comercial.OptionsColumn.AllowEdit = false;
            // 
            // colcontato_referencia_comercial
            // 
            this.colcontato_referencia_comercial.FieldName = "contato_referencia_comercial";
            this.colcontato_referencia_comercial.Name = "colcontato_referencia_comercial";
            this.colcontato_referencia_comercial.OptionsColumn.AllowEdit = false;
            // 
            // colreferencia_de_servico
            // 
            this.colreferencia_de_servico.FieldName = "referencia_de_servico";
            this.colreferencia_de_servico.Name = "colreferencia_de_servico";
            this.colreferencia_de_servico.OptionsColumn.AllowEdit = false;
            // 
            // colcontato_referencia_de_servico
            // 
            this.colcontato_referencia_de_servico.FieldName = "contato_referencia_de_servico";
            this.colcontato_referencia_de_servico.Name = "colcontato_referencia_de_servico";
            this.colcontato_referencia_de_servico.OptionsColumn.AllowEdit = false;
            // 
            // colreferencia_de_transporte
            // 
            this.colreferencia_de_transporte.FieldName = "referencia_de_transporte";
            this.colreferencia_de_transporte.Name = "colreferencia_de_transporte";
            this.colreferencia_de_transporte.OptionsColumn.AllowEdit = false;
            // 
            // colcontato_referencia_de_transporte
            // 
            this.colcontato_referencia_de_transporte.FieldName = "contato_referencia_de_transporte";
            this.colcontato_referencia_de_transporte.Name = "colcontato_referencia_de_transporte";
            this.colcontato_referencia_de_transporte.OptionsColumn.AllowEdit = false;
            // 
            // colobservacoes
            // 
            this.colobservacoes.FieldName = "observacoes";
            this.colobservacoes.Name = "colobservacoes";
            this.colobservacoes.OptionsColumn.AllowEdit = false;
            // 
            // coldata_cadastro
            // 
            this.coldata_cadastro.Caption = "DATA DE CADASTRO";
            this.coldata_cadastro.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldata_cadastro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldata_cadastro.FieldName = "data_cadastro";
            this.coldata_cadastro.Name = "coldata_cadastro";
            this.coldata_cadastro.OptionsColumn.AllowEdit = false;
            this.coldata_cadastro.Visible = true;
            this.coldata_cadastro.VisibleIndex = 6;
            this.coldata_cadastro.Width = 113;
            // 
            // coldata_ativacao
            // 
            this.coldata_ativacao.Caption = "DATA DE ATIVAÇÃO";
            this.coldata_ativacao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.coldata_ativacao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coldata_ativacao.FieldName = "data_ativacao";
            this.coldata_ativacao.Name = "coldata_ativacao";
            this.coldata_ativacao.OptionsColumn.AllowEdit = false;
            this.coldata_ativacao.Visible = true;
            this.coldata_ativacao.VisibleIndex = 7;
            this.coldata_ativacao.Width = 106;
            // 
            // coldata_inativacao
            // 
            this.coldata_inativacao.FieldName = "data_inativacao";
            this.coldata_inativacao.Name = "coldata_inativacao";
            this.coldata_inativacao.OptionsColumn.AllowEdit = false;
            // 
            // colinativo
            // 
            this.colinativo.Caption = "INATIVO";
            this.colinativo.FieldName = "inativo";
            this.colinativo.Name = "colinativo";
            this.colinativo.OptionsColumn.AllowEdit = false;
            this.colinativo.Visible = true;
            this.colinativo.VisibleIndex = 8;
            this.colinativo.Width = 64;
            // 
            // colid_cidades
            // 
            this.colid_cidades.FieldName = "id_cidades";
            this.colid_cidades.Name = "colid_cidades";
            this.colid_cidades.OptionsColumn.AllowEdit = false;
            // 
            // colid_enderecos
            // 
            this.colid_enderecos.FieldName = "id_enderecos";
            this.colid_enderecos.Name = "colid_enderecos";
            this.colid_enderecos.OptionsColumn.AllowEdit = false;
            // 
            // colid_bairros
            // 
            this.colid_bairros.FieldName = "id_bairros";
            this.colid_bairros.Name = "colid_bairros";
            this.colid_bairros.OptionsColumn.AllowEdit = false;
            // 
            // colcotas
            // 
            this.colcotas.Caption = "COTAS";
            this.colcotas.DisplayFormat.FormatString = "n";
            this.colcotas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcotas.FieldName = "cotas";
            this.colcotas.Name = "colcotas";
            this.colcotas.OptionsColumn.AllowEdit = false;
            this.colcotas.Visible = true;
            this.colcotas.VisibleIndex = 5;
            this.colcotas.Width = 54;
            // 
            // colvalor_total
            // 
            this.colvalor_total.Caption = "TOTAL DE BENS R$";
            this.colvalor_total.DisplayFormat.FormatString = "c2";
            this.colvalor_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor_total.FieldName = "valor_total";
            this.colvalor_total.Name = "colvalor_total";
            this.colvalor_total.OptionsColumn.AllowEdit = false;
            this.colvalor_total.Visible = true;
            this.colvalor_total.VisibleIndex = 4;
            this.colvalor_total.Width = 103;
            // 
            // BuscaClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.pbBotoes);
            this.Name = "BuscaClienteForm";
            this.Size = new System.Drawing.Size(1021, 522);
            ((System.ComponentModel.ISupportInitialize)(this.pbBotoes)).EndInit();
            this.pbBotoes.ResumeLayout(false);
            this.pbBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckInativo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAtivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNomeDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pbBotoes;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_completo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn coldocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colinscricao_rg;
        private DevExpress.XtraGrid.Columns.GridColumn colisento_ICMS;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefone_fixo;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefone_celular;
        private DevExpress.XtraGrid.Columns.GridColumn colemail_principal;
        private DevExpress.XtraGrid.Columns.GridColumn colemail_secundario;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colcomplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colcep;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colcontato_referencia_comercial;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia_de_servico;
        private DevExpress.XtraGrid.Columns.GridColumn colcontato_referencia_de_servico;
        private DevExpress.XtraGrid.Columns.GridColumn colreferencia_de_transporte;
        private DevExpress.XtraGrid.Columns.GridColumn colcontato_referencia_de_transporte;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacoes;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_cadastro;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_ativacao;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_inativacao;
        private DevExpress.XtraGrid.Columns.GridColumn colinativo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cidades;
        private DevExpress.XtraGrid.Columns.GridColumn colid_enderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bairros;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfNomeDocumento;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit ckInativo;
        private DevExpress.XtraEditors.CheckEdit ckAtivo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private BotaoBuscar btnBuscar;
        private BotaoSair btnFechar;
        private DevExpress.XtraGrid.Columns.GridColumn colcotas;
        private System.Windows.Forms.BindingSource bdgCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_total;
    }
}
