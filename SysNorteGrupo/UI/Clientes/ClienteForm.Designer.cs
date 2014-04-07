using SysFileManager;
using SysNorteGrupo.UI.Botoes;
namespace SysNorteGrupo.UI.Clientes
{
    partial class ClienteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule9 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule10 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule11 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule12 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.pnBotoes = new DevExpress.XtraEditors.PanelControl();
            this.btnImprimirContrato = new BotaoImprimir();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new BotaoSair();
            this.btnEditar = new BotaoEditar();
            this.btnSalvar = new BotaoEditar();
            this.btnNovo = new BotaoNovo();
            this.panelComponentes = new DevExpress.XtraEditors.PanelControl();
            this.grpTipo = new DevExpress.XtraEditors.RadioGroup();
            this.panelArquivos = new DevExpress.XtraEditors.PanelControl();
            this.arquivosFormCli = new SysFileManager.ArquivosForm();
            this.panelReferencias = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.tfRefcomercial = new DevExpress.XtraEditors.TextEdit();
            this.bdgCliente = new System.Windows.Forms.BindingSource();
            this.tfContcomercial = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.tfRefservicos = new DevExpress.XtraEditors.TextEdit();
            this.tfContservicos = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.tfReftransporte = new DevExpress.XtraEditors.TextEdit();
            this.tfConttransporte = new DevExpress.XtraEditors.TextEdit();
            this.panelCadastro = new DevExpress.XtraEditors.PanelControl();
            this.grpEndereco = new DevExpress.XtraEditors.GroupControl();
            this.btnCadEndereco = new DevExpress.XtraEditors.SimpleButton();
            this.btnCadBairro = new DevExpress.XtraEditors.SimpleButton();
            this.tfObservacoes = new DevExpress.XtraEditors.MemoEdit();
            this.cbEndereco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgEnderecos = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_endereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbairro_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbBairro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgBairros = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome_bairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tfComplemento = new DevExpress.XtraEditors.TextEdit();
            this.tfCep = new DevExpress.XtraEditors.TextEdit();
            this.tfNumero = new DevExpress.XtraEditors.TextEdit();
            this.cbEstados = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgEstados = new System.Windows.Forms.BindingSource();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_ibge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbCidade = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCidades = new System.Windows.Forms.BindingSource();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grpContato = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tfEmailSecundario = new DevExpress.XtraEditors.TextEdit();
            this.tfEmailPrincipal = new DevExpress.XtraEditors.TextEdit();
            this.tfTelCelular = new DevExpress.XtraEditors.TextEdit();
            this.tfTelFixo = new DevExpress.XtraEditors.TextEdit();
            this.grpInfoBasica = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ckIsento = new DevExpress.XtraEditors.CheckEdit();
            this.tfNome = new DevExpress.XtraEditors.TextEdit();
            this.tfDocumento = new DevExpress.XtraEditors.TextEdit();
            this.tfInscricao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfTotalBens = new DevExpress.XtraEditors.TextEdit();
            this.tfTotalCotas = new DevExpress.XtraEditors.TextEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.validador = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).BeginInit();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelComponentes)).BeginInit();
            this.panelComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelArquivos)).BeginInit();
            this.panelArquivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelReferencias)).BeginInit();
            this.panelReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfRefcomercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfContcomercial.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfRefservicos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfContservicos.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfReftransporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfConttransporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCadastro)).BeginInit();
            this.panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEndereco)).BeginInit();
            this.grpEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservacoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpContato)).BeginInit();
            this.grpContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailSecundario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailPrincipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTelCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTelFixo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfoBasica)).BeginInit();
            this.grpInfoBasica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckIsento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfInscricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotalBens.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotalCotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(155)))));
            this.pnBotoes.Appearance.Options.UseBackColor = true;
            this.pnBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnBotoes.Controls.Add(this.btnImprimirContrato);
            this.pnBotoes.Controls.Add(this.button1);
            this.pnBotoes.Controls.Add(this.btnSair);
            this.pnBotoes.Controls.Add(this.btnEditar);
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnNovo);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(1083, 69);
            this.pnBotoes.TabIndex = 0;
            // 
            // btnImprimirContrato
            // 
            this.btnImprimirContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnImprimirContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirContrato.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnImprimirContrato.ForeColor = System.Drawing.Color.White;
            this.btnImprimirContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirContrato.Image")));
            this.btnImprimirContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirContrato.Location = new System.Drawing.Point(361, 5);
            this.btnImprimirContrato.Name = "btnImprimirContrato";
            this.btnImprimirContrato.Size = new System.Drawing.Size(146, 56);
            this.btnImprimirContrato.TabIndex = 12;
            this.btnImprimirContrato.Text = "           Imprimir Rel. de Bens";
            this.btnImprimirContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirContrato.UseVisualStyleBackColor = false;
            this.btnImprimirContrato.Visible = false;
            this.btnImprimirContrato.Click += new System.EventHandler(this.btnImprimirContrato_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(961, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 56);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(129, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 56);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(13, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 56);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(245, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 56);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelComponentes
            // 
            this.panelComponentes.Controls.Add(this.grpTipo);
            this.panelComponentes.Controls.Add(this.panelArquivos);
            this.panelComponentes.Controls.Add(this.panelReferencias);
            this.panelComponentes.Controls.Add(this.panelCadastro);
            this.panelComponentes.Controls.Add(this.tfTotalBens);
            this.panelComponentes.Controls.Add(this.tfTotalCotas);
            this.panelComponentes.Controls.Add(this.tfId);
            this.panelComponentes.Controls.Add(this.labelControl9);
            this.panelComponentes.Controls.Add(this.labelControl24);
            this.panelComponentes.Controls.Add(this.labelControl23);
            this.panelComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComponentes.Location = new System.Drawing.Point(0, 69);
            this.panelComponentes.Name = "panelComponentes";
            this.panelComponentes.Size = new System.Drawing.Size(1083, 521);
            this.panelComponentes.TabIndex = 1;
            // 
            // grpTipo
            // 
            this.grpTipo.Location = new System.Drawing.Point(370, 4);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem('f', "Pessoa Física"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem('j', "Pessoa Jurídica")});
            this.grpTipo.Size = new System.Drawing.Size(222, 29);
            this.grpTipo.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Selecione o tipo de pessoa";
            this.validador.SetValidationRule(this.grpTipo, conditionValidationRule1);
            this.grpTipo.SelectedIndexChanged += new System.EventHandler(this.grpTipo_SelectedIndexChanged);
            // 
            // panelArquivos
            // 
            this.panelArquivos.Controls.Add(this.arquivosFormCli);
            this.panelArquivos.Location = new System.Drawing.Point(13, 315);
            this.panelArquivos.Name = "panelArquivos";
            this.panelArquivos.Size = new System.Drawing.Size(1058, 201);
            this.panelArquivos.TabIndex = 9;
            // 
            // arquivosFormCli
            // 
            this.arquivosFormCli.Location = new System.Drawing.Point(5, 5);
            this.arquivosFormCli.Name = "arquivosFormCli";
            this.arquivosFormCli.Size = new System.Drawing.Size(1048, 191);
            this.arquivosFormCli.TabIndex = 0;
            // 
            // panelReferencias
            // 
            this.panelReferencias.Controls.Add(this.xtraTabControl1);
            this.panelReferencias.Enabled = false;
            this.panelReferencias.Location = new System.Drawing.Point(13, 244);
            this.panelReferencias.Name = "panelReferencias";
            this.panelReferencias.Size = new System.Drawing.Size(1057, 70);
            this.panelReferencias.TabIndex = 8;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1045, 64);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl16);
            this.xtraTabPage1.Controls.Add(this.labelControl15);
            this.xtraTabPage1.Controls.Add(this.tfRefcomercial);
            this.xtraTabPage1.Controls.Add(this.tfContcomercial);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1039, 36);
            this.xtraTabPage1.Text = "REFERÊNCIA COMERCIAL";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(15, 12);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(67, 13);
            this.labelControl16.TabIndex = 4;
            this.labelControl16.Text = "REFERÊNCIA:";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(563, 12);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(53, 13);
            this.labelControl15.TabIndex = 4;
            this.labelControl15.Text = "CONTATO:";
            // 
            // tfRefcomercial
            // 
            this.tfRefcomercial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "referencia_comercial", true));
            this.tfRefcomercial.Location = new System.Drawing.Point(88, 9);
            this.tfRefcomercial.Name = "tfRefcomercial";
            this.tfRefcomercial.Size = new System.Drawing.Size(469, 20);
            this.tfRefcomercial.TabIndex = 0;
            // 
            // bdgCliente
            // 
            this.bdgCliente.DataSource = typeof(EntitiesGrupo.cliente);
            // 
            // tfContcomercial
            // 
            this.tfContcomercial.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "contato_referencia_comercial", true));
            this.tfContcomercial.Location = new System.Drawing.Point(622, 9);
            this.tfContcomercial.Name = "tfContcomercial";
            this.tfContcomercial.Properties.Mask.EditMask = "(99)0000-0000";
            this.tfContcomercial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfContcomercial.Size = new System.Drawing.Size(136, 20);
            this.tfContcomercial.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl17);
            this.xtraTabPage2.Controls.Add(this.labelControl18);
            this.xtraTabPage2.Controls.Add(this.tfRefservicos);
            this.xtraTabPage2.Controls.Add(this.tfContservicos);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1039, 36);
            this.xtraTabPage2.Text = "REFERÊNCIA DE SERVIÇOS";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(15, 12);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(67, 13);
            this.labelControl17.TabIndex = 7;
            this.labelControl17.Text = "REFERÊNCIA:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(563, 12);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(53, 13);
            this.labelControl18.TabIndex = 8;
            this.labelControl18.Text = "CONTATO:";
            // 
            // tfRefservicos
            // 
            this.tfRefservicos.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "referencia_de_servico", true));
            this.tfRefservicos.Location = new System.Drawing.Point(88, 9);
            this.tfRefservicos.Name = "tfRefservicos";
            this.tfRefservicos.Size = new System.Drawing.Size(469, 20);
            this.tfRefservicos.TabIndex = 5;
            // 
            // tfContservicos
            // 
            this.tfContservicos.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "contato_referencia_de_servico", true));
            this.tfContservicos.Location = new System.Drawing.Point(622, 9);
            this.tfContservicos.Name = "tfContservicos";
            this.tfContservicos.Properties.Mask.EditMask = "(99)0000-0000";
            this.tfContservicos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfContservicos.Size = new System.Drawing.Size(136, 20);
            this.tfContservicos.TabIndex = 6;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl19);
            this.xtraTabPage3.Controls.Add(this.labelControl20);
            this.xtraTabPage3.Controls.Add(this.tfReftransporte);
            this.xtraTabPage3.Controls.Add(this.tfConttransporte);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1039, 36);
            this.xtraTabPage3.Text = "REFERÊNCIA DE TRANSPORTE";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(15, 12);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(67, 13);
            this.labelControl19.TabIndex = 11;
            this.labelControl19.Text = "REFERÊNCIA:";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(563, 12);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(53, 13);
            this.labelControl20.TabIndex = 12;
            this.labelControl20.Text = "CONTATO:";
            // 
            // tfReftransporte
            // 
            this.tfReftransporte.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "referencia_de_transporte", true));
            this.tfReftransporte.Location = new System.Drawing.Point(88, 9);
            this.tfReftransporte.Name = "tfReftransporte";
            this.tfReftransporte.Size = new System.Drawing.Size(469, 20);
            this.tfReftransporte.TabIndex = 9;
            // 
            // tfConttransporte
            // 
            this.tfConttransporte.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "contato_referencia_de_transporte", true));
            this.tfConttransporte.Location = new System.Drawing.Point(622, 9);
            this.tfConttransporte.Name = "tfConttransporte";
            this.tfConttransporte.Properties.Mask.EditMask = "(99)0000-0000";
            this.tfConttransporte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfConttransporte.Size = new System.Drawing.Size(136, 20);
            this.tfConttransporte.TabIndex = 10;
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.grpEndereco);
            this.panelCadastro.Controls.Add(this.grpContato);
            this.panelCadastro.Controls.Add(this.grpInfoBasica);
            this.panelCadastro.Location = new System.Drawing.Point(13, 35);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(1057, 206);
            this.panelCadastro.TabIndex = 7;
            // 
            // grpEndereco
            // 
            this.grpEndereco.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEndereco.AppearanceCaption.Options.UseFont = true;
            this.grpEndereco.Controls.Add(this.btnCadEndereco);
            this.grpEndereco.Controls.Add(this.btnCadBairro);
            this.grpEndereco.Controls.Add(this.tfObservacoes);
            this.grpEndereco.Controls.Add(this.cbEndereco);
            this.grpEndereco.Controls.Add(this.cbBairro);
            this.grpEndereco.Controls.Add(this.tfComplemento);
            this.grpEndereco.Controls.Add(this.tfCep);
            this.grpEndereco.Controls.Add(this.tfNumero);
            this.grpEndereco.Controls.Add(this.cbEstados);
            this.grpEndereco.Controls.Add(this.cbCidade);
            this.grpEndereco.Controls.Add(this.labelControl21);
            this.grpEndereco.Controls.Add(this.labelControl13);
            this.grpEndereco.Controls.Add(this.labelControl14);
            this.grpEndereco.Controls.Add(this.labelControl12);
            this.grpEndereco.Controls.Add(this.labelControl11);
            this.grpEndereco.Controls.Add(this.labelControl10);
            this.grpEndereco.Controls.Add(this.labelControl22);
            this.grpEndereco.Controls.Add(this.labelControl8);
            this.grpEndereco.Location = new System.Drawing.Point(582, 5);
            this.grpEndereco.Name = "grpEndereco";
            this.grpEndereco.Size = new System.Drawing.Size(468, 195);
            this.grpEndereco.TabIndex = 2;
            this.grpEndereco.Text = "INFORMAÇÕES DE ENDEREÇO";
            // 
            // btnCadEndereco
            // 
            this.btnCadEndereco.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCadEndereco.Image = global::SysNorteGrupo.Properties.Resources.Action_LinkUnlink_Link;
            this.btnCadEndereco.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCadEndereco.Location = new System.Drawing.Point(426, 70);
            this.btnCadEndereco.Name = "btnCadEndereco";
            this.btnCadEndereco.Size = new System.Drawing.Size(30, 19);
            this.btnCadEndereco.TabIndex = 7;
            this.btnCadEndereco.Click += new System.EventHandler(this.btnCadEndereco_Click);
            // 
            // btnCadBairro
            // 
            this.btnCadBairro.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCadBairro.Image = global::SysNorteGrupo.Properties.Resources.Action_LinkUnlink_Link;
            this.btnCadBairro.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCadBairro.Location = new System.Drawing.Point(426, 47);
            this.btnCadBairro.Name = "btnCadBairro";
            this.btnCadBairro.Size = new System.Drawing.Size(30, 19);
            this.btnCadBairro.TabIndex = 7;
            this.btnCadBairro.Click += new System.EventHandler(this.btnCadBairro_Click);
            // 
            // tfObservacoes
            // 
            this.tfObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "observacoes", true));
            this.tfObservacoes.Location = new System.Drawing.Point(71, 139);
            this.tfObservacoes.Name = "tfObservacoes";
            this.tfObservacoes.Size = new System.Drawing.Size(385, 51);
            this.tfObservacoes.TabIndex = 6;
            this.tfObservacoes.UseOptimizedRendering = true;
            // 
            // cbEndereco
            // 
            this.cbEndereco.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "id_enderecos", true));
            this.cbEndereco.Location = new System.Drawing.Point(71, 70);
            this.cbEndereco.Name = "cbEndereco";
            this.cbEndereco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEndereco.Properties.DataSource = this.bdgEnderecos;
            this.cbEndereco.Properties.DisplayMember = "_endereco";
            this.cbEndereco.Properties.NullText = "";
            this.cbEndereco.Properties.ValueMember = "id";
            this.cbEndereco.Properties.View = this.gridView2;
            this.cbEndereco.Size = new System.Drawing.Size(349, 20);
            this.cbEndereco.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Informe um endereço";
            conditionValidationRule2.Value1 = 0;
            this.validador.SetValidationRule(this.cbEndereco, conditionValidationRule2);
            this.cbEndereco.EditValueChanged += new System.EventHandler(this.cbEndereco_EditValueChanged);
            // 
            // bdgEnderecos
            // 
            this.bdgEnderecos.DataSource = typeof(EntitiesGrupo.endereco);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.colcep,
            this.col_endereco,
            this.colbairro_id,
            this.gridColumn6});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // colcep
            // 
            this.colcep.Caption = "CEP";
            this.colcep.FieldName = "cep";
            this.colcep.Name = "colcep";
            this.colcep.OptionsColumn.AllowEdit = false;
            this.colcep.Visible = true;
            this.colcep.VisibleIndex = 1;
            this.colcep.Width = 278;
            // 
            // col_endereco
            // 
            this.col_endereco.Caption = "ENDEREÇO";
            this.col_endereco.FieldName = "_endereco";
            this.col_endereco.Name = "col_endereco";
            this.col_endereco.OptionsColumn.AllowEdit = false;
            this.col_endereco.Visible = true;
            this.col_endereco.VisibleIndex = 0;
            this.col_endereco.Width = 1034;
            // 
            // colbairro_id
            // 
            this.colbairro_id.FieldName = "bairro_id";
            this.colbairro_id.Name = "colbairro_id";
            this.colbairro_id.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "id_cidades";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            // 
            // cbBairro
            // 
            this.cbBairro.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "id_bairros", true));
            this.cbBairro.Location = new System.Drawing.Point(71, 47);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBairro.Properties.DataSource = this.bdgBairros;
            this.cbBairro.Properties.DisplayMember = "nome_bairro";
            this.cbBairro.Properties.NullText = "";
            this.cbBairro.Properties.ValueMember = "id";
            this.cbBairro.Properties.View = this.gridView1;
            this.cbBairro.Size = new System.Drawing.Size(349, 20);
            this.cbBairro.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Selecione um bairro para o endereço";
            conditionValidationRule3.Value1 = 0;
            this.validador.SetValidationRule(this.cbBairro, conditionValidationRule3);
            // 
            // bdgBairros
            // 
            this.bdgBairros.DataSource = typeof(EntitiesGrupo.bairro);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colnome_bairro,
            this.colid_cidades});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "id";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            // 
            // colnome_bairro
            // 
            this.colnome_bairro.Caption = "BAIRRO";
            this.colnome_bairro.FieldName = "nome_bairro";
            this.colnome_bairro.Name = "colnome_bairro";
            this.colnome_bairro.OptionsColumn.AllowEdit = false;
            this.colnome_bairro.Visible = true;
            this.colnome_bairro.VisibleIndex = 0;
            // 
            // colid_cidades
            // 
            this.colid_cidades.FieldName = "id_cidades";
            this.colid_cidades.Name = "colid_cidades";
            this.colid_cidades.OptionsColumn.AllowEdit = false;
            // 
            // tfComplemento
            // 
            this.tfComplemento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "complemento", true));
            this.tfComplemento.Location = new System.Drawing.Point(71, 116);
            this.tfComplemento.Name = "tfComplemento";
            this.tfComplemento.Size = new System.Drawing.Size(385, 20);
            this.tfComplemento.TabIndex = 5;
            // 
            // tfCep
            // 
            this.tfCep.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "cep", true));
            this.tfCep.Location = new System.Drawing.Point(290, 93);
            this.tfCep.Name = "tfCep";
            this.tfCep.Properties.Mask.EditMask = "99999-999";
            this.tfCep.Properties.ReadOnly = true;
            this.tfCep.Size = new System.Drawing.Size(166, 20);
            this.tfCep.TabIndex = 4;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Informe o CEP";
            this.validador.SetValidationRule(this.tfCep, conditionValidationRule4);
            // 
            // tfNumero
            // 
            this.tfNumero.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "numero", true));
            this.tfNumero.Location = new System.Drawing.Point(71, 93);
            this.tfNumero.Name = "tfNumero";
            this.tfNumero.Size = new System.Drawing.Size(174, 20);
            this.tfNumero.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Informe o número do endereço";
            this.validador.SetValidationRule(this.tfNumero, conditionValidationRule5);
            // 
            // cbEstados
            // 
            this.cbEstados.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "uf_estado", true));
            this.cbEstados.EditValue = "";
            this.cbEstados.Location = new System.Drawing.Point(71, 24);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstados.Properties.DataSource = this.bdgEstados;
            this.cbEstados.Properties.DisplayMember = "uf";
            this.cbEstados.Properties.NullText = "";
            this.cbEstados.Properties.ValueMember = "uf";
            this.cbEstados.Properties.View = this.gridView3;
            this.cbEstados.Size = new System.Drawing.Size(62, 20);
            this.cbEstados.TabIndex = 0;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Selecione um estado para o endereço";
            this.validador.SetValidationRule(this.cbEstados, conditionValidationRule6);
            this.cbEstados.EditValueChanged += new System.EventHandler(this.cbEstados_EditValueChanged);
            // 
            // bdgEstados
            // 
            this.bdgEstados.DataSource = typeof(EntitiesGrupo.estado);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coluf,
            this.colnome_estado,
            this.colcod_ibge});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            // 
            // coluf
            // 
            this.coluf.Caption = "SIGLA";
            this.coluf.FieldName = "uf";
            this.coluf.Name = "coluf";
            this.coluf.OptionsColumn.AllowEdit = false;
            this.coluf.Visible = true;
            this.coluf.VisibleIndex = 0;
            this.coluf.Width = 250;
            // 
            // colnome_estado
            // 
            this.colnome_estado.Caption = "ESTADO";
            this.colnome_estado.FieldName = "nome_estado";
            this.colnome_estado.Name = "colnome_estado";
            this.colnome_estado.OptionsColumn.AllowEdit = false;
            this.colnome_estado.Visible = true;
            this.colnome_estado.VisibleIndex = 1;
            this.colnome_estado.Width = 1062;
            // 
            // colcod_ibge
            // 
            this.colcod_ibge.FieldName = "cod_ibge";
            this.colcod_ibge.Name = "colcod_ibge";
            this.colcod_ibge.OptionsColumn.AllowEdit = false;
            // 
            // cbCidade
            // 
            this.cbCidade.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "id_cidades", true));
            this.cbCidade.EditValue = "";
            this.cbCidade.Location = new System.Drawing.Point(188, 24);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCidade.Properties.DataSource = this.bdgCidades;
            this.cbCidade.Properties.DisplayMember = "nome_cidade";
            this.cbCidade.Properties.NullText = "";
            this.cbCidade.Properties.ValueMember = "id";
            this.cbCidade.Properties.View = this.searchLookUpEdit1View;
            this.cbCidade.Size = new System.Drawing.Size(268, 20);
            this.cbCidade.TabIndex = 0;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule7.ErrorText = "Selecione uma cidade para o endereço";
            conditionValidationRule7.Value1 = 0;
            this.validador.SetValidationRule(this.cbCidade, conditionValidationRule7);
            this.cbCidade.EditValueChanged += new System.EventHandler(this.cbCidade_EditValueChanged);
            // 
            // bdgCidades
            // 
            this.bdgCidades.DataSource = typeof(EntitiesGrupo.cidade);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.col_cidade,
            this.gridColumn2,
            this.gridColumn3,
            this.colarea});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // col_cidade
            // 
            this.col_cidade.Caption = "CIDADE";
            this.col_cidade.FieldName = "nome_cidade";
            this.col_cidade.Name = "col_cidade";
            this.col_cidade.OptionsColumn.AllowEdit = false;
            this.col_cidade.Visible = true;
            this.col_cidade.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "uf";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "cod_ibge";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // colarea
            // 
            this.colarea.FieldName = "area";
            this.colarea.Name = "colarea";
            this.colarea.OptionsColumn.AllowEdit = false;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(37, 141);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(28, 13);
            this.labelControl21.TabIndex = 4;
            this.labelControl21.Text = "OBS.:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(28, 119);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(37, 13);
            this.labelControl13.TabIndex = 4;
            this.labelControl13.Text = "COMP.:";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(261, 96);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(23, 13);
            this.labelControl14.TabIndex = 4;
            this.labelControl14.Text = "CEP:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(49, 96);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(16, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Nº:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(7, 73);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(58, 13);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "ENDEREÇO:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(22, 50);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(43, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "BAIRRO:";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(21, 27);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(44, 13);
            this.labelControl22.TabIndex = 4;
            this.labelControl22.Text = "ESTADO:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(139, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "CIDADE:";
            // 
            // grpContato
            // 
            this.grpContato.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpContato.AppearanceCaption.Options.UseFont = true;
            this.grpContato.Controls.Add(this.labelControl7);
            this.grpContato.Controls.Add(this.labelControl4);
            this.grpContato.Controls.Add(this.labelControl6);
            this.grpContato.Controls.Add(this.labelControl5);
            this.grpContato.Controls.Add(this.tfEmailSecundario);
            this.grpContato.Controls.Add(this.tfEmailPrincipal);
            this.grpContato.Controls.Add(this.tfTelCelular);
            this.grpContato.Controls.Add(this.tfTelFixo);
            this.grpContato.Location = new System.Drawing.Point(5, 104);
            this.grpContato.Name = "grpContato";
            this.grpContato.Size = new System.Drawing.Size(574, 96);
            this.grpContato.TabIndex = 1;
            this.grpContato.Text = "INFORMAÇÕES DE CONTATO";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(14, 73);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(103, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "EMAIL SECUNDÁRIO:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "EMAIL PRINCIPAL:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(301, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "TELEFONE CELULAR:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "TELEFONE FIXO:";
            // 
            // tfEmailSecundario
            // 
            this.tfEmailSecundario.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "email_secundario", true));
            this.tfEmailSecundario.Location = new System.Drawing.Point(122, 70);
            this.tfEmailSecundario.Name = "tfEmailSecundario";
            this.tfEmailSecundario.Properties.Mask.EditMask = "\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{1,3})+";
            this.tfEmailSecundario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfEmailSecundario.Size = new System.Drawing.Size(443, 20);
            this.tfEmailSecundario.TabIndex = 3;
            // 
            // tfEmailPrincipal
            // 
            this.tfEmailPrincipal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "email_principal", true));
            this.tfEmailPrincipal.Location = new System.Drawing.Point(122, 47);
            this.tfEmailPrincipal.Name = "tfEmailPrincipal";
            this.tfEmailPrincipal.Properties.Mask.EditMask = "\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{1,3})+";
            this.tfEmailPrincipal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfEmailPrincipal.Size = new System.Drawing.Size(443, 20);
            this.tfEmailPrincipal.TabIndex = 2;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "Informe o Email principal";
            this.validador.SetValidationRule(this.tfEmailPrincipal, conditionValidationRule8);
            // 
            // tfTelCelular
            // 
            this.tfTelCelular.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "telefone_celular", true));
            this.tfTelCelular.Location = new System.Drawing.Point(408, 24);
            this.tfTelCelular.Name = "tfTelCelular";
            this.tfTelCelular.Properties.Mask.EditMask = "(\\(11\\)[9][0-9]{4}-[0-9]{4})|(\\(1[2-9]\\) [5-9][0-9]{3}-[0-9]{4})|(\\([2-9][1-9]\\) " +
    "[5-9][0-9]{3}-[0-9]{4})";
            this.tfTelCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfTelCelular.Size = new System.Drawing.Size(157, 20);
            this.tfTelCelular.TabIndex = 1;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule9.ErrorText = "Informe o contato de telefone celular";
            this.validador.SetValidationRule(this.tfTelCelular, conditionValidationRule9);
            // 
            // tfTelFixo
            // 
            this.tfTelFixo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "telefone_fixo", true));
            this.tfTelFixo.Location = new System.Drawing.Point(122, 24);
            this.tfTelFixo.Name = "tfTelFixo";
            this.tfTelFixo.Properties.Mask.EditMask = "(99)0000-0000";
            this.tfTelFixo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tfTelFixo.Size = new System.Drawing.Size(157, 20);
            this.tfTelFixo.TabIndex = 0;
            conditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule10.ErrorText = "Informe o contato de telefone fixo";
            this.validador.SetValidationRule(this.tfTelFixo, conditionValidationRule10);
            // 
            // grpInfoBasica
            // 
            this.grpInfoBasica.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpInfoBasica.AppearanceCaption.Options.UseFont = true;
            this.grpInfoBasica.Controls.Add(this.labelControl1);
            this.grpInfoBasica.Controls.Add(this.ckIsento);
            this.grpInfoBasica.Controls.Add(this.tfNome);
            this.grpInfoBasica.Controls.Add(this.tfDocumento);
            this.grpInfoBasica.Controls.Add(this.tfInscricao);
            this.grpInfoBasica.Controls.Add(this.labelControl3);
            this.grpInfoBasica.Controls.Add(this.labelControl2);
            this.grpInfoBasica.Location = new System.Drawing.Point(5, 5);
            this.grpInfoBasica.Name = "grpInfoBasica";
            this.grpInfoBasica.Size = new System.Drawing.Size(574, 96);
            this.grpInfoBasica.TabIndex = 0;
            this.grpInfoBasica.Text = "INFORMAÇÕES BÁSICAS";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "NOME COMPLETO:";
            // 
            // ckIsento
            // 
            this.ckIsento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "isento_ICMS", true));
            this.ckIsento.Location = new System.Drawing.Point(402, 70);
            this.ckIsento.Name = "ckIsento";
            this.ckIsento.Properties.Caption = "ISENTO INSC. ESTADUAL";
            this.ckIsento.Size = new System.Drawing.Size(167, 19);
            this.ckIsento.TabIndex = 3;
            this.ckIsento.CheckedChanged += new System.EventHandler(this.ckIsento_CheckedChanged);
            // 
            // tfNome
            // 
            this.tfNome.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "nome_completo", true));
            this.tfNome.Location = new System.Drawing.Point(122, 24);
            this.tfNome.Name = "tfNome";
            this.tfNome.Size = new System.Drawing.Size(443, 20);
            this.tfNome.TabIndex = 0;
            conditionValidationRule11.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule11.ErrorText = "Informe o nome completo";
            this.validador.SetValidationRule(this.tfNome, conditionValidationRule11);
            // 
            // tfDocumento
            // 
            this.tfDocumento.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "documento", true));
            this.tfDocumento.Location = new System.Drawing.Point(122, 47);
            this.tfDocumento.Name = "tfDocumento";
            this.tfDocumento.Size = new System.Drawing.Size(274, 20);
            this.tfDocumento.TabIndex = 1;
            conditionValidationRule12.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule12.ErrorText = "Informe o cpf/cnpj do cliente";
            this.validador.SetValidationRule(this.tfDocumento, conditionValidationRule12);
            // 
            // tfInscricao
            // 
            this.tfInscricao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "inscricao_rg", true));
            this.tfInscricao.Location = new System.Drawing.Point(122, 70);
            this.tfInscricao.Name = "tfInscricao";
            this.tfInscricao.Size = new System.Drawing.Size(274, 20);
            this.tfInscricao.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(110, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "INSC. ESTADUAL / RG:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "CPF/CNPJ:";
            // 
            // tfTotalBens
            // 
            this.tfTotalBens.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "valor_total", true));
            this.tfTotalBens.Location = new System.Drawing.Point(933, 9);
            this.tfTotalBens.Name = "tfTotalBens";
            this.tfTotalBens.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfTotalBens.Properties.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.tfTotalBens.Properties.Appearance.Options.UseFont = true;
            this.tfTotalBens.Properties.Appearance.Options.UseForeColor = true;
            this.tfTotalBens.Properties.Mask.EditMask = "c";
            this.tfTotalBens.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfTotalBens.Properties.ReadOnly = true;
            this.tfTotalBens.Size = new System.Drawing.Size(137, 20);
            this.tfTotalBens.TabIndex = 3;
            this.tfTotalBens.TabStop = false;
            // 
            // tfTotalCotas
            // 
            this.tfTotalCotas.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "cotas", true));
            this.tfTotalCotas.Location = new System.Drawing.Point(697, 9);
            this.tfTotalCotas.Name = "tfTotalCotas";
            this.tfTotalCotas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfTotalCotas.Properties.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tfTotalCotas.Properties.Appearance.Options.UseFont = true;
            this.tfTotalCotas.Properties.Appearance.Options.UseForeColor = true;
            this.tfTotalCotas.Properties.Mask.EditMask = "n";
            this.tfTotalCotas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfTotalCotas.Properties.ReadOnly = true;
            this.tfTotalCotas.Size = new System.Drawing.Size(146, 20);
            this.tfTotalCotas.TabIndex = 3;
            this.tfTotalCotas.TabStop = false;
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgCliente, "id", true));
            this.tfId.Location = new System.Drawing.Point(97, 9);
            this.tfId.Name = "tfId";
            this.tfId.Properties.Mask.EditMask = "(\\(11\\)[9][0-9]{4}-[0-9]{4})|(\\(1[2-9]\\) [5-9][0-9]{3}-[0-9]{4})|(\\([2-9][1-9]\\) " +
    "[5-9][0-9]{3}-[0-9]{4})";
            this.tfId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(91, 20);
            this.tfId.TabIndex = 3;
            this.tfId.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 12);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(74, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "COD. CLIENTE:";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelControl24.Location = new System.Drawing.Point(848, 12);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(83, 13);
            this.labelControl24.TabIndex = 4;
            this.labelControl24.Text = "TOTAL DE BENS";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl23.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl23.Location = new System.Drawing.Point(601, 12);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(93, 13);
            this.labelControl23.TabIndex = 4;
            this.labelControl23.Text = "TOTAL DE COTAS";
            // 
            // validador
            // 
            this.validador.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelComponentes);
            this.Controls.Add(this.pnBotoes);
            this.Name = "ClienteForm";
            this.Size = new System.Drawing.Size(1083, 590);
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelComponentes)).EndInit();
            this.panelComponentes.ResumeLayout(false);
            this.panelComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelArquivos)).EndInit();
            this.panelArquivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelReferencias)).EndInit();
            this.panelReferencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfRefcomercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfContcomercial.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfRefservicos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfContservicos.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfReftransporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfConttransporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCadastro)).EndInit();
            this.panelCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpEndereco)).EndInit();
            this.grpEndereco.ResumeLayout(false);
            this.grpEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservacoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgBairros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpContato)).EndInit();
            this.grpContato.ResumeLayout(false);
            this.grpContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailSecundario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfEmailPrincipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTelCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTelFixo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfoBasica)).EndInit();
            this.grpInfoBasica.ResumeLayout(false);
            this.grpInfoBasica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckIsento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfInscricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotalBens.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfTotalCotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgCliente;
        private DevExpress.XtraEditors.PanelControl pnBotoes;
        private DevExpress.XtraEditors.PanelControl panelComponentes;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit tfNome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.RadioGroup grpTipo;
        private DevExpress.XtraEditors.PanelControl panelCadastro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfInscricao;
        private DevExpress.XtraEditors.CheckEdit ckIsento;
        private DevExpress.XtraEditors.GroupControl grpInfoBasica;
        private DevExpress.XtraEditors.GroupControl grpContato;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tfTelCelular;
        private DevExpress.XtraEditors.TextEdit tfTelFixo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tfEmailPrincipal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tfEmailSecundario;
        private DevExpress.XtraEditors.GroupControl grpEndereco;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCidade;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.SearchLookUpEdit cbEndereco;
        public DevExpress.XtraEditors.SearchLookUpEdit cbBairro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.TextEdit tfComplemento;
        private DevExpress.XtraEditors.TextEdit tfCep;
        private DevExpress.XtraEditors.TextEdit tfNumero;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit tfRefcomercial;
        private DevExpress.XtraEditors.TextEdit tfContcomercial;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit tfRefservicos;
        private DevExpress.XtraEditors.TextEdit tfContservicos;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit tfReftransporte;
        private DevExpress.XtraEditors.TextEdit tfConttransporte;
        private DevExpress.XtraEditors.MemoEdit tfObservacoes;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.PanelControl panelReferencias;
        private DevExpress.XtraEditors.SearchLookUpEdit cbEstados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private System.Windows.Forms.BindingSource bdgEstados;
        private System.Windows.Forms.BindingSource bdgCidades;
        private System.Windows.Forms.BindingSource bdgBairros;
        private System.Windows.Forms.BindingSource bdgEnderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coluf;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_ibge;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn col_cidade;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colarea;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_bairro;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cidades;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colcep;
        private DevExpress.XtraGrid.Columns.GridColumn col_endereco;
        private DevExpress.XtraGrid.Columns.GridColumn colbairro_id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validador;
        private DevExpress.XtraEditors.SimpleButton btnCadEndereco;
        private DevExpress.XtraEditors.SimpleButton btnCadBairro;
        private BotaoNovo btnNovo;
        private BotaoSair btnSair;
        private BotaoEditar btnEditar;
        private BotaoEditar btnSalvar;
        private DevExpress.XtraEditors.PanelControl panelArquivos;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.TextEdit tfTotalBens;
        private DevExpress.XtraEditors.TextEdit tfTotalCotas;
        private ArquivosForm arquivosFormCli;
        private System.Windows.Forms.Button button1;
        private BotaoImprimir btnImprimirContrato;
    }
}
