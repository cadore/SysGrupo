namespace SysNorteGrupo
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscarCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscarVeiculo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoVeiculo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuscarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovoUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribClientes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribVeiculos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribUsuarios = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnBuscarCliente,
            this.btnNovoCliente,
            this.btnBuscarVeiculo,
            this.btnNovoVeiculo,
            this.btnBuscarUsuario,
            this.btnNovoUsuario,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1020, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.barButtonItem1);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barButtonItem2.Caption = "Arquivos";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lista de Reboques";
            this.barButtonItem3.Glyph = global::SysNorteGrupo.Properties.Resources.BO_List_32x32;
            this.barButtonItem3.Id = 16;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Cadastrar Reboque";
            this.barButtonItem4.Glyph = global::SysNorteGrupo.Properties.Resources.reboque_48;
            this.barButtonItem4.Id = 17;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribClientes,
            this.ribVeiculos,
            this.ribbonPageGroup2,
            this.ribUsuarios,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sistema";
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
            // ribUsuarios
            // 
            this.ribUsuarios.AllowTextClipping = false;
            this.ribUsuarios.ItemLinks.Add(this.btnBuscarUsuario);
            this.ribUsuarios.ItemLinks.Add(this.btnNovoUsuario);
            this.ribUsuarios.Name = "ribUsuarios";
            this.ribUsuarios.ShowCaptionButton = false;
            this.ribUsuarios.Text = "Usuarios";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Arquivos";
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
            // FormPricipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FormPricipal";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FormPricipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FormPricipal_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
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
    }
}