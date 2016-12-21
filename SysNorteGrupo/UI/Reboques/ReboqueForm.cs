using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using EntitiesGrupo;
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
        //private reboque reboque_instc = null;
        private Color backColor = ConfigSistema.backColorFoco;
        private CustomValidationRuleDataAgendamento cVRDA;

        public ReboqueForm(List<reboque> reb)
        {
            //reboque_instc = reb;
            InitializeComponent();

            conn = GerenteDeConexoes.conexaoServico();

            //arquivosFormReb.conn = conn;

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
                if (reb == null)
                {
                    pnInformacoes.Enabled = false;

                    bdgReboqueLista.DataSource = new List<reboque>();
                    bdgReboqueLista.Add(new reboque() { data_ativacao = conn.retornaDataHoraLocal().Date.AddDays(1) });
                }
                else
                {
                    bdgReboqueLista.DataSource = reb;
                    bdgReboqueLista.MoveFirst();

                    pnInformacoes.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = true;
                    ckAgendarCad.Visible = false;
                    pnPrincipal.Enabled = false;

                    //tfDataAgendamento.EditValue = reboque_instc.data_ativacao;
                    bdgCidade.DataSource = conn.listaDeCidadesPorEstado(((reboque)bdgReboqueLista.Current).uf_estado);

                    //arquivosFormReb.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_REBOQUES(), ((reboque)bdgReboqueLista.Current).id);
                    //arquivosFormReb.executaBusca();
                    //arquivosFormReb.Enabled = true;

                    btnEditar.Enabled = true;
                    btnInativar.Enabled = false;
                    btnExcluir.Enabled = false;
                }

                
                //((reboque)bdgReboqueLista.Current).id_cidade = 0;

                

                tfDataAgendamento.Properties.MinValue = DateTime.Now.Date.AddDays(1);

                cbCorChassi.EditValue = ((reboque)bdgReboqueLista.Current).cor_chassi;
                cbCorCarroceria.EditValue = ((reboque)bdgReboqueLista.Current).cor_carroceria;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (reb != null)
            {
                bool inativo = false;
                foreach (reboque r in reb)
                {
                    if (r.inativo)
                        inativo = true;
                }
                if (inativo)
                {
                    btnAdicionar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnNovo.Enabled = true;
                    btnInativar.Enabled = false;
                    btnExcluir.Enabled = true;
                }
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
            if (cbCliente.EditValue != null && cbCliente.EditValue != DBNull.Value)
                bdgVeiculo.DataSource = conn.listaDeVeiculosPorIdClienteEInatividade(Convert.ToInt64(cbCliente.EditValue), false);
            else
            {
                bdgVeiculo.Clear();
            }
        }
        private void cbVeiculos_EditValueChanged(object sender, EventArgs e)
        {
            if (cbVeiculos.EditValue != null && cbVeiculos.EditValue != DBNull.Value)
                pnInformacoes.Enabled = true;
            else
                pnInformacoes.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
            Log.createLog(SysEventLog.exited, "formulario de reboques");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(new ReboqueForm(null) { formPrincipal = formPrincipal });
            Log.createLog(SysEventLog.opened, "novo formulario de reboques");
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = XtraMessageBox.Show(String.Format("CONFIRMA INATIVAÇÃO DE TODOS REBOQUES DO VEÍCULO?\n\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO!", tfPlaca.Text),
                    "CADORE TECNOLOGIA",
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

                    //logs
                    foreach (reboque r in (List<reboque>)bdgReboqueLista.DataSource)
                    {
                        Log.createLog(SysEventLog.inatived, String.Format("reboque ID: {0}", r.id));
                    }
                    pnInformacoes.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnInativar.Enabled = false;
                    btnExcluir.Enabled = false;
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
            btnExcluir.Enabled = true;
            bdgReboqueLista.MoveFirst();
            
            //logs
            foreach (reboque r in (List<reboque>)bdgReboqueLista.DataSource)
            {
                Log.createLog(SysEventLog.edited, String.Format("reboque ID: {0}", r.id));
            }

            //arquivosFormReb.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_REBOQUES(), ((reboque)bdgReboqueLista.Current).id);
            //arquivosFormReb.executaBusca();
            //arquivosFormReb.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (cbVeiculos.EditValue == null || Convert.ToInt64(cbVeiculos.EditValue) == 0)
                {
                    XtraMessageBox.Show("INFORME UM VEICULO PARA CONTINUAR!");
                    return;
                }*/

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
                    XtraMessageBox.Show("VOCÊ DEVE INFORMAR AO MENOS UM REBOQUE PARA O VEÍCULO.", "CADORE TECNOLOGIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
                foreach (reboque r in original)
                {

                }

                conn.salvarReboques(original);

                //logs
                foreach (reboque r in (List<reboque>)bdgReboqueLista.DataSource)
                {
                    Log.createLog(SysEventLog.saveEdited, String.Format("reboque ID: {0}", r.id));
                }

                btnSalvar.Enabled = false;
                pnPrincipal.Enabled = false;
                btnEditar.Enabled = true;
                btnInativar.Enabled = false;
                btnExcluir.Enabled = false;
                XtraMessageBox.Show("REBOQUES SALVOS COM SUCESSO PARA O VEÍCULO INDICADO.", "CADORE TECNOLOGIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                

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
            if (cbCorChassi.EditValue != null && cbCorChassi.EditValue != DBNull.Value)
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
            if (cbCorCarroceria.EditValue != null && cbCorCarroceria.EditValue != DBNull.Value)
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
            if (cbEstado.EditValue != null && cbEstado.EditValue != DBNull.Value)
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
                        XtraMessageBox.Show(String.Format("A PLACA {0} JÁ ENCONTRA-SE CADASTRADA. VERIFIQUE!", tfPlaca.Text), "CADORE TECNOLOGIA");
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
                        XtraMessageBox.Show(String.Format("O CHASSI {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfChassi.Text), "CADORE TECNOLOGIA");
                        return;
                    }

                    //verifica renavam
                    if (conn.verificaSeRenavamReboqueEhUnico(tfRenavam.Text, !empty) == false)
                    {
                        XtraMessageBox.Show(String.Format("O RENAVAM {0} JÁ ENCONTRA-SE CADASTRADO. VERIFIQUE!", tfRenavam.Text), "CADORE TECNOLOGIA");
                        return;
                    }

                    //confirma agendamento
                    if (ckAgendarCad.Checked)
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            String.Format("CONFIRMA O AGENDAMENTO DE CADASTRO DESTE VEÍCULO PARA ÀS 00:00 HORAS DO DIA {0}?", tfDataAgendamento.Text),
                            "CADORE TECNOLOGIA", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                            return;
                    }

                    reboque r = (reboque)bdgReboqueLista.Current;

                    r.ordem = bdgReboqueLista.Count;

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
            try
            {
                reboque r = (reboque)bdgReboqueLista.Current;

                if (r.cor_carroceria == null)
                    cbCorCarroceria.EditValue = "";
                else
                    cbCorCarroceria.EditValue = r.cor_carroceria;
                cbCorChassi.EditValue = r.cor_chassi;

                //arquivosFormReb.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_REBOQUES(), ((reboque)bdgReboqueLista.Current).id);
                //arquivosFormReb.executaBusca();
            }
            catch (Exception) { }
        }

        private void tfPlaca_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool empty = Util.textFieldIsEmpty(tfId);
            if (!String.IsNullOrEmpty(tfPlaca.Text) && !conn.verificaSePlacaReboqueEhUnica(tfPlaca.Text, !empty))
            {
                XtraMessageBox.Show(String.Format("A PLACA {0} JÁ ENCONTRA-SE CADASTRADA. VERIFIQUE!", tfPlaca.Text), "CADORE TECNOLOGIA");
                return;
            }      
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = XtraMessageBox.Show(String.Format("CONFIRMA EXCLUSÃO DOS REBOQUES?\n\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO!"),
                    "CADORE TECNOLOGIA",
                    MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                
                    List<reboque> listR = (List<reboque>)bdgReboqueLista.DataSource;
                    foreach (reboque r in listR)
                    {
                        conn.excluiReboquePorId(r.id);
                        Log.createLog(SysEventLog.deleted, String.Format(" reboque ID: {0}", r.id));
                    }
                    
                    bdgReboqueLista.DataSource = conn.listaDeReboquesPorIdVeiculoEInatividade(Convert.ToInt64(cbVeiculos.EditValue), false);
                    bdgReboqueLista.MoveFirst();
                    grdReboques.Refresh();
                    XtraMessageBox.Show("REBOQUES EXCLUIDOS COM SUCESSO!");
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
