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
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.UI.Sinistros
{
    public partial class BuscaSinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {
        private int situacao = -1; // -1 todos, 0 em andamento, 1 concluidos
        public IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        public BuscaSinistrosForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            bdgClientes.DataSource = conn.listaDeTodosClientes();
            bdgVeiculos.DataSource = conn.listaDeTodosVeiculos();
            bdgReboques.DataSource = conn.listaDeTodosReboques();
        }
        private void executaBusca()
        {
            List<sinistro> listSinOrig = new List<sinistro>();
            try
            {
                if (String.IsNullOrEmpty(cbCliente.Text) && String.IsNullOrEmpty(cbVeiculo.Text) && String.IsNullOrEmpty(cbReboque.Text))
                {
                    if (situacao == -1)
                    {
                        listSinOrig = conn.listaDeTodosSinistros();
                    }
                    else
                    {
                        listSinOrig = conn.listaDeSinistrosPorSituacao(situacao);
                    }
                    preencheLista(listSinOrig);
                }
                else
                {
                    if (cbReboque.EditValue != null && Convert.ToInt32(cbReboque.EditValue) > 0)
                    {
                        if (situacao == -1)
                        {
                            listSinOrig = conn.listaDeSinistroPorIdReboque(Convert.ToInt64(cbReboque.EditValue));
                        }
                        else
                        {
                            listSinOrig = conn.listaDeSinistroPorIdReboqueESituacao(Convert.ToInt64(cbReboque.EditValue), situacao);
                        }
                        preencheLista(listSinOrig);
                        return;
                    }
                    if (cbVeiculo.EditValue != null && Convert.ToInt32(cbVeiculo.EditValue) > 0)
                    {
                        if (situacao == -1)
                        {
                            listSinOrig = conn.listaDeSinistroPorIdVeiculo(Convert.ToInt64(cbVeiculo.EditValue));
                        }
                        else
                        {
                            listSinOrig = conn.listaDeSinistroPorIdVeiculoESituacao(Convert.ToInt64(cbVeiculo.EditValue), situacao);
                        }
                        preencheLista(listSinOrig);
                        return;
                    }
                    if (cbCliente.EditValue != null && Convert.ToInt32(cbCliente.EditValue) > 0)
                    {
                        if(situacao == -1){
                            listSinOrig = conn.listaDeSinistrosPorIdCliente(Convert.ToInt32(cbCliente.EditValue));
                        }
                        else
                        {
                            listSinOrig = conn.listaDeSinistrosPorIdClienteESituacao(Convert.ToInt32(cbCliente.EditValue), situacao);
                        }
                        preencheLista(listSinOrig);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Erro ao executar a busca.\n"+ex.Message);
            }
        }

        private void preencheLista(List<sinistro> listSinOrig)
        {
            List<sinistro> listSin = new List<sinistro>();
            foreach (sinistro s in listSinOrig)
            {
                if (s.situacao_sinistro == 0)
                {
                    s.situacao = "EM ANDAMENTO";
                }
                else if (s.situacao_sinistro == 1)
                {
                    s.situacao = "CONCLUÍDO";
                }
                cliente c = conn.retornaClientePorId(s.id_cliente);
                veiculo v = new veiculo();
                reboque r1 = new reboque();
                reboque r2 = new reboque();
                reboque r3 = new reboque();
                if (s.id_veiculo > 0)v = conn.retornaVeiculoPorId(s.id_veiculo);
                if (s.id_reboque1 > 0) r1 = conn.retornaReboquePorId(s.id_reboque1);
                if (s.id_reboque2 > 0) r2 = conn.retornaReboquePorId(s.id_reboque2);
                if (s.id_reboque3 > 0) r3 = conn.retornaReboquePorId(s.id_reboque3);
                s.nome_cliente = c.nome_completo;
                s.valor_total = conn.somaDePagamentosSinistrosPorIdSinistro(s.id);
                s.veiculos_reboques = String.Format(@"{0} / {1} / {2} / {3}", v.placa, r1.placa, r2.placa, r3.placa);
                listSin.Add(s);
            }
            bdgSinistros.DataSource = listSin;
            Log.createLog(EventLog.executedSearch, "");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
            Log.createLog(EventLog.exited, "formulario de pesquisa de sinistros");
        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
          /* TODAS AS SITUAÇÕES
             CONCLUIDOS
             EM ANDAMENTO */

            if (cbSituacao.Text.Equals("CONCLUIDOS"))
            {
                situacao = 1;
            }
            else if (cbSituacao.Text.Equals("EM ANDAMENTO"))
            {
                situacao = 0;
            }
            else
            {
                situacao = -1;
            }
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            cbVeiculo.EditValue = 0;
            cbReboque.EditValue = 0;
            if (Convert.ToInt64(cbCliente.EditValue) > 0)
            {
                bdgVeiculos.DataSource = conn.listaDeVeiculosPorIdClienteEInatividade(Convert.ToInt64(cbCliente.EditValue), false);
                bdgReboques.DataSource = conn.listaDeReboquesPorIdCliente(Convert.ToInt64(cbCliente.EditValue), false);
            }
            else
            {
                bdgVeiculos.DataSource = conn.listaDeTodosVeiculos();
                bdgReboques.DataSource = conn.listaDeTodosReboques();
            }
        }

        private void cbVeiculo_EditValueChanged(object sender, EventArgs e)
        {
            bdgReboques.Clear();
            if(Convert.ToInt64(cbVeiculo.EditValue)  > 0){
                bdgReboques.DataSource = conn.listaDeReboquesPorIdVeiculo(Convert.ToInt64(cbVeiculo.EditValue), false);
            }
            else
            {
                if (Convert.ToInt64(cbCliente.EditValue) > 0)
                {
                    bdgReboques.DataSource = conn.listaDeReboquesPorIdCliente(Convert.ToInt64(cbCliente.EditValue), false);
                }
                else
                {
                    bdgReboques.DataSource = conn.listaDeTodosReboques();
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            executaBusca();
        }
        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sinistro si = (sinistro)bdgSinistros.Current;
            SinistrosForm sif = new SinistrosForm(si){ formPrincipal = this.formPrincipal};
            formPrincipal.adicionarControleNavegacao(sif);
        }
    }
}
