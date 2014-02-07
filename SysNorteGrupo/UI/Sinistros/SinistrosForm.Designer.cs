namespace SysNorteGrupo.UI.Sinistros
{
    partial class SinistrosForm
    {
        private DevExpress.XtraEditors.PanelControl pnBotoes;

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinistrosForm));
            this.pnBotoes = new DevExpress.XtraEditors.PanelControl();
            this.pnControls = new DevExpress.XtraEditors.PanelControl();
            this.gcInfoBasica = new DevExpress.XtraEditors.GroupControl();
            this.btnAdicionar = new DevExpress.XtraEditors.SimpleButton();
            this.cbReboque1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbVeiculo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new SysNorteGrupo.Utils.BotaoSalvar();
            this.btnSair = new SysNorteGrupo.Utils.BotaoSair();
            this.btnNovo = new SysNorteGrupo.Utils.BotaoNovo();
            this.btnEditar = new SysNorteGrupo.Utils.BotaoEditar();
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).BeginInit();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnControls)).BeginInit();
            this.pnControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoBasica)).BeginInit();
            this.gcInfoBasica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVeiculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(155)))));
            this.pnBotoes.Appearance.Options.UseBackColor = true;
            this.pnBotoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnBotoes.Controls.Add(this.btnSalvar);
            this.pnBotoes.Controls.Add(this.btnSair);
            this.pnBotoes.Controls.Add(this.btnNovo);
            this.pnBotoes.Controls.Add(this.btnEditar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(989, 69);
            this.pnBotoes.TabIndex = 0;
            // 
            // pnControls
            // 
            this.pnControls.Controls.Add(this.gcInfoBasica);
            this.pnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnControls.Location = new System.Drawing.Point(0, 69);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(989, 445);
            this.pnControls.TabIndex = 1;
            // 
            // gcInfoBasica
            // 
            this.gcInfoBasica.Controls.Add(this.btnAdicionar);
            this.gcInfoBasica.Controls.Add(this.cbReboque1);
            this.gcInfoBasica.Controls.Add(this.cbVeiculo);
            this.gcInfoBasica.Controls.Add(this.labelControl3);
            this.gcInfoBasica.Controls.Add(this.cbCliente);
            this.gcInfoBasica.Controls.Add(this.labelControl2);
            this.gcInfoBasica.Controls.Add(this.labelControl1);
            this.gcInfoBasica.Location = new System.Drawing.Point(0, 0);
            this.gcInfoBasica.Name = "gcInfoBasica";
            this.gcInfoBasica.Size = new System.Drawing.Size(989, 78);
            this.gcInfoBasica.TabIndex = 0;
            this.gcInfoBasica.Text = "INFORMAÇÕES BÁSICAS";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAdicionar.Appearance.Options.UseFont = true;
            this.btnAdicionar.Appearance.Options.UseForeColor = true;
            this.btnAdicionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdicionar.Image = global::SysNorteGrupo.Properties.Resources.Action_LinkUnlink_Link;
            this.btnAdicionar.Location = new System.Drawing.Point(193, 48);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            // 
            // cbReboque1
            // 
            this.cbReboque1.Location = new System.Drawing.Point(71, 50);
            this.cbReboque1.Name = "cbReboque1";
            this.cbReboque1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbReboque1.Properties.NullText = "";
            this.cbReboque1.Properties.View = this.gridView1;
            this.cbReboque1.Size = new System.Drawing.Size(116, 20);
            this.cbReboque1.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Location = new System.Drawing.Point(868, 24);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbVeiculo.Properties.NullText = "";
            this.cbVeiculo.Properties.View = this.searchLookUpEdit2View;
            this.cbVeiculo.Size = new System.Drawing.Size(116, 20);
            this.cbVeiculo.TabIndex = 2;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "REBOQUE:";
            // 
            // cbCliente
            // 
            this.cbCliente.EditValue = "";
            this.cbCliente.Location = new System.Drawing.Point(71, 24);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCliente.Properties.NullText = "";
            this.cbCliente.Properties.View = this.searchLookUpEdit1View;
            this.cbCliente.Size = new System.Drawing.Size(740, 20);
            this.cbCliente.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(817, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "VEÍCULO:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CLIENTE:";
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
            this.btnSalvar.Size = new System.Drawing.Size(121, 56);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
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
            this.btnSair.Location = new System.Drawing.Point(860, 7);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 56);
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
            this.btnNovo.Location = new System.Drawing.Point(262, 7);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(121, 56);
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
            this.btnEditar.Location = new System.Drawing.Point(135, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 56);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // SinistrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.pnBotoes);
            this.Name = "SinistrosForm";
            this.Size = new System.Drawing.Size(989, 514);
            ((System.ComponentModel.ISupportInitialize)(this.pnBotoes)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnControls)).EndInit();
            this.pnControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInfoBasica)).EndInit();
            this.gcInfoBasica.ResumeLayout(false);
            this.gcInfoBasica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbReboque1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVeiculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.BotaoSalvar btnSalvar;
        private Utils.BotaoSair btnSair;
        private Utils.BotaoNovo btnNovo;
        private Utils.BotaoEditar btnEditar;
        private DevExpress.XtraEditors.PanelControl pnControls;
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
        private DevExpress.XtraEditors.SimpleButton btnAdicionar;
    }
}
