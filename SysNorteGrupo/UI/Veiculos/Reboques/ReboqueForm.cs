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

namespace SysNorteGrupo.UI.Veiculos.Reboques
{
    public partial class ReboqueForm : XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private reboque reboque_instc = null;
        private Color backColor = UtilsSistema.backColorFoco;
        private CustomValidationRuleDataAgendamento cVRDA;

        public ReboqueForm(reboque reb)
        {
            reboque_instc = reb;
            InitializeComponent();

            conn = GerenteDeConexoes.iniciaConexao();

            arquivosFormReb.conn = conn;

            try
            {
                bdgCor.DataSource = new Cores().listaDeCores();
                bdgCorChassi.DataSource = new Cores().listaDeCores();
                bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);
                bdgEspecie.DataSource = conn.listaDeEspeciesReboques();
                bdgEstado.DataSource = conn.listaDeEstados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                setBackColor();
                if (reboque_instc == null)
                {
                    reboque_instc = new reboque() { data_ativacao = conn.retornaDataHoraLocal().Date.AddDays(1) };
                    pnInformacoes.Enabled = false;
                }
                else
                {
                    pnInformacoes.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    ckAgendarCad.Visible = false;

                    tfDataAgendamento.EditValue = reboque_instc.data_ativacao;
                    bdgCidade.DataSource = conn.listaDeCidadesPorEstado(reboque_instc.uf_estado);

                    arquivosFormReb.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_REBOQUES(), reboque_instc.id);

                    arquivosFormReb.Enabled = true;
                }

                bdgReboqueLista.DataSource = new List<reboque>();
                bdgReboqueLista.Add(reboque_instc);
                //((reboque)bdgReboqueLista.Current).id_cidade = 0;

                ArrayList arrayList = new ListaAnos().retornaAnos();
                for (int i = 0; i < arrayList.Count; i++)
                {
                    cbAnoFabricacao.Properties.Items.Add(arrayList[i]);
                }
                for (int i = 0; i < arrayList.Count; i++)
                {
                    cbAnoModelo.Properties.Items.Add(arrayList[i]);
                }

                tfDataAgendamento.Properties.MinValue = DateTime.Now.Date.AddDays(1);

                cbCorChassi.EditValue = reboque_instc.cor_chassi;
                cbCorCarroceria.EditValue = reboque_instc.cor_carroceria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                foreach (Control item in g.Controls)
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

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbCliente.EditValue) > 0)
                bdgVeiculo.DataSource = conn.listaDeVeiculosPorIdCliente(Convert.ToInt64(cbCliente.EditValue), false);
            else
            {
                bdgVeiculo.Clear();
            }
        }
        private void cbVeiculos_EditValueChanged(object sender, EventArgs e)
        {
            if (cbVeiculos.EditValue != null && Convert.ToInt32(cbVeiculos.EditValue) > 0)
                pnInformacoes.Enabled = true;
            else
                pnInformacoes.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(new ReboqueForm(null) { formPrincipal = formPrincipal });
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = XtraMessageBox.Show(String.Format("CONFIRMA INATIVAÇÃO DE TODOS REBOQUES DO VEÍCULO?\n\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO!", tfPlaca.Text),
                    "SYSNORTE",
                    MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    List<reboque> rbs = (List<reboque>)bdgReboqueLista.DataSource;
                    foreach (reboque r in rbs)
                    {
                        r.inativo = true;
                        r.data_inativacao = conn.retornaDataHoraLocal();
                    }
                    
                    conn.salvarReboques(rbs);
                    //tfId.Text = Convert.ToInt64(conn.salvarReboque(r)).ToString();

                    pnInformacoes.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnInativar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n" + ex.Message);
                formPrincipal.adicionarControleNavegacao(null);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnPrincipal.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnInativar.Enabled = true;

            bdgReboqueLista.MoveFirst();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                long id_cli = Convert.ToInt64(cbCliente.EditValue);
                long id_veic = Convert.ToInt64(cbVeiculos.EditValue);

                List<reboque> original = (List<reboque>)bdgReboqueLista.DataSource;
                List<reboque> paralela = new List<reboque>();
                
                foreach (reboque reb in original)
                {
                    if (String.IsNullOrEmpty(reb.placa))
                        paralela.Add(reb);
                }

                paralela.ForEach(x => original.Remove(x));
                
                grdReboques.Refresh();

                if (original.Count == 0)
                {
                    XtraMessageBox.Show("VOCÊ DEVE INFORMAR AO MENOS UM REBOQUE PARA O VEÍCULO.", "SYSNORTE - GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //remover evento cbCliente e cbveiculo

                    this.cbCliente.EditValueChanged -= new EventHandler(this.cbCliente_EditValueChanged);
                    this.cbVeiculos.EditValueChanged -= new EventHandler(this.cbVeiculos_EditValueChanged);
                    this.bdgReboqueLista.CurrentChanged -= new EventHandler(this.bdgReboqueLista_CurrentChanged);

                    bdgReboqueLista.Clear();
                    bdgReboqueLista.Add(new reboque() { data_ativacao = conn.retornaDataHoraLocal().Date.AddDays(1), id_cliente = id_cli, id_veiculo = id_veic });

                    bdgReboqueLista.MoveLast();

                    this.cbCliente.EditValueChanged += new EventHandler(this.cbCliente_EditValueChanged);
                    this.cbVeiculos.EditValueChanged += new EventHandler(this.cbVeiculos_EditValueChanged);
                    this.bdgReboqueLista.CurrentChanged += new EventHandler(this.bdgReboqueLista_CurrentChanged);

                    return;
                }

                conn.salvarReboques(original);

                XtraMessageBox.Show("REBOQUES SALVOS COM SUCESSO PARA O VEÍCULO INDICADO.", "SYSNORTE - GRUPO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                pnPrincipal.Enabled = false;

                /*bool empty = Util.textFieldIsEmpty(tfId);
                //seta validações
                setValidations();
                //valida
                if (validator.Validate())
                {
                    //verifica placa unica
                    if (conn.verificaSePlacaReboqueEhUnica(tfPlaca.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("A PLACA {0} JÁ ENCONTRA-SE CADASTRADA. VERIFIQUE!", tfPlaca.Text));
                        return;
                    }

                    //verifica chassi unico
                    if (conn.verificaSeNChassiReboqueEhUnico(tfChassi.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("O CHASSI {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfChassi.Text));
                        return;
                    }

                    //verifica renavam
                    if (conn.verificaSeRenavamReboqueEhUnico(tfRenavam.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("O RENAVAM {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfRenavam.Text));
                        return;
                    }

                    //confirma agendamento
                    if (ckAgendarCad.CheckState == CheckState.Checked)
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            String.Format("CONFIRMA O AGENDAMENTO DE CADASTRO DESTE VEÍCULO PARA ÀS 00:00 HORAS DO DIA {0}?", tfDataAgendamento.Text),
                            "SYSNORTE", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            return;
                    }
                    //inicia salvamento                
                    reboque r = ((reboque)bdgReboque.Current);
                    //v.cor_predominante = cbCor.EditValue.ToString();

                    DateTime dataAtiv = conn.retornaDataHoraLocal().Date.AddDays(1);
                    if (ckAgendarCad.CheckState == CheckState.Checked)
                    {
                        dataAtiv = tfDataAgendamento.DateTime;
                    }
                    if (empty)
                    {
                        r.data_ativacao = dataAtiv;
                        r.inativo = false;
                        r.data_cadastro = conn.retornaDataHoraLocal();
                    }

                    tfId.Text = Convert.ToInt64(conn.salvarReboque(r)).ToString();

                    pnInformacoes.Enabled = false;
                    pnPrincipal.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnInativar.Enabled = false;
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n" + ex.Message);
                formPrincipal.adicionarControleNavegacao(null);
            }
        }

        void setValidations()
        {
            if (ckAgendarCad.CheckState == CheckState.Checked)
            {
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
            ReboqueForm form;
            public void Dispose()
            {
                if (form != null)
                {
                    form.Dispose();
                    form = null;
                }
            }
            public CustomValidationRuleDataAgendamento(ReboqueForm _form)
            {
                form = _form;
            }
            public override bool Validate(Control control, object value)
            {
                string str = form.tfDataAgendamento.Text;
                if (str == null || str == String.Empty)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void ckAgendarCad_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAgendarCad.CheckState == CheckState.Checked)
            {
                tfDataAgendamento.EditValue = null;
                tfDataAgendamento.Enabled = true;
            }
            else
            {
                tfDataAgendamento.EditValue = null;
                tfDataAgendamento.Enabled = false;
            }
        }

        private void cbCorChassi_EditValueChanged(object sender, EventArgs e)
        {
            if (cbCorChassi.EditValue != null)
            {
                ((reboque)bdgReboqueLista.Current).cor_chassi = cbCorChassi.EditValue.ToString();

                Color cor = new Color();
                ((List<Cores>)bdgCorChassi.DataSource).ForEach(delegate(Cores c)
                {
                    if (c.nome_cor == cbCorChassi.EditValue.ToString())
                    {
                        cor = (Color)c.id_cor;
                    }
                });

                lbCorChassi.BackColor = cor;
            }
        }

        private void cbCorCarroceria_EditValueChanged(object sender, EventArgs e)
        {
            if (cbCorCarroceria.EditValue != null)
            {
                ((reboque)bdgReboqueLista.Current).cor_carroceria = cbCorCarroceria.EditValue.ToString();

                Color cor = new Color();
                ((List<Cores>)bdgCor.DataSource).ForEach(delegate(Cores c)
                {
                    if (c.nome_cor == cbCorCarroceria.EditValue.ToString())
                    {
                        cor = (Color)c.id_cor;
                    }
                });

                lbCorCarroceria.BackColor = cor;
            }
        }

        private void cbEstado_EditValueChanged(object sender, EventArgs e)
        {
            bdgCidade.Clear();
            if (cbEstado.EditValue != null)
            {
                bdgCidade.DataSource = conn.listaDeCidadesPorEstado(cbEstado.Text);
                //((reboque)bdgReboqueLista.Current).id_cidade = 0;
            }

            //else ((reboque)bdgReboqueLista.Current).id_cidade = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                //bool empty = Util.textFieldIsEmpty(tfId);
                bool empty = Util.textFieldIsEmpty(tfId);
                //seta validações
                setValidations();
                //valida
                if (validator.Validate())
                {
                    //verifica placa unica
                    if (conn.verificaSePlacaReboqueEhUnica(tfPlaca.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("A PLACA {0} JÁ ENCONTRA-SE CADASTRADA. VERIFIQUE!", tfPlaca.Text));
                        return;
                    }

                   /* bool placaPresente = false;
                    ((List<reboque>)bdgReboqueLista.DataSource).ForEach(x => placaPresente = x.placa == tfPlaca.Text ? true : false);

                    if (placaPresente)
                    {
                        XtraMessageBox.Show(String.Format("A PLACA {0} JÁ ENCONTRA-SE INCLUÍDA NA LISTA DE REBOQUES. VERIFIQUE!", tfPlaca.Text));
                        return;
                    }*/

                    //verifica chassi unico
                    if (conn.verificaSeNChassiReboqueEhUnico(tfChassi.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("O CHASSI {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfChassi.Text));
                        return;
                    }

                    //verifica renavam
                    if (conn.verificaSeRenavamReboqueEhUnico(tfRenavam.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("O RENAVAM {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfRenavam.Text));
                        return;
                    }

                    //confirma agendamento
                    if (ckAgendarCad.Checked)
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            String.Format("CONFIRMA O AGENDAMENTO DE CADASTRO DESTE VEÍCULO PARA ÀS 00:00 HORAS DO DIA {0}?", tfDataAgendamento.Text),
                            "SYSNORTE", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            return;
                    }

                    reboque r = (reboque)bdgReboqueLista.Current;

                    DateTime dataAtiv = conn.retornaDataHoraLocal().Date.AddDays(1);
                    if (ckAgendarCad.Checked)
                    {
                        dataAtiv = tfDataAgendamento.DateTime;
                    }
                    if (empty)
                    {
                        r.data_ativacao = dataAtiv;
                        r.inativo = false;
                        r.data_cadastro = conn.retornaDataHoraLocal();
                    }

                    this.cbCliente.EditValueChanged -= new EventHandler(this.cbCliente_EditValueChanged);

                    bdgReboqueLista.Add(new reboque() { data_ativacao = conn.retornaDataHoraLocal().Date.AddDays(1), id_cliente = r.id_cliente, id_veiculo = r.id_veiculo });

                    bdgReboqueLista.MoveLast();

                    cbCorCarroceria.EditValue = null;
                    cbCorChassi.EditValue = null;
                    lbCorCarroceria.BackColor = Color.Transparent;
                    lbCorChassi.BackColor = Color.Transparent;

                    //tfPlaca.Focus();

                    this.cbCliente.EditValueChanged += new EventHandler(this.cbCliente_EditValueChanged);

                    /*pnInformacoes.Enabled = false;
                    pnPrincipal.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnInativar.Enabled = false;*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar executar sua solicitação.\n\n" + ex.Message);
                formPrincipal.adicionarControleNavegacao(null);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (validator.Validate())
            {
                bdgReboqueLista.RemoveCurrent();
                //bdgReboqueLista.Add(new reboque() { data_ativacao = conn.retornaDataHoraLocal().Date.AddDays(1) });
            }
        }

        private void bdgReboqueLista_CurrentChanged(object sender, EventArgs e)
        {
            reboque r = (reboque)bdgReboqueLista.Current;

            cbCorCarroceria.EditValue = r.cor_carroceria;
            cbCorChassi.EditValue = r.cor_chassi;
        }
    }
}
