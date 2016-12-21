using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using EntitiesGrupo;
using SysFileManager;
using SysNorteGrupo.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WcfLibGrupo;

namespace SysNorteGrupo.UI.Veiculos
{
    public partial class VeiculosForm : XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private veiculo veiculo_instc = null;
        private Color backColor = ConfigSistema.backColorFoco;
        private CustomValidationRuleDataAgendamento cVRDA;

        public VeiculosForm(veiculo vei)
        {
            veiculo_instc = vei;
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            //arquivosForm.conn = this.conn;         

            try
            {
                bdgCor.DataSource = new Cores().listaDeCores();
                bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);
                bdgMarca.DataSource = conn.listaDeMarcas();
                bdgEspecie.DataSource = conn.listaDeEspeciesVeiculos();
                bdgEstado.DataSource = conn.listaDeEstados();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            try
            {                
                setBackColor();
                if(veiculo_instc == null){
                    veiculo_instc = new veiculo();
                }
                else
                {
                    pnPrincipal.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    ckAgendarCad.Visible = false;

                    tfDataAgendamento.EditValue = veiculo_instc.data_ativacao;

                    bdgAnoModelo.DataSource = conn.listaDeAnoModelosPorIdModelo(veiculo_instc.id_modelo_veiculos);
                    bdgCidade.DataSource = conn.listaDeCidadesPorEstado(veiculo_instc.uf_estado);
                    //arquivosForm.DIRETORIO = conn.SUBDIR_VEICULOS() + veiculo_instc.id.ToString() + @"\";
                    //arquivosForm.executaBusca();
                    //arquivosForm.Enabled = true;
                }
                bdgVeiculo.DataSource = (veiculo) veiculo_instc;
                ArrayList arrayList = new ListaAnos().retornaAnos();
                for (int i = 0; i < arrayList.Count; i++ )
                {
                    cbAnoFabricacao.Properties.Items.Add(arrayList[i]);
                }
                tfDataAgendamento.Properties.MinValue = DateTime.Now.Date.AddDays(1);
                if (veiculo_instc.inativo == true)
                {
                    btnEditar.Enabled = false;
                    btnInativar.Enabled = false;
                    btnExcluir.Enabled = true;
                }

                cbCor.EditValue = veiculo_instc.cor_predominante;
            }catch(Exception ex){
                XtraMessageBox.Show(ex.Message);
            }
        }

        #region backColor

        private void setBackColor()
        {
            foreach (Control item in pnPrincipal.Controls)
            {
                backColors(item);
            }

            foreach (GroupControl g in pnInformacoes.Controls)
            {
                foreach(Control item in g.Controls)
                {
                    backColors(item);
                }
            }
        }

        private void backColors(Control item)
        {
            switch (item.GetType().ToString())
            {
                case "DevExpress.XtraEditors.TextEdit": ((TextEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.ComboBoxEdit": ((ComboBoxEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.SearchLookUpEdit": ((SearchLookUpEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.CheckEdit": ((CheckEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.MemoEdit": ((MemoEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
            }
        }

        #endregion

        private void cbCliente_EditValueChanged(object sender, System.EventArgs e)
        {
            if (Convert.ToInt32(cbCliente.EditValue) > 0)
            {
                pnInformacoes.Enabled = true;
            }
            else
            {
                pnInformacoes.Enabled = false;
            }
            //arquivosForm.Enabled = false;
        }

        private void cbCores_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            /*if (e.Column.DisplayFormat.ToString().Equals("preto"))
            {
                e.Column.AppearanceCell.BackColor = Color.FromArgb(0, 0, 0);
            }*/
        }

        private void cbCores_EditValueChanged(object sender, System.EventArgs e)
        {
            if (cbCor.EditValue != null) {                
                ((veiculo)bdgVeiculo.Current).cor_predominante = cbCor.EditValue.ToString();

                Color cor = new Color();                                
                ((List<Cores>)bdgCor.DataSource).ForEach(delegate(Cores c)
                {
                    if (c.nome_cor == cbCor.EditValue.ToString())
                    {
                        cor = (Color)c.id_cor;
                    }
                });

                lbCor.BackColor = cor;
            }
        }

        private void cbMarca_EditValueChanged(object sender, EventArgs e)
        {
            
            bdgModelo.Clear();
            //bdgAnoModelo.Clear();
            cbAnoFabricacao.SelectedIndex = -1;
            tfValor.Text = null;

            if (Convert.ToInt32(cbMarca.EditValue) > 0)
            {
                bdgModelo.DataSource = conn.listaDeModelosPorIdMarca(Convert.ToInt64(cbMarca.EditValue));
            }
        }

        private void cbModelo_EditValueChanged(object sender, EventArgs e)
        {            
            //bdgAnoModelo.Clear();
            tfValor.Text = null;
            cbAnoFabricacao.SelectedIndex = -1;

            if(cbModelo.EditValue.ToString() != null)
            {
                bdgAnoModelo.DataSource = conn.listaDeAnoModelosPorIdModelo(cbModelo.EditValue.ToString());
            }
        }

        private void cbAnoModelo_EditValueChanged(object sender, EventArgs e)
        {
            tfValor.Text = null;
            if (Convert.ToInt32(cbAnoModelo.EditValue) > 0)
            {
                ano_modelo_veiculo amv = conn.recuperaValorPorIdModelo(Convert.ToInt64(cbAnoModelo.EditValue));
                ((veiculo)bdgVeiculo.Current).valor = amv.valor;
                tfValor.Text = amv.valor.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnPrincipal.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnInativar.Enabled = true;
            btnExcluir.Enabled = true;
            Log.createLog(SysEventLog.edited, String.Format("veiculo ID: {0}", tfId.Text));
            //arquivosForm.DIRETORIO = conn.SUBDIR_VEICULOS() + veiculo_instc.id.ToString() + @"\";
            //arquivosForm.executaBusca();
            //arquivosForm.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                    bool vazio = Util.textFieldIsEmpty(tfId);
                    //seta validações
                    setValidations();
                    //valida
                    if(validator.Validate())
                    {       
                        //verifica placa unica
                        if (conn.verificaSePlacaVeiculoEhUnica(tfPlaca.Text, !vazio) == false)
                        {
                            XtraMessageBox.Show(String.Format("A PLACA {0} JÁ ENCONTRA-SE CADASTRADA. VERIFIQUE!", tfPlaca.Text));
                            return;
                        }

                        //verifica chassi unico
                        if (conn.verificaSeNChassiEhUnico(tfChassi.Text, !vazio) == false)
                        {
                            XtraMessageBox.Show(String.Format("O CHASSI {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfChassi.Text));
                            return;
                        }

                        //verifica renavam
                        if (conn.verificaSeRenavamEhUnico(tfRenavam.Text, !vazio) == false)
                        {
                            XtraMessageBox.Show(String.Format("O RENAVAM {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfRenavam.Text));
                            return;
                        }

                        //confirma agendamento
                        if (ckAgendarCad.CheckState == CheckState.Checked)
                        {
                            DialogResult dialogResult = XtraMessageBox.Show(
                                String.Format("CONFIRMA O AGENDAMENTO DE CADASTRO DESTE VEÍCULO PARA ÀS 00:00 HORAS DO DIA {0}?", tfDataAgendamento.Text),
                                "CADORE TECNOLOGIA", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                        //inicia salvamento                
                        veiculo v = ((veiculo)bdgVeiculo.Current);
                        //v.cor_predominante = cbCor.EditValue.ToString();

                        DateTime dataAtiv = conn.retornaDataHoraLocal().Date.AddDays(1);
                        if(ckAgendarCad.CheckState == CheckState.Checked){
                            dataAtiv = tfDataAgendamento.DateTime;
                        }
                        if (vazio)
                        {
                            v.data_ativacao = dataAtiv;
                            v.inativo = false;
                            v.data_cadastro = conn.retornaDataHoraLocal();
                        }
                        long id = Convert.ToInt64(conn.salvarVeiculo(v));
                        tfId.Text = id.ToString();
                        ((veiculo)(bdgVeiculo.DataSource)).id = id;
                        Log.createLog(SysEventLog.saveEdited, String.Format("veiculo ID: {0}", tfId.Text));

                        pnPrincipal.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnInativar.Enabled = false;    
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n" + ex.Message);
                    formPrincipal.adicionarControleNavegacao(null);
                }  
        }

        private void cbEstado_EditValueChanged(object sender, EventArgs e)
        {
            bdgCidade.Clear();
            if(cbEstado.EditValue != null){
                bdgCidade.DataSource = conn.listaDeCidadesPorEstado(cbEstado.Text);
            }
        }

        private void ckAgendarCad_CheckedChanged(object sender, EventArgs e)
        {
            if(ckAgendarCad.CheckState == CheckState.Checked){
                tfDataAgendamento.EditValue = null;
                tfDataAgendamento.Enabled = true;
            }
            else
            {
                tfDataAgendamento.EditValue = null;
                tfDataAgendamento.Enabled = false;
            }
        }

        void setValidations()
        {
            if(ckAgendarCad.CheckState == CheckState.Checked){
                cVRDA = null;
                cVRDA = new CustomValidationRuleDataAgendamento(this) { ErrorText = "Informe a data de agendamento.", ErrorType = ErrorType.Critical };
                validator.SetValidationRule(tfDataAgendamento, cVRDA);
            }
            else
            {
                validator.SetValidationRule(tfDataAgendamento, null);
            }
        }

        public class CustomValidationRuleDataAgendamento : ValidationRule, IDisposable
        {
            VeiculosForm form;
            public void Dispose()
            {
                if (form != null)
                {
                    form.Dispose();
                    form = null;
                }
            }
            public CustomValidationRuleDataAgendamento(VeiculosForm _form)
            {
                form = _form;
            }
            public override bool Validate(Control control, object value)
            {
                string str = form.tfDataAgendamento.Text;
                if(str == null || str == String.Empty){
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }    

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
            Log.createLog(SysEventLog.exited, String.Format("formulario de veiculos"));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(new VeiculosForm(null) { formPrincipal = formPrincipal });
            Log.createLog(SysEventLog.opened, String.Format("novo formulario de veiculos"));
        }

        private void VeiculosForm_Load(object sender, EventArgs e)
        {
            /*try
            {
                bdgCor.DataSource = new Cores().listaDeCores();
                bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);                
                bdgMarca.DataSource = conn.listaDeMarcas();
                bdgEspecie.DataSource = conn.listaDeEspeciesVeiculos();
                bdgEstado.DataSource = conn.listaDeEstados();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }*/
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = XtraMessageBox.Show("CONFIRMA INATIVAÇÃO DO VEICULO DE PLACA " + tfPlaca.Text + "?\n\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO!",
                    "CADORE TECNOLOGIA",
                    MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    veiculo v = (veiculo)bdgVeiculo.Current;
                    //conn.inativarVeiculoCompleto(v);
                    v.inativo = true;
                    v.data_inativacao = conn.retornaDataHoraLocal();
                    conn.salvarVeiculo(v);
                    Log.createLog(SysEventLog.inatived, String.Format("veiculo ID: {0}", tfId.Text));

                    pnPrincipal.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnInativar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n" + ex.Message);
                formPrincipal.adicionarControleNavegacao(null);
            }
        }

        private void tfValor_EditValueChanged(object sender, EventArgs e)
        {
            if(tfValor.EditValue != null){
                decimal valor = Convert.ToDecimal(tfValor.EditValue.ToString().Trim());
                tfCotas.Text = (valor / ConfigSistema.valor_por_cota).ToString();
            }
        }

        private void pnInformacoes_EnabledChanged(object sender, EventArgs e)
        {
            if(Util.textFieldIsEmpty(tfId))
            {
                //arquivosForm.Enabled = false;
            }
            else
            {
                //arquivosForm.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = XtraMessageBox.Show(String.Format("CONFIRMA EXCLUSÃO DO VEICULO?\n\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO!"), "CADORE TECNOLOGIA",
                    MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {

                    veiculo v = (veiculo)bdgVeiculo.DataSource;
                    conn.excluiVeiculoPorId(v.id);
                    Log.createLog(SysEventLog.deleted, String.Format(" veiculo ID: {0}", v.id));

                    XtraMessageBox.Show("VEICULOS EXCLUIDO COM SUCESSO!");
                    formPrincipal.adicionarControleNavegacao(null);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n" + ex.Message);
                formPrincipal.adicionarControleNavegacao(null);
            }
        }
    }
}