using SysFileManager;
using SysNorteGrupo.UI.Utils.Botoes;
using SysNorteGrupo.Utils;
namespace SysNorteGrupo.UI.Sinistros
{
    partial class SinistrosForm
    {
        private DevExpress.XtraEditors.PanelControl pnBotoes;

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinistrosForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.pnBotoes = new DevExpress.XtraEditors.PanelControl();
            this.btnImprimirRelSinistro = new SysNorteGrupo.UI.Utils.Botoes.BotaoImprimir();
            this.btnSalvar = new SysNorteGrupo.UI.Utils.Botoes.BotaoSalvar();
            this.btnSair = new SysNorteGrupo.UI.Utils.Botoes.BotaoSair();
            this.btnNovo = new SysNorteGrupo.UI.Utils.Botoes.BotaoNovo();
            this.btnEditar = new SysNorteGrupo.UI.Utils.Botoes.BotaoEditar();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.gcArquivos = new DevExpress.XtraEditors.GroupControl();
            this.arquivosForm = new SysFileManager.ArquivosForm();
            this.gcPagamentos = new DevExpress.XtraEditors.GroupControl();
            this.btnRemoverPag = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarPag = new DevExpress.XtraEditors.SimpleButton();
            this.tfObservacaoPag = new DevExpress.XtraEditors.TextEdit();
            this.bdgPagamentos = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfValorPag = new DevExpress.XtraEditors.CalcEdit();
            this.gridControlPagamentos = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colvalor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacao1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_sinistros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInfoBasica = new DevExpress.XtraEditors.GroupControl();
            this.cbReboque3 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgSinistros = new System.Windows.Forms.BindingSource(this.components);
            this.bdgReboques3 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn51 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn52 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn53 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn54 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn58 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn59 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn60 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn61 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn62 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn63 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn64 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn65 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn66 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn67 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn68 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbReboque2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgReboques2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrenavam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colano_modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcor_carroceria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltara = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_especies_reboques = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colano_fabricacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchassi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapacidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcor_chassi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_cadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_ativacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_inativacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinativo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluf_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_veiculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colordem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnome_cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcotas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckConcluido = new DevExpress.XtraEditors.CheckEdit();
            this.tfObservacao = new DevExpress.XtraEditors.MemoEdit();
            this.tfBO = new DevExpress.XtraEditors.TextEdit();
            this.dtConclusao = new DevExpress.XtraEditors.DateEdit();
            this.dtOcorrido = new DevExpress.XtraEditors.DateEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.cbReboque1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgReboques1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbVeiculo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgVeiculos = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpot_cil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_renavam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_chassi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_combustivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_cidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcor_predominante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_especies_veiculos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_modelo_veiculos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_marca_veiculos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_ano_modelo_veiculos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgCliente = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_enderecos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_bairros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.validatorPag = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pnPrincipal = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).BeginInit();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivos)).BeginInit();
            this.gcArquivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPagamentos)).BeginInit();
            this.gcPagamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservacaoPag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValorPag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoBasica)).BeginInit();
            this.gcInfoBasica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSinistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReboques3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReboques2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckConcluido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConclusao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConclusao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOcorrido.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOcorrido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReboques1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVeiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(155)))));
            this.pnBotoes.Appearance.Options.UseBackColor = true;
            this.pnBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnBotoes.Controls.Add(this.btnImprimirRelSinistro);
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnSair);
            this.pnBotoes.Controls.Add(this.btnNovo);
            this.pnBotoes.Controls.Add(this.btnEditar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(848, 60);
            this.pnBotoes.TabIndex = 0;
            // 
            // btnImprimirRelSinistro
            // 
            this.btnImprimirRelSinistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnImprimirRelSinistro.Enabled = false;
            this.btnImprimirRelSinistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirRelSinistro.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnImprimirRelSinistro.ForeColor = System.Drawing.Color.White;
            this.btnImprimirRelSinistro.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirRelSinistro.Image")));
            this.btnImprimirRelSinistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirRelSinistro.Location = new System.Drawing.Point(344, 7);
            this.btnImprimirRelSinistro.Name = "btnImprimirRelSinistro";
            this.btnImprimirRelSinistro.Size = new System.Drawing.Size(177, 44);
            this.btnImprimirRelSinistro.TabIndex = 4;
            this.btnImprimirRelSinistro.Text = "Rel. de Conclusão";
            this.btnImprimirRelSinistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirRelSinistro.UseVisualStyleBackColor = false;
            this.btnImprimirRelSinistro.Click += new System.EventHandler(this.btnImprimirRelSinistro_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(8, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(106, 44);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(739, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 44);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(232, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(106, 44);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(120, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 44);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.gcArquivos);
            this.pnControl.Controls.Add(this.gcPagamentos);
            this.pnControl.Controls.Add(this.gcInfoBasica);
            this.pnControl.Location = new System.Drawing.Point(0, 29);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(848, 513);
            this.pnControl.TabIndex = 2;
            this.pnControl.EnabledChanged += new System.EventHandler(this.pnControl_EnabledChanged);
            // 
            // gcArquivos
            // 
            this.gcArquivos.Controls.Add(this.arquivosForm);
            this.gcArquivos.Location = new System.Drawing.Point(0, 314);
            this.gcArquivos.Name = "gcArquivos";
            this.gcArquivos.Size = new System.Drawing.Size(848, 195);
            this.gcArquivos.TabIndex = 2;
            this.gcArquivos.Text = "ARQUIVOS";
            // 
            // arquivosForm
            // 
            this.arquivosForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arquivosForm.Location = new System.Drawing.Point(2, 21);
            this.arquivosForm.Name = "arquivosForm";
            this.arquivosForm.Size = new System.Drawing.Size(844, 172);
            this.arquivosForm.TabIndex = 2;
            // 
            // gcPagamentos
            // 
            this.gcPagamentos.Controls.Add(this.btnRemoverPag);
            this.gcPagamentos.Controls.Add(this.btnAdicionarPag);
            this.gcPagamentos.Controls.Add(this.tfObservacaoPag);
            this.gcPagamentos.Controls.Add(this.labelControl5);
            this.gcPagamentos.Controls.Add(this.labelControl4);
            this.gcPagamentos.Controls.Add(this.tfValorPag);
            this.gcPagamentos.Controls.Add(this.gridControlPagamentos);
            this.gcPagamentos.Location = new System.Drawing.Point(0, 157);
            this.gcPagamentos.Name = "gcPagamentos";
            this.gcPagamentos.Size = new System.Drawing.Size(848, 157);
            this.gcPagamentos.TabIndex = 1;
            this.gcPagamentos.Text = "PAGAMENTOS DO SINISTRO";
            // 
            // btnRemoverPag
            // 
            this.btnRemoverPag.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoverPag.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRemoverPag.Appearance.Options.UseFont = true;
            this.btnRemoverPag.Appearance.Options.UseForeColor = true;
            this.btnRemoverPag.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRemoverPag.Image = global::SysNorteGrupo.Properties.Resources.State_Validation_Invalid;
            this.btnRemoverPag.Location = new System.Drawing.Point(759, 21);
            this.btnRemoverPag.Name = "btnRemoverPag";
            this.btnRemoverPag.Size = new System.Drawing.Size(84, 23);
            this.btnRemoverPag.TabIndex = 5;
            this.btnRemoverPag.Text = "Remover";
            this.btnRemoverPag.Click += new System.EventHandler(this.btnRemoverPag_Click);
            // 
            // btnAdicionarPag
            // 
            this.btnAdicionarPag.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarPag.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionarPag.Appearance.Options.UseFont = true;
            this.btnAdicionarPag.Appearance.Options.UseForeColor = true;
            this.btnAdicionarPag.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdicionarPag.Image = global::SysNorteGrupo.Properties.Resources.Action_SingleChoiceAction;
            this.btnAdicionarPag.Location = new System.Drawing.Point(625, 21);
            this.btnAdicionarPag.Name = "btnAdicionarPag";
            this.btnAdicionarPag.Size = new System.Drawing.Size(128, 23);
            this.btnAdicionarPag.TabIndex = 4;
            this.btnAdicionarPag.Text = "Adicionar Novo";
            this.btnAdicionarPag.Click += new System.EventHandler(this.btnAdicionarPag_Click);
            // 
            // tfObservacaoPag
            // 
            this.tfObservacaoPag.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPagamentos, "observacao", true));
            this.tfObservacaoPag.Location = new System.Drawing.Point(227, 22);
            this.tfObservacaoPag.Name = "tfObservacaoPag";
            this.tfObservacaoPag.Size = new System.Drawing.Size(392, 20);
            this.tfObservacaoPag.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Observação não pode ser vazia";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.validatorPag.SetValidationRule(this.tfObservacaoPag, conditionValidationRule1);
            // 
            // bdgPagamentos
            // 
            this.bdgPagamentos.DataSource = typeof(EntitiesGrupo.pagamentos_sinistro);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(144, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "OBSERVAÇÕES:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "VALOR:";
            // 
            // tfValorPag
            // 
            this.tfValorPag.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgPagamentos, "valor", true));
            this.tfValorPag.Location = new System.Drawing.Point(48, 22);
            this.tfValorPag.Name = "tfValorPag";
            this.tfValorPag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfValorPag.Properties.Precision = 2;
            this.tfValorPag.Size = new System.Drawing.Size(90, 20);
            this.tfValorPag.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Valor do pagamento deve ser maior que R$0,01";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule2.Value1 = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.validatorPag.SetValidationRule(this.tfValorPag, conditionValidationRule2);
            // 
            // gridControlPagamentos
            // 
            this.gridControlPagamentos.DataSource = this.bdgPagamentos;
            this.gridControlPagamentos.Location = new System.Drawing.Point(5, 45);
            this.gridControlPagamentos.MainView = this.gridView3;
            this.gridControlPagamentos.Name = "gridControlPagamentos";
            this.gridControlPagamentos.Size = new System.Drawing.Size(838, 108);
            this.gridControlPagamentos.TabIndex = 0;
            this.gridControlPagamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colvalor1,
            this.colobservacao1,
            this.colid_sinistros});
            this.gridView3.GridControl = this.gridControlPagamentos;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colvalor1
            // 
            this.colvalor1.Caption = "VALOR";
            this.colvalor1.DisplayFormat.FormatString = "c2";
            this.colvalor1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalor1.FieldName = "valor";
            this.colvalor1.Name = "colvalor1";
            this.colvalor1.OptionsColumn.AllowEdit = false;
            this.colvalor1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor", "TOTAL: {0:C2}")});
            this.colvalor1.Visible = true;
            this.colvalor1.VisibleIndex = 0;
            this.colvalor1.Width = 151;
            // 
            // colobservacao1
            // 
            this.colobservacao1.Caption = "OBSERVAÇÕES";
            this.colobservacao1.FieldName = "observacao";
            this.colobservacao1.Name = "colobservacao1";
            this.colobservacao1.OptionsColumn.AllowEdit = false;
            this.colobservacao1.Visible = true;
            this.colobservacao1.VisibleIndex = 1;
            this.colobservacao1.Width = 801;
            // 
            // colid_sinistros
            // 
            this.colid_sinistros.FieldName = "id_sinistros";
            this.colid_sinistros.Name = "colid_sinistros";
            this.colid_sinistros.OptionsColumn.AllowEdit = false;
            // 
            // gcInfoBasica
            // 
            this.gcInfoBasica.Controls.Add(this.cbReboque3);
            this.gcInfoBasica.Controls.Add(this.cbReboque2);
            this.gcInfoBasica.Controls.Add(this.ckConcluido);
            this.gcInfoBasica.Controls.Add(this.tfObservacao);
            this.gcInfoBasica.Controls.Add(this.tfBO);
            this.gcInfoBasica.Controls.Add(this.dtConclusao);
            this.gcInfoBasica.Controls.Add(this.dtOcorrido);
            this.gcInfoBasica.Controls.Add(this.tfId);
            this.gcInfoBasica.Controls.Add(this.cbReboque1);
            this.gcInfoBasica.Controls.Add(this.cbVeiculo);
            this.gcInfoBasica.Controls.Add(this.labelControl8);
            this.gcInfoBasica.Controls.Add(this.labelControl7);
            this.gcInfoBasica.Controls.Add(this.labelControl12);
            this.gcInfoBasica.Controls.Add(this.labelControl11);
            this.gcInfoBasica.Controls.Add(this.labelControl3);
            this.gcInfoBasica.Controls.Add(this.labelControl2);
            this.gcInfoBasica.Controls.Add(this.labelControl9);
            this.gcInfoBasica.Controls.Add(this.labelControl6);
            this.gcInfoBasica.Controls.Add(this.labelControl10);
            this.gcInfoBasica.Location = new System.Drawing.Point(0, -3);
            this.gcInfoBasica.Name = "gcInfoBasica";
            this.gcInfoBasica.Size = new System.Drawing.Size(848, 161);
            this.gcInfoBasica.TabIndex = 0;
            this.gcInfoBasica.Text = "INFORMAÇÕES BÁSICAS";
            // 
            // cbReboque3
            // 
            this.cbReboque3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "id_reboque3", true));
            this.cbReboque3.Location = new System.Drawing.Point(519, 23);
            this.cbReboque3.Name = "cbReboque3";
            this.cbReboque3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbReboque3.Properties.DataSource = this.bdgReboques3;
            this.cbReboque3.Properties.DisplayMember = "placa";
            this.cbReboque3.Properties.NullText = "";
            this.cbReboque3.Properties.ValueMember = "id";
            this.cbReboque3.Properties.View = this.gridView4;
            this.cbReboque3.Size = new System.Drawing.Size(81, 20);
            this.cbReboque3.TabIndex = 16;
            // 
            // bdgSinistros
            // 
            this.bdgSinistros.DataSource = typeof(EntitiesGrupo.sinistro);
            // 
            // bdgReboques3
            // 
            this.bdgReboques3.DataSource = typeof(EntitiesGrupo.reboque);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn46,
            this.gridColumn47,
            this.gridColumn48,
            this.gridColumn49,
            this.gridColumn50,
            this.gridColumn51,
            this.gridColumn52,
            this.gridColumn53,
            this.gridColumn54,
            this.gridColumn55,
            this.gridColumn56,
            this.gridColumn57,
            this.gridColumn58,
            this.gridColumn59,
            this.gridColumn60,
            this.gridColumn61,
            this.gridColumn62,
            this.gridColumn63,
            this.gridColumn64,
            this.gridColumn65,
            this.gridColumn66,
            this.gridColumn67,
            this.gridColumn68});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn46
            // 
            this.gridColumn46.Caption = "COD.";
            this.gridColumn46.FieldName = "id";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.OptionsColumn.AllowEdit = false;
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 0;
            this.gridColumn46.Width = 159;
            // 
            // gridColumn47
            // 
            this.gridColumn47.FieldName = "id_cliente";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn48
            // 
            this.gridColumn48.FieldName = "renavam";
            this.gridColumn48.Name = "gridColumn48";
            this.gridColumn48.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn49
            // 
            this.gridColumn49.FieldName = "ano_modelo";
            this.gridColumn49.Name = "gridColumn49";
            this.gridColumn49.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn50
            // 
            this.gridColumn50.FieldName = "cor_carroceria";
            this.gridColumn50.Name = "gridColumn50";
            this.gridColumn50.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn51
            // 
            this.gridColumn51.FieldName = "tara";
            this.gridColumn51.Name = "gridColumn51";
            this.gridColumn51.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn52
            // 
            this.gridColumn52.FieldName = "id_especies_reboques";
            this.gridColumn52.Name = "gridColumn52";
            this.gridColumn52.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn53
            // 
            this.gridColumn53.FieldName = "ano_fabricacao";
            this.gridColumn53.Name = "gridColumn53";
            this.gridColumn53.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn54
            // 
            this.gridColumn54.FieldName = "chassi";
            this.gridColumn54.Name = "gridColumn54";
            this.gridColumn54.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn55
            // 
            this.gridColumn55.Caption = "PLACA";
            this.gridColumn55.FieldName = "placa";
            this.gridColumn55.Name = "gridColumn55";
            this.gridColumn55.OptionsColumn.AllowEdit = false;
            this.gridColumn55.Visible = true;
            this.gridColumn55.VisibleIndex = 1;
            this.gridColumn55.Width = 726;
            // 
            // gridColumn56
            // 
            this.gridColumn56.FieldName = "capacidade";
            this.gridColumn56.Name = "gridColumn56";
            this.gridColumn56.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn57
            // 
            this.gridColumn57.FieldName = "cor_chassi";
            this.gridColumn57.Name = "gridColumn57";
            this.gridColumn57.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn58
            // 
            this.gridColumn58.FieldName = "data_cadastro";
            this.gridColumn58.Name = "gridColumn58";
            this.gridColumn58.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn59
            // 
            this.gridColumn59.FieldName = "data_ativacao";
            this.gridColumn59.Name = "gridColumn59";
            this.gridColumn59.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn60
            // 
            this.gridColumn60.FieldName = "data_inativacao";
            this.gridColumn60.Name = "gridColumn60";
            this.gridColumn60.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn61
            // 
            this.gridColumn61.FieldName = "inativo";
            this.gridColumn61.Name = "gridColumn61";
            this.gridColumn61.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn62
            // 
            this.gridColumn62.FieldName = "id_cidade";
            this.gridColumn62.Name = "gridColumn62";
            this.gridColumn62.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn63
            // 
            this.gridColumn63.FieldName = "valor";
            this.gridColumn63.Name = "gridColumn63";
            this.gridColumn63.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn64
            // 
            this.gridColumn64.FieldName = "uf_estado";
            this.gridColumn64.Name = "gridColumn64";
            this.gridColumn64.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn65
            // 
            this.gridColumn65.FieldName = "id_veiculo";
            this.gridColumn65.Name = "gridColumn65";
            this.gridColumn65.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn66
            // 
            this.gridColumn66.FieldName = "ordem";
            this.gridColumn66.Name = "gridColumn66";
            this.gridColumn66.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn67
            // 
            this.gridColumn67.FieldName = "nome_cliente";
            this.gridColumn67.Name = "gridColumn67";
            this.gridColumn67.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn68
            // 
            this.gridColumn68.FieldName = "cotas";
            this.gridColumn68.Name = "gridColumn68";
            this.gridColumn68.OptionsColumn.AllowEdit = false;
            // 
            // cbReboque2
            // 
            this.cbReboque2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "id_reboque2", true));
            this.cbReboque2.Location = new System.Drawing.Point(365, 23);
            this.cbReboque2.Name = "cbReboque2";
            this.cbReboque2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbReboque2.Properties.DataSource = this.bdgReboques2;
            this.cbReboque2.Properties.DisplayMember = "placa";
            this.cbReboque2.Properties.NullText = "";
            this.cbReboque2.Properties.ValueMember = "id";
            this.cbReboque2.Properties.View = this.gridView2;
            this.cbReboque2.Size = new System.Drawing.Size(81, 20);
            this.cbReboque2.TabIndex = 15;
            this.cbReboque2.EditValueChanged += new System.EventHandler(this.cbReboque2_EditValueChanged);
            // 
            // bdgReboques2
            // 
            this.bdgReboques2.DataSource = typeof(EntitiesGrupo.reboque);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_cliente,
            this.colrenavam,
            this.colano_modelo,
            this.colcor_carroceria,
            this.coltara,
            this.colid_especies_reboques,
            this.colano_fabricacao,
            this.colchassi,
            this.colplaca,
            this.colcapacidade,
            this.colcor_chassi,
            this.coldata_cadastro,
            this.coldata_ativacao,
            this.coldata_inativacao,
            this.colinativo,
            this.colid_cidade,
            this.colvalor,
            this.coluf_estado,
            this.colid_veiculo,
            this.colordem,
            this.colnome_cliente,
            this.colcotas});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "COD.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 144;
            // 
            // colid_cliente
            // 
            this.colid_cliente.FieldName = "id_cliente";
            this.colid_cliente.Name = "colid_cliente";
            this.colid_cliente.OptionsColumn.AllowEdit = false;
            // 
            // colrenavam
            // 
            this.colrenavam.FieldName = "renavam";
            this.colrenavam.Name = "colrenavam";
            this.colrenavam.OptionsColumn.AllowEdit = false;
            // 
            // colano_modelo
            // 
            this.colano_modelo.FieldName = "ano_modelo";
            this.colano_modelo.Name = "colano_modelo";
            this.colano_modelo.OptionsColumn.AllowEdit = false;
            // 
            // colcor_carroceria
            // 
            this.colcor_carroceria.FieldName = "cor_carroceria";
            this.colcor_carroceria.Name = "colcor_carroceria";
            this.colcor_carroceria.OptionsColumn.AllowEdit = false;
            // 
            // coltara
            // 
            this.coltara.FieldName = "tara";
            this.coltara.Name = "coltara";
            this.coltara.OptionsColumn.AllowEdit = false;
            // 
            // colid_especies_reboques
            // 
            this.colid_especies_reboques.FieldName = "id_especies_reboques";
            this.colid_especies_reboques.Name = "colid_especies_reboques";
            this.colid_especies_reboques.OptionsColumn.AllowEdit = false;
            // 
            // colano_fabricacao
            // 
            this.colano_fabricacao.FieldName = "ano_fabricacao";
            this.colano_fabricacao.Name = "colano_fabricacao";
            this.colano_fabricacao.OptionsColumn.AllowEdit = false;
            // 
            // colchassi
            // 
            this.colchassi.FieldName = "chassi";
            this.colchassi.Name = "colchassi";
            this.colchassi.OptionsColumn.AllowEdit = false;
            // 
            // colplaca
            // 
            this.colplaca.Caption = "PLACA";
            this.colplaca.FieldName = "placa";
            this.colplaca.Name = "colplaca";
            this.colplaca.OptionsColumn.AllowEdit = false;
            this.colplaca.Visible = true;
            this.colplaca.VisibleIndex = 1;
            this.colplaca.Width = 741;
            // 
            // colcapacidade
            // 
            this.colcapacidade.FieldName = "capacidade";
            this.colcapacidade.Name = "colcapacidade";
            this.colcapacidade.OptionsColumn.AllowEdit = false;
            // 
            // colcor_chassi
            // 
            this.colcor_chassi.FieldName = "cor_chassi";
            this.colcor_chassi.Name = "colcor_chassi";
            this.colcor_chassi.OptionsColumn.AllowEdit = false;
            // 
            // coldata_cadastro
            // 
            this.coldata_cadastro.FieldName = "data_cadastro";
            this.coldata_cadastro.Name = "coldata_cadastro";
            this.coldata_cadastro.OptionsColumn.AllowEdit = false;
            // 
            // coldata_ativacao
            // 
            this.coldata_ativacao.FieldName = "data_ativacao";
            this.coldata_ativacao.Name = "coldata_ativacao";
            this.coldata_ativacao.OptionsColumn.AllowEdit = false;
            // 
            // coldata_inativacao
            // 
            this.coldata_inativacao.FieldName = "data_inativacao";
            this.coldata_inativacao.Name = "coldata_inativacao";
            this.coldata_inativacao.OptionsColumn.AllowEdit = false;
            // 
            // colinativo
            // 
            this.colinativo.FieldName = "inativo";
            this.colinativo.Name = "colinativo";
            this.colinativo.OptionsColumn.AllowEdit = false;
            // 
            // colid_cidade
            // 
            this.colid_cidade.FieldName = "id_cidade";
            this.colid_cidade.Name = "colid_cidade";
            this.colid_cidade.OptionsColumn.AllowEdit = false;
            // 
            // colvalor
            // 
            this.colvalor.FieldName = "valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.OptionsColumn.AllowEdit = false;
            // 
            // coluf_estado
            // 
            this.coluf_estado.FieldName = "uf_estado";
            this.coluf_estado.Name = "coluf_estado";
            this.coluf_estado.OptionsColumn.AllowEdit = false;
            // 
            // colid_veiculo
            // 
            this.colid_veiculo.FieldName = "id_veiculo";
            this.colid_veiculo.Name = "colid_veiculo";
            this.colid_veiculo.OptionsColumn.AllowEdit = false;
            // 
            // colordem
            // 
            this.colordem.FieldName = "ordem";
            this.colordem.Name = "colordem";
            this.colordem.OptionsColumn.AllowEdit = false;
            // 
            // colnome_cliente
            // 
            this.colnome_cliente.FieldName = "nome_cliente";
            this.colnome_cliente.Name = "colnome_cliente";
            this.colnome_cliente.OptionsColumn.AllowEdit = false;
            // 
            // colcotas
            // 
            this.colcotas.FieldName = "cotas";
            this.colcotas.Name = "colcotas";
            this.colcotas.OptionsColumn.AllowEdit = false;
            // 
            // ckConcluido
            // 
            this.ckConcluido.Location = new System.Drawing.Point(3, 49);
            this.ckConcluido.Name = "ckConcluido";
            this.ckConcluido.Properties.Caption = "SINISTRO CONCLUIDO";
            this.ckConcluido.Size = new System.Drawing.Size(136, 19);
            this.ckConcluido.TabIndex = 14;
            this.ckConcluido.CheckedChanged += new System.EventHandler(this.ckConcluido_CheckedChanged);
            // 
            // tfObservacao
            // 
            this.tfObservacao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "observacoes", true));
            this.tfObservacao.Location = new System.Drawing.Point(3, 113);
            this.tfObservacao.Name = "tfObservacao";
            this.tfObservacao.Size = new System.Drawing.Size(830, 41);
            this.tfObservacao.TabIndex = 13;
            this.tfObservacao.UseOptimizedRendering = true;
            // 
            // tfBO
            // 
            this.tfBO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "numero_bo", true));
            this.tfBO.Location = new System.Drawing.Point(514, 72);
            this.tfBO.Name = "tfBO";
            this.tfBO.Size = new System.Drawing.Size(145, 20);
            this.tfBO.TabIndex = 12;
            // 
            // dtConclusao
            // 
            this.dtConclusao.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "data_conclusao", true));
            this.dtConclusao.EditValue = null;
            this.dtConclusao.Enabled = false;
            this.dtConclusao.Location = new System.Drawing.Point(331, 72);
            this.dtConclusao.Name = "dtConclusao";
            this.dtConclusao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtConclusao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtConclusao.Size = new System.Drawing.Size(108, 20);
            this.dtConclusao.TabIndex = 11;
            // 
            // dtOcorrido
            // 
            this.dtOcorrido.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "data_ocorrido", true));
            this.dtOcorrido.EditValue = null;
            this.dtOcorrido.Location = new System.Drawing.Point(111, 72);
            this.dtOcorrido.Name = "dtOcorrido";
            this.dtOcorrido.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOcorrido.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOcorrido.Size = new System.Drawing.Size(108, 20);
            this.dtOcorrido.TabIndex = 10;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe a data do ocorrido";
            this.validator.SetValidationRule(this.dtOcorrido, conditionValidationRule3);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "id", true));
            this.tfId.Location = new System.Drawing.Point(727, 23);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(108, 20);
            this.tfId.TabIndex = 9;
            // 
            // cbReboque1
            // 
            this.cbReboque1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "id_reboque1", true));
            this.cbReboque1.Location = new System.Drawing.Point(211, 23);
            this.cbReboque1.Name = "cbReboque1";
            this.cbReboque1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbReboque1.Properties.DataSource = this.bdgReboques1;
            this.cbReboque1.Properties.DisplayMember = "placa";
            this.cbReboque1.Properties.NullText = "";
            this.cbReboque1.Properties.ValueMember = "id";
            this.cbReboque1.Properties.View = this.gridView1;
            this.cbReboque1.Size = new System.Drawing.Size(81, 20);
            this.cbReboque1.TabIndex = 3;
            this.cbReboque1.EditValueChanged += new System.EventHandler(this.cbReboque1_EditValueChanged);
            // 
            // bdgReboques1
            // 
            this.bdgReboques1.DataSource = typeof(EntitiesGrupo.reboque);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn13, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "COD.";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 132;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "id_cliente";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "renavam";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "ano_modelo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "cor_carroceria";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "tara";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "id_especies_reboques";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "ano_fabricacao";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "chassi";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "PLACA";
            this.gridColumn10.FieldName = "placa";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 368;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "capacidade";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "cor_chassi";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "data_cadastro";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "data_ativacao";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "data_inativacao";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "INATIVO";
            this.gridColumn16.FieldName = "inativo";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 184;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "id_cidade";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "VALOR";
            this.gridColumn18.DisplayFormat.FormatString = "c2";
            this.gridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn18.FieldName = "valor";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 3;
            this.gridColumn18.Width = 177;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "uf_estado";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn20
            // 
            this.gridColumn20.FieldName = "id_veiculo";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "ORDEM";
            this.gridColumn21.FieldName = "ordem";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 2;
            this.gridColumn21.Width = 182;
            // 
            // gridColumn22
            // 
            this.gridColumn22.FieldName = "nome_cliente";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn23
            // 
            this.gridColumn23.FieldName = "cotas";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "id_veiculo", true));
            this.cbVeiculo.Location = new System.Drawing.Point(58, 23);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVeiculo.Properties.DataSource = this.bdgVeiculos;
            this.cbVeiculo.Properties.DisplayMember = "placa";
            this.cbVeiculo.Properties.NullText = "";
            this.cbVeiculo.Properties.ValueMember = "id";
            this.cbVeiculo.Properties.View = this.searchLookUpEdit2View;
            this.cbVeiculo.Size = new System.Drawing.Size(80, 20);
            this.cbVeiculo.TabIndex = 2;
            this.cbVeiculo.EditValueChanged += new System.EventHandler(this.cbVeiculo_EditValueChanged);
            // 
            // bdgVeiculos
            // 
            this.bdgVeiculos.DataSource = typeof(EntitiesGrupo.veiculo);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.colpot_cil,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.colcod_renavam,
            this.colnumero_chassi,
            this.coltipo_combustivel,
            this.colid_cidades,
            this.gridColumn31,
            this.colcor_predominante,
            this.colid_especies_veiculos,
            this.colid_modelo_veiculos,
            this.colid_marca_veiculos,
            this.colid_ano_modelo_veiculos,
            this.colobservacao,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            this.searchLookUpEdit2View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn29, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "COD.";
            this.gridColumn24.FieldName = "id";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 0;
            this.gridColumn24.Width = 124;
            // 
            // gridColumn25
            // 
            this.gridColumn25.FieldName = "id_cliente";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn26
            // 
            this.gridColumn26.FieldName = "tara";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn27
            // 
            this.gridColumn27.FieldName = "capacidade";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.AllowEdit = false;
            // 
            // colpot_cil
            // 
            this.colpot_cil.FieldName = "pot_cil";
            this.colpot_cil.Name = "colpot_cil";
            this.colpot_cil.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "VALOR";
            this.gridColumn28.DisplayFormat.FormatString = "c2";
            this.gridColumn28.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn28.FieldName = "valor";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 2;
            this.gridColumn28.Width = 201;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "PLACA";
            this.gridColumn29.FieldName = "placa";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.OptionsColumn.AllowEdit = false;
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 1;
            this.gridColumn29.Width = 509;
            // 
            // gridColumn30
            // 
            this.gridColumn30.FieldName = "ano_fabricacao";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.OptionsColumn.AllowEdit = false;
            // 
            // colcod_renavam
            // 
            this.colcod_renavam.FieldName = "cod_renavam";
            this.colcod_renavam.Name = "colcod_renavam";
            this.colcod_renavam.OptionsColumn.AllowEdit = false;
            // 
            // colnumero_chassi
            // 
            this.colnumero_chassi.FieldName = "numero_chassi";
            this.colnumero_chassi.Name = "colnumero_chassi";
            this.colnumero_chassi.OptionsColumn.AllowEdit = false;
            // 
            // coltipo_combustivel
            // 
            this.coltipo_combustivel.FieldName = "tipo_combustivel";
            this.coltipo_combustivel.Name = "coltipo_combustivel";
            this.coltipo_combustivel.OptionsColumn.AllowEdit = false;
            // 
            // colid_cidades
            // 
            this.colid_cidades.FieldName = "id_cidades";
            this.colid_cidades.Name = "colid_cidades";
            this.colid_cidades.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn31
            // 
            this.gridColumn31.FieldName = "uf_estado";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            // 
            // colcor_predominante
            // 
            this.colcor_predominante.FieldName = "cor_predominante";
            this.colcor_predominante.Name = "colcor_predominante";
            this.colcor_predominante.OptionsColumn.AllowEdit = false;
            // 
            // colid_especies_veiculos
            // 
            this.colid_especies_veiculos.FieldName = "id_especies_veiculos";
            this.colid_especies_veiculos.Name = "colid_especies_veiculos";
            this.colid_especies_veiculos.OptionsColumn.AllowEdit = false;
            // 
            // colid_modelo_veiculos
            // 
            this.colid_modelo_veiculos.FieldName = "id_modelo_veiculos";
            this.colid_modelo_veiculos.Name = "colid_modelo_veiculos";
            this.colid_modelo_veiculos.OptionsColumn.AllowEdit = false;
            // 
            // colid_marca_veiculos
            // 
            this.colid_marca_veiculos.FieldName = "id_marca_veiculos";
            this.colid_marca_veiculos.Name = "colid_marca_veiculos";
            this.colid_marca_veiculos.OptionsColumn.AllowEdit = false;
            // 
            // colid_ano_modelo_veiculos
            // 
            this.colid_ano_modelo_veiculos.FieldName = "id_ano_modelo_veiculos";
            this.colid_ano_modelo_veiculos.Name = "colid_ano_modelo_veiculos";
            this.colid_ano_modelo_veiculos.OptionsColumn.AllowEdit = false;
            // 
            // colobservacao
            // 
            this.colobservacao.FieldName = "observacao";
            this.colobservacao.Name = "colobservacao";
            this.colobservacao.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "INATIVO";
            this.gridColumn32.FieldName = "inativo";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.OptionsColumn.AllowEdit = false;
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 3;
            this.gridColumn32.Width = 209;
            // 
            // gridColumn33
            // 
            this.gridColumn33.FieldName = "data_cadastro";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn34
            // 
            this.gridColumn34.FieldName = "data_ativacao";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn35
            // 
            this.gridColumn35.FieldName = "data_inativacao";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn36
            // 
            this.gridColumn36.FieldName = "nome_cliente";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn37
            // 
            this.gridColumn37.FieldName = "cotas";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.OptionsColumn.AllowEdit = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(225, 75);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "DATA CONCLUSÃO:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 74);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "DATA OCORRIDO:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(452, 26);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "REBOQUE 3:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(298, 26);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "REBOQUE 2:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(144, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "REBOQUE 1:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "VEÍCULO:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(445, 75);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "NUMERO BO:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(706, 26);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "ID:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(5, 96);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(77, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "OBSERVAÇÕES:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CLIENTE:";
            // 
            // cbCliente
            // 
            this.cbCliente.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgSinistros, "id_cliente", true));
            this.cbCliente.EditValue = "";
            this.cbCliente.Location = new System.Drawing.Point(57, 3);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCliente.Properties.DataSource = this.bdgCliente;
            this.cbCliente.Properties.DisplayMember = "nome_completo";
            this.cbCliente.Properties.NullText = "";
            this.cbCliente.Properties.ValueMember = "id";
            this.cbCliente.Properties.View = this.searchLookUpEdit1View;
            this.cbCliente.Size = new System.Drawing.Size(551, 20);
            this.cbCliente.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule4.ErrorText = "Selecione um cliente";
            conditionValidationRule4.Value1 = ((long)(0));
            this.validator.SetValidationRule(this.cbCliente, conditionValidationRule4);
            this.cbCliente.EditValueChanged += new System.EventHandler(this.cbCliente_EditValueChanged);
            // 
            // bdgCliente
            // 
            this.bdgCliente.DataSource = typeof(EntitiesGrupo.cliente);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn38,
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
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn41,
            this.gridColumn42,
            this.gridColumn43,
            this.colid_enderecos,
            this.colid_bairros,
            this.colid_estados,
            this.gridColumn44,
            this.gridColumn45,
            this.colvalor_total});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "COD.";
            this.gridColumn38.FieldName = "id";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.OptionsColumn.AllowEdit = false;
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 0;
            this.gridColumn38.Width = 94;
            // 
            // colnome_completo
            // 
            this.colnome_completo.Caption = "NOME COMPLETO";
            this.colnome_completo.FieldName = "nome_completo";
            this.colnome_completo.Name = "colnome_completo";
            this.colnome_completo.OptionsColumn.AllowEdit = false;
            this.colnome_completo.Visible = true;
            this.colnome_completo.VisibleIndex = 1;
            this.colnome_completo.Width = 384;
            // 
            // coltipo_cliente
            // 
            this.coltipo_cliente.FieldName = "tipo_cliente";
            this.coltipo_cliente.Name = "coltipo_cliente";
            this.coltipo_cliente.OptionsColumn.AllowEdit = false;
            // 
            // coldocumento
            // 
            this.coldocumento.Caption = "DOCUMENTO";
            this.coldocumento.FieldName = "documento";
            this.coldocumento.Name = "coldocumento";
            this.coldocumento.OptionsColumn.AllowEdit = false;
            this.coldocumento.Visible = true;
            this.coldocumento.VisibleIndex = 2;
            this.coldocumento.Width = 248;
            // 
            // colinscricao_rg
            // 
            this.colinscricao_rg.Caption = "INSCRIÇÃO/RG";
            this.colinscricao_rg.FieldName = "inscricao_rg";
            this.colinscricao_rg.Name = "colinscricao_rg";
            this.colinscricao_rg.OptionsColumn.AllowEdit = false;
            this.colinscricao_rg.Visible = true;
            this.colinscricao_rg.VisibleIndex = 3;
            this.colinscricao_rg.Width = 177;
            // 
            // colisento_ICMS
            // 
            this.colisento_ICMS.FieldName = "isento_ICMS";
            this.colisento_ICMS.Name = "colisento_ICMS";
            this.colisento_ICMS.OptionsColumn.AllowEdit = false;
            // 
            // coltelefone_fixo
            // 
            this.coltelefone_fixo.FieldName = "telefone_fixo";
            this.coltelefone_fixo.Name = "coltelefone_fixo";
            this.coltelefone_fixo.OptionsColumn.AllowEdit = false;
            // 
            // coltelefone_celular
            // 
            this.coltelefone_celular.FieldName = "telefone_celular";
            this.coltelefone_celular.Name = "coltelefone_celular";
            this.coltelefone_celular.OptionsColumn.AllowEdit = false;
            // 
            // colemail_principal
            // 
            this.colemail_principal.FieldName = "email_principal";
            this.colemail_principal.Name = "colemail_principal";
            this.colemail_principal.OptionsColumn.AllowEdit = false;
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
            // gridColumn39
            // 
            this.gridColumn39.FieldName = "data_cadastro";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn40
            // 
            this.gridColumn40.FieldName = "data_ativacao";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn41
            // 
            this.gridColumn41.FieldName = "data_inativacao";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "INATIVO";
            this.gridColumn42.FieldName = "inativo";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.OptionsColumn.AllowEdit = false;
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 4;
            this.gridColumn42.Width = 140;
            // 
            // gridColumn43
            // 
            this.gridColumn43.FieldName = "id_cidades";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.OptionsColumn.AllowEdit = false;
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
            // colid_estados
            // 
            this.colid_estados.FieldName = "id_estados";
            this.colid_estados.Name = "colid_estados";
            this.colid_estados.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn44
            // 
            this.gridColumn44.FieldName = "uf_estado";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn45
            // 
            this.gridColumn45.FieldName = "cotas";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.OptionsColumn.AllowEdit = false;
            // 
            // colvalor_total
            // 
            this.colvalor_total.FieldName = "valor_total";
            this.colvalor_total.Name = "colvalor_total";
            this.colvalor_total.OptionsColumn.AllowEdit = false;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Controls.Add(this.pnControl);
            this.pnPrincipal.Controls.Add(this.labelControl1);
            this.pnPrincipal.Controls.Add(this.cbCliente);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 60);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(848, 538);
            this.pnPrincipal.TabIndex = 3;
            // 
            // SinistrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnBotoes);
            this.Name = "SinistrosForm";
            this.Size = new System.Drawing.Size(848, 598);
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcArquivos)).EndInit();
            this.gcArquivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPagamentos)).EndInit();
            this.gcPagamentos.ResumeLayout(false);
            this.gcPagamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservacaoPag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfValorPag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoBasica)).EndInit();
            this.gcInfoBasica.ResumeLayout(false);
            this.gcInfoBasica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSinistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReboques3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReboques2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckConcluido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfObservacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfBO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConclusao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtConclusao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOcorrido.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOcorrido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgReboques1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVeiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPrincipal)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BotaoSalvar btnSalvar;
        private BotaoSair btnSair;
        private BotaoNovo btnNovo;
        private BotaoEditar btnEditar;
        private DevExpress.XtraEditors.GroupControl gcInfoBasica;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbReboque1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbVeiculo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private System.Windows.Forms.BindingSource bdgReboques1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private System.Windows.Forms.BindingSource bdgVeiculos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn colpot_cil;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_renavam;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_chassi;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_combustivel;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cidades;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn colcor_predominante;
        private DevExpress.XtraGrid.Columns.GridColumn colid_especies_veiculos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_modelo_veiculos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_marca_veiculos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_ano_modelo_veiculos;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private System.Windows.Forms.BindingSource bdgCliente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn colid_enderecos;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bairros;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estados;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_total;
        private DevExpress.XtraEditors.GroupControl gcPagamentos;
        private DevExpress.XtraGrid.GridControl gridControlPagamentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarPag;
        private DevExpress.XtraEditors.TextEdit tfObservacaoPag;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CalcEdit tfValorPag;
        private System.Windows.Forms.BindingSource bdgPagamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor1;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacao1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_sinistros;
        private DevExpress.XtraEditors.SimpleButton btnRemoverPag;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorPag;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtConclusao;
        private DevExpress.XtraEditors.DateEdit dtOcorrido;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tfBO;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private ArquivosForm arquivosForm;
        private DevExpress.XtraEditors.GroupControl gcArquivos;
        private DevExpress.XtraEditors.MemoEdit tfObservacao;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.BindingSource bdgSinistros;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.CheckEdit ckConcluido;
        private DevExpress.XtraEditors.PanelControl pnPrincipal;
        private BotaoImprimir btnImprimirRelSinistro;
        private DevExpress.XtraEditors.SearchLookUpEdit cbReboque3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SearchLookUpEdit cbReboque2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.BindingSource bdgReboques3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn51;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn52;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn53;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn54;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn55;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn56;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn57;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn58;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn59;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn60;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn61;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn62;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn63;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn64;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn65;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn66;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn67;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn68;
        private System.Windows.Forms.BindingSource bdgReboques2;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colrenavam;
        private DevExpress.XtraGrid.Columns.GridColumn colano_modelo;
        private DevExpress.XtraGrid.Columns.GridColumn colcor_carroceria;
        private DevExpress.XtraGrid.Columns.GridColumn coltara;
        private DevExpress.XtraGrid.Columns.GridColumn colid_especies_reboques;
        private DevExpress.XtraGrid.Columns.GridColumn colano_fabricacao;
        private DevExpress.XtraGrid.Columns.GridColumn colchassi;
        private DevExpress.XtraGrid.Columns.GridColumn colplaca;
        private DevExpress.XtraGrid.Columns.GridColumn colcapacidade;
        private DevExpress.XtraGrid.Columns.GridColumn colcor_chassi;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_cadastro;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_ativacao;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_inativacao;
        private DevExpress.XtraGrid.Columns.GridColumn colinativo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_cidade;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor;
        private DevExpress.XtraGrid.Columns.GridColumn coluf_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colid_veiculo;
        private DevExpress.XtraGrid.Columns.GridColumn colordem;
        private DevExpress.XtraGrid.Columns.GridColumn colnome_cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colcotas;
        private System.ComponentModel.IContainer components;
    }
}
