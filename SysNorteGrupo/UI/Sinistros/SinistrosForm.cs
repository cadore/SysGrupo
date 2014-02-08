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

namespace SysNorteGrupo.UI.Sinistros
{
    public partial class SinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {
        public IServiceGrupo conn;
        public FormPrincipal formPrincipal = null;
        private sinistro sinistro_instc = null;
        public SinistrosForm(sinistro _sinistro_instc)
        {
            sinistro_instc = _sinistro_instc;
            InitializeComponent();
            conn = GerenteDeConexoes.iniciaConexao();

            bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);
            bdgReboquesTabela.DataSource = new List<reboque>();

            if(sinistro_instc == null){
                sinistro_instc = new sinistro();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
        }      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            SinistrosForm sf = new SinistrosForm(new sinistro()) { formPrincipal = this.formPrincipal};
            formPrincipal.adicionarControleNavegacao(sf);
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbCliente.EditValue) > 0)
            {
                bdgVeiculos.DataSource = conn.listaDeVeiculosPorIdCliente(Convert.ToInt32(cbCliente.EditValue), false);
            }
        }

        private void cbVeiculo_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbVeiculo.EditValue) > 0)
            {
                bdgReboques.DataSource = conn.listaDeReboquesPorIdVeiculo(Convert.ToInt32(cbVeiculo.EditValue), false);
            }
        }

        private void btnAdicionarTab_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbReboque.EditValue) > 0)
            {
                btnAdicionarTab.Enabled = false;
                List<reboque> listReb = (List<reboque>)bdgReboques.DataSource;
                List<reboque> listRebTab = (List<reboque>)bdgReboquesTabela.DataSource;
                foreach(reboque r in listReb){
                    if (r.placa.Equals(cbReboque.Text))
                    {                        
                        if (!listRebTab.Contains(r))
                        {
                            bdgReboquesTabela.Add(r);
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
                List<reboque> listRebTab = (List<reboque>)bdgReboquesTabela.DataSource;
                foreach (reboque r in listReb)
                {
                    if (r.placa.Equals(cbReboque.Text))
                    {
                        if (!listRebTab.Contains(r))
                        {
                            btnAdicionarTab.Enabled = true;
                        }
                        else
                        {
                            btnAdicionarTab.Enabled = false;
                        }
                    }
                }                
            }
            else
            {
                btnAdicionarTab.Enabled = false;
            }
        }

        private void gridControlReboques_Click(object sender, EventArgs e)
        {
            if(bdgReboquesTabela.Current != null){
                btnRemoverTab.Enabled = true;
            }
            else
            {
                btnRemoverTab.Enabled = false;
            }
        }

        private void btnRemoverTab_Click(object sender, EventArgs e)
        {
            reboque r = (reboque)bdgReboquesTabela.Current;
            List<reboque> listR = (List<reboque>)bdgReboquesTabela.DataSource;
            if(listR.Contains(r)){
                bdgReboquesTabela.Remove(r);
            }
            cbReboque.EditValue = 0;
            btnRemoverTab.Enabled = false;
        }       
    }
}
