﻿namespace SysNorteGrupo
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.btnBuscarCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscarVeiculo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoVeiculo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogs = new DevExpress.XtraBars.BarButtonItem();
            this.btnCriaBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnReiniciaConexao = new DevExpress.XtraBars.BarButtonItem();
            this.btnRelClientesECotas = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfigEnderecoServico = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrefSistema = new DevExpress.XtraBars.BarButtonItem();
            this.btnLimpaPanel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribClientes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribVeiculos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribUsuarios = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnBuscarCliente,
            this.btnNovoCliente,
            this.btnBuscarVeiculo,
            this.btnNovoVeiculo,
            this.btnBuscarUsuario,
            this.btnNovoUsuario,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btnLogs,
            this.btnCriaBackup,
            this.btnReiniciaConexao,
            this.btnRelClientesECotas,
            this.btnConfigEnderecoServico,
            this.btnPrefSistema,
            this.btnLimpaPanel,
            this.barButtonItem1,
            this.barButtonItem7});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 31;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage2});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1020, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.btnLimpaPanel);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Location = new System.Drawing.Point(72, 216);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Ribbon = this.ribbon;
            this.backstageViewControl1.SelectedTab = null;
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 150);
            this.backstageViewControl1.TabIndex = 5;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(189, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(290, 86);
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "backstageViewTabItem1";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Caption = "Lista de Clientes";
            this.btnBuscarCliente.Glyph = global::SysNorteGrupo.Properties.Resources.BO_Resume_32x32;
            this.btnBuscarCliente.Id = 7;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBuscarCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscarCliente_ItemClick);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Caption = "Cadastrar Cliente";
            this.btnNovoCliente.Glyph = global::SysNorteGrupo.Properties.Resources.BO_Customer_32x32;
            this.btnNovoCliente.Id = 8;
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNovoCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClienteForm_ItemClick);
            // 
            // btnBuscarVeiculo
            // 
            this.btnBuscarVeiculo.Caption = "Lista de Veículos";
            this.btnBuscarVeiculo.Glyph = global::SysNorteGrupo.Properties.Resources.BO_List_32x32;
            this.btnBuscarVeiculo.Id = 11;
            this.btnBuscarVeiculo.Name = "btnBuscarVeiculo";
            this.btnBuscarVeiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBuscarVeiculo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscarVeiculo_ItemClick);
            // 
            // btnNovoVeiculo
            // 
            this.btnNovoVeiculo.Caption = "Cadastrar Veículo";
            this.btnNovoVeiculo.Glyph = global::SysNorteGrupo.Properties.Resources.veiculos_48;
            this.btnNovoVeiculo.Id = 12;
            this.btnNovoVeiculo.Name = "btnNovoVeiculo";
            this.btnNovoVeiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNovoVeiculo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoVeiculo_ItemClick);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Caption = "Lista de Usuários";
            this.btnBuscarUsuario.Glyph = global::SysNorteGrupo.Properties.Resources.BO_List_32x32;
            this.btnBuscarUsuario.Id = 13;
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBuscarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuscarUsuarios_ItemClick);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.AccessibleDescription = "";
            this.btnNovoUsuario.Caption = "Cadastrar Usuário";
            this.btnNovoUsuario.Glyph = global::SysNorteGrupo.Properties.Resources.BO_User_32x32;
            this.btnNovoUsuario.Id = 14;
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNovoUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoUsuario_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Arquivos da empresa";
            this.barButtonItem2.Glyph = global::SysNorteGrupo.Properties.Resources.Article_32x32;
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lista de Reboques";
            this.barButtonItem3.Glyph = global::SysNorteGrupo.Properties.Resources.BO_List_32x32;
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Cadastrar Reboque";
            this.barButtonItem4.Glyph = global::SysNorteGrupo.Properties.Resources.reboque_48;
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Cadastrar Sinistro";
            this.barButtonItem5.Glyph = global::SysNorteGrupo.Properties.Resources.IDE_32x32;
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Lista de Sinistros";
            this.barButtonItem6.Glyph = global::SysNorteGrupo.Properties.Resources.Report_32x32;
            this.barButtonItem6.Id = 19;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnLogs
            // 
            this.btnLogs.Caption = "Visualizar Logs";
            this.btnLogs.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogs.Glyph")));
            this.btnLogs.Id = 20;
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLogs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogs_ItemClick);
            // 
            // btnCriaBackup
            // 
            this.btnCriaBackup.Caption = "Criar Backup    DB";
            this.btnCriaBackup.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCriaBackup.Glyph")));
            this.btnCriaBackup.Id = 21;
            this.btnCriaBackup.Name = "btnCriaBackup";
            this.btnCriaBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCriaBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCriaBackup_ItemClick);
            // 
            // btnReiniciaConexao
            // 
            this.btnReiniciaConexao.Caption = "Reiniciar Conexao";
            this.btnReiniciaConexao.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReiniciaConexao.Glyph")));
            this.btnReiniciaConexao.Id = 22;
            this.btnReiniciaConexao.Name = "btnReiniciaConexao";
            this.btnReiniciaConexao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnReiniciaConexao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReiniciaConexao_ItemClick);
            // 
            // btnRelClientesECotas
            // 
            this.btnRelClientesECotas.Caption = "Clientes e Cotas";
            this.btnRelClientesECotas.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRelClientesECotas.Glyph")));
            this.btnRelClientesECotas.Id = 23;
            this.btnRelClientesECotas.Name = "btnRelClientesECotas";
            this.btnRelClientesECotas.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRelClientesECotas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRelClientesECotas_ItemClick);
            // 
            // btnConfigEnderecoServico
            // 
            this.btnConfigEnderecoServico.Caption = "Configurar endereço do Servidor";
            this.btnConfigEnderecoServico.Glyph = ((System.Drawing.Image)(resources.GetObject("btnConfigEnderecoServico.Glyph")));
            this.btnConfigEnderecoServico.Id = 24;
            this.btnConfigEnderecoServico.Name = "btnConfigEnderecoServico";
            this.btnConfigEnderecoServico.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnConfigEnderecoServico.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfigEnderecoServico_ItemClick);
            // 
            // btnPrefSistema
            // 
            this.btnPrefSistema.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnPrefSistema.Caption = "Preferências do Sistema";
            this.btnPrefSistema.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrefSistema.Glyph")));
            this.btnPrefSistema.Id = 25;
            this.btnPrefSistema.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrefSistema.LargeGlyph")));
            this.btnPrefSistema.Name = "btnPrefSistema";
            this.btnPrefSistema.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPrefSistema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrefSistema_ItemClick);
            // 
            // btnLimpaPanel
            // 
            this.btnLimpaPanel.Caption = "Limpar Area de Trabalho";
            this.btnLimpaPanel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLimpaPanel.Glyph")));
            this.btnLimpaPanel.Id = 26;
            this.btnLimpaPanel.Name = "btnLimpaPanel";
            this.btnLimpaPanel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLimpaPanel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLimpaPanel_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 28;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 29;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribClientes,
            this.ribVeiculos,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Geral";
            // 
            // ribClientes
            // 
            this.ribClientes.AllowTextClipping = false;
            this.ribClientes.Glyph = global::SysNorteGrupo.Properties.Resources.BO_Customer_32x32;
            this.ribClientes.ItemLinks.Add(this.btnBuscarCliente);
            this.ribClientes.ItemLinks.Add(this.btnNovoCliente);
            this.ribClientes.Name = "ribClientes";
            this.ribClientes.ShowCaptionButton = false;
            this.ribClientes.Text = "Clientes";
            // 
            // ribVeiculos
            // 
            this.ribVeiculos.AllowTextClipping = false;
            this.ribVeiculos.ItemLinks.Add(this.btnBuscarVeiculo);
            this.ribVeiculos.ItemLinks.Add(this.btnNovoVeiculo);
            this.ribVeiculos.Name = "ribVeiculos";
            this.ribVeiculos.ShowCaptionButton = false;
            this.ribVeiculos.Text = "Veiculos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Reboques";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Sinistros";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Arquivos";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Relatórios";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.btnRelClientesECotas);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Relatórios Clientes";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribUsuarios,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Sistema";
            // 
            // ribUsuarios
            // 
            this.ribUsuarios.AllowTextClipping = false;
            this.ribUsuarios.ItemLinks.Add(this.btnBuscarUsuario);
            this.ribUsuarios.ItemLinks.Add(this.btnNovoUsuario);
            this.ribUsuarios.Name = "ribUsuarios";
            this.ribUsuarios.ShowCaptionButton = false;
            this.ribUsuarios.Text = "Usuarios";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLogs);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Logs";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnCriaBackup);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Banco de dados e Backup";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btnReiniciaConexao);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnConfigEnderecoServico);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Conexão com Servidor";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.btnPrefSistema);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            this.ribbonPageGroup8.Text = "Preferências do Sistema";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 584);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1020, 31);
            // 
            // pnControl
            // 
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(0, 144);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1020, 440);
            this.pnControl.TabIndex = 2;
            this.pnControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnControl_ControlAdded);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = -1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormPricipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FormPricipal_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraBars.BarButtonItem btnBuscarCliente;
        private DevExpress.XtraBars.BarButtonItem btnNovoCliente;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribVeiculos;
        private DevExpress.XtraBars.BarButtonItem btnBuscarVeiculo;
        private DevExpress.XtraBars.BarButtonItem btnNovoVeiculo;
        private DevExpress.XtraBars.BarButtonItem btnBuscarUsuario;
        private DevExpress.XtraBars.BarButtonItem btnNovoUsuario;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.BarButtonItem btnLogs;
        private DevExpress.XtraBars.BarButtonItem btnCriaBackup;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnReiniciaConexao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnRelClientesECotas;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnConfigEnderecoServico;
        private DevExpress.XtraBars.BarButtonItem btnPrefSistema;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnLimpaPanel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}