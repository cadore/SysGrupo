using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfLibGrupo;
using EntitiesGrupo;
using System.Collections;
using System.Windows.Documents;
using SysNorteGrupo.Utils;
using DevExpress.XtraEditors.DXErrorProvider;

namespace SysNorteGrupo.UI.Sinistros
{
    public partial class SinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {
        public IServiceGrupo conn;
        public FormPrincipal formPrincipal = null;
        private sinistro sinistro_instc = null;
        private Color backColor = UtilsSistema.backColorFoco;
        public SinistrosForm(sinistro _sinistro_instc)
        {
            sinistro_instc = _sinistro_instc;
            InitializeComponent();
            setBackColor();
            conn = GerenteDeConexoes.iniciaConexao();

            bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);
            bdgReboquesTab.DataSource = new List<reboque>();            
            bdgPagamentos.DataSource = new List<pagamentos_sinistro>();            

            if(sinistro_instc == null){
                sinistro_instc = new sinistro() {data_cadastro = conn.retornaDataHoraLocal(), data_ocorrido = null, data_conclusao = null };
                bdgPagamentos.Add(new pagamentos_sinistro());
                pnControl.Enabled = false;
            }
            else
            {
                arquivosForm.conn = conn;
                arquivosForm.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_SINISTROS(), sinistro_instc.id);
                pnPrincipal.Enabled = false;
            }
            bdgSinistros.DataSource = sinistro_instc;
        }

        #region backColor

        private void setBackColor()
        {
            foreach (GroupControl g in pnControl.Controls)
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
                case "DevExpress.XtraEditors.CalcEdit": ((CalcEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
            }
        }

        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
        }      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SinistrosForm sf = new SinistrosForm(null) { formPrincipal = this.formPrincipal };
            formPrincipal.adicionarControleNavegacao(sf);
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            bdgVeiculos.Clear();
            if (Convert.ToInt32(cbCliente.EditValue) > 0)
            {
                pnControl.Enabled = true;
            }
            else
            {
                pnControl.Enabled = false;
            }
        }

        private void cbVeiculo_EditValueChanged(object sender, EventArgs e)
        {
            bdgReboques.Clear();
            if (Convert.ToInt32(cbVeiculo.EditValue) > 0)
            {
                bdgReboques.DataSource = conn.listaDeReboquesPorIdVeiculo(Convert.ToInt32(cbVeiculo.EditValue), false);
            }
        }

        private void btnAdicionarTab_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbReboque.EditValue) > 0)
            {
                btnAdicionarReb.Enabled = false;
                List<reboque> listReb = (List<reboque>)bdgReboques.DataSource;
                List<reboque> listRebTab = (List<reboque>)bdgReboquesTab.DataSource;
                foreach(reboque r in listReb){
                    if (r.placa.Equals(cbReboque.Text))
                    {
                        r.cotas = r.valor / UtilsSistema.valor_por_cota;
                        if (!listRebTab.Contains(r))
                        {
                            bdgReboquesTab.Add(r);
                        }
                    }
                }
                cbReboque.EditValue = 0;
            }
            
        }

        private void cbReboque_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbReboque.EditValue) > 0)
            {
                List<reboque> listReb = (List<reboque>)bdgReboques.DataSource;
                List<reboque> listRebTab = (List<reboque>)bdgReboquesTab.DataSource;
                foreach (reboque r in listReb)
                {
                    if (r.placa.Equals(cbReboque.Text))
                    {
                        if (!listRebTab.Contains(r))
                        {
                            btnAdicionarReb.Enabled = true;
                        }
                        else
                        {
                            btnAdicionarReb.Enabled = false;
                        }
                    }
                }                
            }
            else
            {
                btnAdicionarReb.Enabled = false;
            }
        }

        private void gridControlReboques_Click(object sender, EventArgs e)
        {
            if(bdgReboquesTab.Current != null){
                btnRemoverReb.Enabled = true;
            }
            else
            {
                btnRemoverReb.Enabled = false;
            }
        }

        private void btnRemoverTab_Click(object sender, EventArgs e)
        {
            bdgReboquesTab.RemoveCurrent();
            cbReboque.EditValue = 0;
            btnRemoverReb.Enabled = false;
        }

        private void ckVeiculo_CheckedChanged(object sender, EventArgs e)
        {
            bdgVeiculos.Clear();
            bdgReboques.Clear();
            bdgReboquesTab.Clear();
            if(ckVeiculo.Checked){
                cbVeiculo.Enabled = true;
                bdgVeiculos.DataSource = conn.listaDeVeiculosPorIdCliente(Convert.ToInt32(cbCliente.EditValue), false);
            }
            else
            {
                cbVeiculo.Enabled = false;
                bdgReboques.DataSource = conn.listaDeReboquesPorIdCliente(Convert.ToInt32(cbCliente.EditValue), false);
            }
        }

        private void ckReboques_CheckedChanged(object sender, EventArgs e)
        {
            cbVeiculo.EditValue = 0;
            cbReboque.EditValue = 0;
            bdgReboquesTab.Clear();
            if (ckReboques.Checked)
            {
                cbReboque.Enabled = true;
                gridControlReboques.Enabled = true;
                if(!ckVeiculo.Checked){
                    bdgReboques.DataSource = conn.listaDeReboquesPorIdCliente(Convert.ToInt32(cbCliente.EditValue), false);
                }
            }
            else
            {
                cbReboque.Enabled = false;
                btnAdicionarReb.Enabled = false;
                btnRemoverReb.Enabled = false;
                gridControlReboques.Enabled = false;
                bdgReboquesTab.Clear();
                gridControlReboques.Update();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnControl.Enabled = true;
        }

        private void btnAdicionarPag_Click(object sender, EventArgs e)
        {
            if (validatorPag.Validate())
            {
                bdgPagamentos.Add(new pagamentos_sinistro());
                bdgPagamentos.MoveLast();

                gridControlPagamentos.Update();
            }
        }

        private void btnRemoverPag_Click(object sender, EventArgs e)
        {
            bdgPagamentos.RemoveCurrent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool tf_vazio = Util.textFieldIsEmpty(tfId);
            long situacao = 0;
            if (ckConcluido.Checked)
            {
                situacao = 1;
            }
            if(situacao == 0){
                ConditionValidationRule conditionValidationRule4 = new ConditionValidationRule();
                conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
                conditionValidationRule4.ErrorText = "Informe a data de finalização";
                validator.SetValidationRule(dtConclusao, conditionValidationRule4);
            }
            else
            {
                validator.SetValidationRule(dtConclusao, null);
            }
            try
            {
                if (ckVeiculo.Checked && cbVeiculo.EditValue == null)
                {
                    MessageBox.Show("Selecione um veiculo.");
                    return;
                }
                if (ckReboques.Checked && bdgReboquesTab.Count < 1)
                {
                    MessageBox.Show("Selecione um reboque.");
                    return;
                }
                if (validator.Validate())
                {
                    if (!ckVeiculo.Checked && !ckReboques.Checked)
                    {
                        MessageBox.Show("Selecione um veiculo ou um reboque.");
                        return;
                    }
                    if(bdgPagamentos.Count <= 0 && ckConcluido.Checked){
                        MessageBox.Show("Adicione no minimo um pagamento.");
                        return;
                    }
                    List<vei_reb_sinistros> listVr = new List<vei_reb_sinistros>();
                    if (ckVeiculo.Checked)
                    {
                        listVr.Add(new vei_reb_sinistros() { id_veiculo = Convert.ToInt64(cbVeiculo.EditValue), id_reboque = 0 });
                    }
                    if (ckReboques.Checked)
                    {
                        foreach (reboque reb in (List<reboque>)bdgReboquesTab.DataSource)
                        {
                            listVr.Add(new vei_reb_sinistros() { id_reboque = reb.id, id_veiculo = 0 });
                        }
                    }                    
                    List<pagamentos_sinistro> listPag = (List<pagamentos_sinistro>)bdgPagamentos.DataSource;
                    List<pagamentos_sinistro> listPagTemp = new List<pagamentos_sinistro>();

                    foreach(pagamentos_sinistro ps in listPag){
                        if (ps.valor == 0 || String.IsNullOrEmpty(ps.observacao))
                        {
                            listPagTemp.Add(ps);
                        }
                    }
                    foreach (pagamentos_sinistro ps_temp in listPagTemp)
                    {
                        listPag.Remove(ps_temp);
                    }
                    sinistro _sinistro = (sinistro)bdgSinistros.Current;
                    _sinistro.data_cadastro = conn.retornaDataHoraLocal();                    
                    _sinistro.situacao_sinistro = situacao;
                    long id = conn.SalvaSinistro(_sinistro, listVr, listPag);
                    tfId.Text = id.ToString();
                    MessageBox.Show("Salvo com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao executar a solicitação.\n"+ex.Message);
            }
        }

        private void ckConcluido_CheckedChanged(object sender, EventArgs e)
        {
            if(ckConcluido.Checked){
                dtConclusao.Enabled = true;
            }
            else
            {
                dtConclusao.Enabled = false;
            }
        }       
    }
}
