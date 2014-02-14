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
            conn = GerenteDeConexoes.iniciaConexao();
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
                            List<long> listIdSinistro = conn.listaIdSinistroPorIdReboque(Convert.ToInt64(cbReboque.EditValue));
                            foreach(long id_sinistro in listIdSinistro){
                                listSinOrig.AddRange(conn.listaDeSinistrosPorId(id_sinistro));
                            }
                        }
                        else
                        {
                            List<long> listIdSinistro = conn.listaIdSinistroPorIdReboque(Convert.ToInt64(cbReboque.EditValue));
                            foreach (long id_sinistro in listIdSinistro)
                            {
                                listSinOrig = conn.listaDeSinistrosPorIdESituacao(id_sinistro, situacao);
                            }
                        }
                        preencheLista(listSinOrig);
                        return;
                    }
                    if (cbVeiculo.EditValue != null && Convert.ToInt32(cbVeiculo.EditValue) > 0)
                    {
                        if (situacao == -1)
                        {
                            
                        }
                        else
                        {
                            
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
                MessageBox.Show("Erro ao executar a busca.\n"+ex.Message);
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
                s.nome_cliente = c.nome_completo;
                s.valor_total = conn.somaDePagamentosSinistrosPorIdSinistro(s.id);
                listSin.Add(s);
            }
            bdgSinistros.DataSource = listSin;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
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
                bdgVeiculos.DataSource = conn.listaDeVeiculosPorIdCliente(Convert.ToInt64(cbCliente.EditValue), false);
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

        private void cbReboque_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            executaBusca();
        }
    }
}
