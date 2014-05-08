using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfLibGrupo;
using EntitiesGrupo;
using System.Windows.Documents;
using SysNorteGrupo.Utils;
using DevExpress.XtraEditors.DXErrorProvider;
using SysNorteGrupo.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;

namespace SysNorteGrupo.UI.Sinistros
{
    public partial class SinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {
        public IServiceGrupo conn;
        public FormPrincipal formPrincipal = null;
        private sinistro sinistro_instc = null;
        private Color backColor = ConfigSistema.backColorFoco;
        private ConditionValidationRule conditionValidationRule4;
        private List<reboque> listRebTab = new List<reboque>();
        public SinistrosForm(sinistro _sinistro_instc)
        {
            sinistro_instc = _sinistro_instc;
            InitializeComponent();
            setBackColor();
            conn = GerenteDeConexoes.conexaoServico();

            bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);
            bdgPagamentos.DataSource = new List<pagamentos_sinistro>();
            bdgPagamentos.Add(new pagamentos_sinistro());
            bdgReboques1.DataSource = new List<reboque>();
            bdgReboques2.DataSource = new List<reboque>();
            bdgReboques3.DataSource = new List<reboque>();

            if(sinistro_instc == null){
                sinistro_instc = new sinistro() {data_cadastro = conn.retornaDataHoraLocal(), data_ocorrido = null, data_conclusao = null };                
                bdgSinistros.DataSource = sinistro_instc;
                pnControl.Enabled = false;
            }
            else
            {
                cbCliente.EditValue = sinistro_instc.id_cliente;
                bdgVeiculos.DataSource = conn.listaDeVeiculosPorIdCliente(sinistro_instc.id_cliente);
                cbVeiculo.EditValue = sinistro_instc.id_veiculo;
                bdgReboques1.DataSource = conn.listaDeReboquesPorIdCliente(sinistro_instc.id_cliente, false);
                if(sinistro_instc.data_conclusao != null){
                    ckConcluido.Checked = true;
                }
                else
                {
                    ckConcluido.Checked = false;
                }
                List<pagamentos_sinistro> listPag = conn.listaDePagamentosSinistrosPorIdSinistro(sinistro_instc.id);
                if(listPag.Count > 0){
                    bdgPagamentos.DataSource = listPag;
                }
                arquivosForm.conn = conn;
                arquivosForm.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_SINISTROS(), sinistro_instc.id);
                arquivosForm.executaBusca();
                pnPrincipal.Enabled = false;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
            }
            if (ckConcluido.Checked)
            {
                btnImprimirRelSinistro.Enabled = true;
            }
            else
            {
                btnImprimirRelSinistro.Enabled = false;
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
            Log.createLog(EventLog.exited, "formulario de pesquisa de sinistros");
        }      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SinistrosForm sf = new SinistrosForm(null) { formPrincipal = this.formPrincipal };
            formPrincipal.adicionarControleNavegacao(sf);
            Log.createLog(EventLog.opened, "novo formulario de sinistros");
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            bdgVeiculos.Clear();
            bdgReboques1.Clear();
            bdgReboques2.Clear();
            bdgReboques3.Clear();
            bdgVeiculos.DataSource = conn.listaDeVeiculosPorIdClienteEInatividade(Convert.ToInt64(cbCliente.EditValue), false);
            bdgReboques1.DataSource = conn.listaDeReboquesPorIdCliente(Convert.ToInt64(cbCliente.EditValue), false);
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
            bdgReboques1.Clear();
            bdgReboques2.Clear();
            bdgReboques3.Clear();
            if (Convert.ToInt32(cbVeiculo.EditValue) > 0)
            {
                bdgReboques1.DataSource = conn.listaDeReboquesPorIdVeiculo(Convert.ToInt32(cbVeiculo.EditValue), false);
            }            
            bdgReboques2.DataSource = new List<reboque>();//conn.listaDeReboquesPorIdVeiculo(Convert.ToInt32(cbVeiculo.EditValue), false);
            bdgReboques3.DataSource = new List<reboque>(); //conn.listaDeReboquesPorIdVeiculo(Convert.ToInt32(cbVeiculo.EditValue), false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnControl.Enabled = true;
            pnPrincipal.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            Log.createLog(EventLog.edited, String.Format("sinistro ID: {0}", tfId.Text));
            arquivosForm.DIRETORIO = String.Format(@"{0}{1}\", conn.SUBDIR_SINISTROS(), sinistro_instc.id);
            arquivosForm.executaBusca();
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
            string mensagem_situacao = "Confirma a edição de sinistro concluido para NÃO concluido?";
            if (ckConcluido.Checked)
            {
                mensagem_situacao = String.Format("Confirma a data de conclusão para dia: {0}?", dtConclusao.Text);
                situacao = 1;
            }
            else
            {
                situacao = 0;
            }
            if(situacao == 1){
                conditionValidationRule4 = new ConditionValidationRule();
                conditionValidationRule4.ConditionOperator = ConditionOperator.IsNotBlank;
                conditionValidationRule4.ErrorText = "Informe a data de finalização";
                validator.SetValidationRule(dtConclusao, conditionValidationRule4);
            }
            else
            {
                if (conditionValidationRule4 == null) conditionValidationRule4 = new ConditionValidationRule();
                conditionValidationRule4.ConditionOperator = ConditionOperator.None;
                validator.SetValidationRule(dtConclusao, null);
            }
            if (validator.Validate())
            {
                try
                {
                    if (bdgPagamentos.Count <= 0 && ckConcluido.Checked)
                    {
                        XtraMessageBox.Show("Adicione no minimo um pagamento.");
                        return;
                    }
                    if (tf_vazio)
                    {
                        DialogResult dr = XtraMessageBox.Show("Confirma a data do ocorrido para dia: " + dtOcorrido.Text + "?", "SYSNORTE", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.Cancel)
                        {
                            dtOcorrido.Focus();
                            return;
                        }
                    }
                    if (sinistro_instc.situacao_sinistro != situacao && ckConcluido.Checked)
                    {
                        DialogResult dr = XtraMessageBox.Show(mensagem_situacao, "SYSNORTE", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.Cancel)
                        {
                            dtConclusao.Focus();
                            return;
                        }
                    }
                    List<pagamentos_sinistro> listPag = (List<pagamentos_sinistro>)bdgPagamentos.DataSource;
                    List<pagamentos_sinistro> listPagTemp = new List<pagamentos_sinistro>();

                    foreach (pagamentos_sinistro ps in listPag)
                    {
                        if (ps.valor == 0 || String.IsNullOrEmpty(ps.observacao))
                        {
                            listPagTemp.Add(ps);
                        }
                    }
                    foreach (pagamentos_sinistro ps_temp in listPagTemp)
                    {
                        listPag.Remove(ps_temp);
                    }
                    decimal total_sinistro = 0;
                    foreach (pagamentos_sinistro ps_soma in listPag)
                    {
                        total_sinistro += ps_soma.valor;
                    }
                    
                    sinistro _sinistro = (sinistro)bdgSinistros.Current;
                    _sinistro.data_cadastro = conn.retornaDataHoraLocal();
                    _sinistro.situacao_sinistro = situacao;
                    _sinistro.id_veiculo = Convert.ToInt64(cbVeiculo.EditValue);

                    if (Convert.ToInt64(cbVeiculo.EditValue) > 0 && !conn.verificaSeVeiculoEstaEmSinistroAtivo(Convert.ToInt64(cbVeiculo.EditValue), !tf_vazio, 0))
                    {
                        XtraMessageBox.Show(string.Format("CONTEM UM SINISTRO EM ABERTO PARA O VEICULO {0}, VERIFIQUE!", cbVeiculo.Text));
                        return;
                    }

                    if (Convert.ToInt64(cbReboque1.EditValue) > 0 && !conn.verificaSeReboqueEstaEmSinistroAtivo(Convert.ToInt64(cbReboque1.EditValue), !tf_vazio, 0, 1))
                    {
                        XtraMessageBox.Show(string.Format("CONTEM UM SINISTRO EM ABERTO PARA O REBOQUE {0}, VERIFIQUE!", cbReboque1.Text));
                        return;
                    }
                    if (Convert.ToInt64(cbReboque2.EditValue) > 0 && !conn.verificaSeReboqueEstaEmSinistroAtivo(Convert.ToInt64(cbReboque2.EditValue), !tf_vazio, 0, 2))
                    {
                        XtraMessageBox.Show(string.Format("CONTEM UM SINISTRO EM ABERTO PARA O REBOQUE {0}, VERIFIQUE!", cbReboque2.Text));
                        return;
                    }
                    if (Convert.ToInt64(cbReboque3.EditValue) > 0 && !conn.verificaSeReboqueEstaEmSinistroAtivo(Convert.ToInt64(cbReboque3.EditValue), !tf_vazio, 0, 3))
                    {
                        XtraMessageBox.Show(string.Format("CONTEM UM SINISTRO EM ABERTO PARA O REBOQUE {0}, VERIFIQUE!", cbReboque3.Text));
                        return;
                    }

                    _sinistro.valor_total = total_sinistro;
                    long id = conn.SalvaSinistro(_sinistro, listPag);
                    tfId.Text = id.ToString();
                    ((sinistro)bdgSinistros.Current).id = id;
                    Log.createLog(EventLog.saveEdited, String.Format("sinistro ID: {0}", id));
                    pnPrincipal.Enabled = false;
                    btnEditar.Enabled = true;
                    if (ckConcluido.Checked)
                    {
                        btnImprimirRelSinistro.Enabled = true;
                    }
                    else
                    {                        
                        btnImprimirRelSinistro.Enabled = false;
                    }
                    btnEditar.Enabled = true;
                    btnSalvar.Enabled = false;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Ocorreu um erro ao executar a solicitação.\n" + ex.Message);
                }
            }
        }

        private void ckConcluido_CheckedChanged(object sender, EventArgs e)
        {
            if(ckConcluido.Checked){
                dtConclusao.Enabled = true;
            }
            else
            {
                dtConclusao.Text = "";
                dtConclusao.Enabled = false;
            }
        }

        private void pnControl_EnabledChanged(object sender, EventArgs e)
        {
            bool flag = Util.textFieldIsEmpty(tfId);
            if(flag){
                gcArquivos.Enabled = false;
            }
            else
            {
                gcArquivos.Enabled = true;
            }
        }

        private void btnImprimirRelSinistro_Click(object sender, EventArgs e)
        {
            RelatorioPagamentosConclusaoSinistro rpcs = new RelatorioPagamentosConclusaoSinistro();
            rpcs.bindingSource.DataSource = listaConclusao();
            RelatorioConclusaoSinistro report = new RelatorioConclusaoSinistro(rpcs);
            report.bdgListaConclusaoSinistro.DataSource = listaFinal();
            report.dataRelatorio.Value = "RELATÓRIO GERADO EM: " + conn.retornaDataHoraLocal();
            report.assinatura.Value = "GERADO POR SYSNORTE TECNOLOGIA";
            foreach(DevExpress.XtraReports.Parameters.Parameter p in report.Parameters){
                p.Visible = false;
            }
            Log.createLog(EventLog.visualized, String.Format("relatorio de conslusão do sinistro ID: {0}", tfId.Text));
            /*PdfExportOptions po = new PdfExportOptions() {ImageQuality = PdfJpegImageQuality.Highest, Compressed = true };
            report.ExportToPdf("C:\\Users\\William\\Desktop\\testePDF.pdf", po);*/

            /*HtmlExportOptions htmlOptions = report.ExportOptions.Html;
            htmlOptions.CharacterSet = "UTF-8";
            htmlOptions.TableLayout = false;
            htmlOptions.RemoveSecondarySymbols = false;
            htmlOptions.Title = "Teste relatório HTML";
            htmlOptions.ExportMode = HtmlExportMode.SingleFilePageByPage;
            htmlOptions.PageBorderColor = Color.Blue;
            htmlOptions.PageBorderWidth = 3;            
            report.ExportToHtml("C:\\Users\\William\\Desktop\\testeHTML.html");*/
            ReportPrintTool tool = new ReportPrintTool(report);              
            tool.ShowRibbonPreviewDialog();
        }
        decimal valor_por_cota = 0;
        List<ConclusaoSinistro> listaConclusao()
        {
            decimal valor_total_sinistro = Convert.ToDecimal(colvalor1.SummaryText.Replace("TOTAL: R$", ""));
            string veiculo_reboques = "";            
            decimal valor_total_dos_bens_sinistrados = 0;
            sinistro ss = (sinistro)bdgSinistros.Current;
            valor_por_cota = valor_total_sinistro / ss.cotas_na_data;
            if (ss.id_veiculo > 0)
            {
                veiculo v = conn.retornaVeiculoPorId(ss.id_veiculo);
                veiculo_reboques = veiculo_reboques + v.placa + " / ";
                valor_total_dos_bens_sinistrados =+ v.valor;
            }
            if (ss.id_reboque1 > 0)
            {
                reboque r = conn.retornaReboquePorId(ss.id_reboque1);
                veiculo_reboques = veiculo_reboques + r.placa + " / ";
                valor_total_dos_bens_sinistrados =+ r.valor;
            }
            if (ss.id_reboque2 > 0)
            {
                reboque r = conn.retornaReboquePorId(ss.id_reboque2);
                veiculo_reboques = veiculo_reboques + r.placa + " / ";
                valor_total_dos_bens_sinistrados =+ r.valor;
            }
            if (ss.id_reboque3 > 0)
            {
                reboque r = conn.retornaReboquePorId(ss.id_reboque3);
                veiculo_reboques = veiculo_reboques + r.placa + " / ";
                valor_total_dos_bens_sinistrados =+ r.valor;
            }

            List<ConclusaoSinistro> lista = new List<ConclusaoSinistro>();
            lista.Add(new ConclusaoSinistro()
            {
                listaPagamentos = listaPag(),
                boletimOcorrencia = tfBO.Text,
                cliente = cbCliente.Text,
                dataOcorrido = dtOcorrido.Text,
                dataConclusao = dtConclusao.Text,
                observacao = tfObservacao.Text,
                veiculoReboquesSinistrados = veiculo_reboques,
                cotasNaData = ss.cotas_na_data,
                totalDeClientes = ss.clientes_no_rateio.ToString(),
                valorPorCota = valor_por_cota,
                valorTotalSinistro = valor_total_sinistro,
                valorTotalDosBensSinistrados = valor_total_dos_bens_sinistrados,
                cotasDosBensSinistrados = (valor_total_dos_bens_sinistrados / ConfigSistema.valor_por_cota).ToString(),
                franquia = (ConfigSistema.franquiaSinistro + "% - R$ " + valor_total_dos_bens_sinistrados / 100 * ConfigSistema.franquiaSinistro).ToString()

            });
            return lista;
        }

        decimal totalParticipacaoCliente = 0;

        List<ReboquesRelatorio> listaReboques(long id_veiculo, DateTime data_ativacao)
        {
            List<ReboquesRelatorio> reboques = new List<ReboquesRelatorio>();
            foreach(reboque r in conn.listaDeReboquesPorIdVeiculoEdataAtivacao(id_veiculo, data_ativacao)){
                decimal cotas = r.valor / ConfigSistema.valor_por_cota;
                reboques.Add(new ReboquesRelatorio()
                { 
                    placa = r.placa,
                    modelo = r.modelo,
                    valor = r.valor,
                    cotas = (cotas).ToString(),
                    participacao = valor_por_cota * cotas
                });
                totalParticipacaoCliente += valor_por_cota * cotas;
            }
            return reboques;
        }

        

        List<VeiculosRelatorio> listaVeiculos(long id_cliente, DateTime data_ativacao)
        {
            List<VeiculosRelatorio> veiculos = new List<VeiculosRelatorio>();
            foreach(veiculo v in conn.listaDeVeiculosPorIdClienteEDataAtivacao(id_cliente, data_ativacao)){
                decimal cotas = v.valor / ConfigSistema.valor_por_cota;
                veiculos.Add(new VeiculosRelatorio() 
                {
                    placa = v.placa, 
                    modelo = conn.retornaModeloPorId(v.id_modelo_veiculos).nome,
                    valor = v.valor,
                    cotas = (cotas).ToString(),
                    participacao = valor_por_cota * cotas,
                    listaReboques = listaReboques(v.id, v.data_ativacao)
                });
                totalParticipacaoCliente += valor_por_cota * cotas;
            }

            return veiculos;
        }

        List<ListaClientesRateio> listaFinal()
        {
            List<ListaClientesRateio> principal = new List<ListaClientesRateio>();
            foreach(cliente c in conn.listaDeClientesPorDataDeAtivacao(dtOcorrido.DateTime)){
                principal.Add(new ListaClientesRateio() { cliente = c.nome_completo, listaVeiculo = listaVeiculos(c.id, c.data_ativacao), totalParticipacao = totalParticipacaoCliente });
            }

            return principal;
        }

        List<PagamentosSinistroRelatorio> listaPag()
        {
            List<PagamentosSinistroRelatorio> listp = new List<PagamentosSinistroRelatorio>();
            foreach(pagamentos_sinistro p in (List<pagamentos_sinistro>)bdgPagamentos.DataSource){
                listp.Add(new PagamentosSinistroRelatorio() { observação = p.observacao, valor = p.valor });
            }
            return listp;
        }       

        private void cbReboque1_EditValueChanged(object sender, EventArgs e)
        {
            List<reboque> listReboque = (List<reboque>)bdgReboques1.DataSource;
            bdgReboques2.Clear();
            bdgReboques3.Clear();
            foreach (reboque r in listReboque)
            {
                if (!r.placa.Equals(cbReboque1.Text))
                {
                    bdgReboques2.Add(r);
                }
            }
        }

        private void cbReboque2_EditValueChanged(object sender, EventArgs e)
        {
            List<reboque> listReboque = (List<reboque>)bdgReboques2.DataSource;
            bdgReboques3.Clear();
            foreach (reboque r in listReboque)
            {
                if (!r.placa.Equals(cbReboque2.Text))
                {
                    bdgReboques3.Add(r);
                }
            }
        }
    }
}