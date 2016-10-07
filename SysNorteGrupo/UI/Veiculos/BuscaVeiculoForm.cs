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
using System.IO;

namespace SysNorteGrupo.UI.Veiculos
{
    public partial class BuscaVeiculoForm : DevExpress.XtraEditors.XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private int tipoPesquisa = -1;
        private bool _inativo = false;
        private Color backColor = ConfigSistema.backColorFoco;

        public BuscaVeiculoForm()
        {
            InitializeComponent();
            conn = GerenteDeConexoes.conexaoServico();
            bdgCliente.DataSource = conn.listaDeClientes();

            foreach (Control c in pnBotoes.Controls)
            {
                preencheFundoControls(c);
            }
        }

        void preencheFundoControls(Control item)
        {
            switch (item.GetType().ToString())
            {
                case "DevExpress.XtraEditors.TextEdit": ((TextEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.SearchLookUpEdit": ((SearchLookUpEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.RadioGroup": ((RadioGroup)item).Properties.AppearanceFocused.BackColor = backColor; break;
                case "DevExpress.XtraEditors.CheckEdit": ((CheckEdit)item).Properties.AppearanceFocused.BackColor = backColor; break;
            }
        }

        private void executaBusca()
        {
            try
            {
                List<veiculo> listRetorno = new List<veiculo>();
                List<veiculo> listVei = null;
                if (tipoPesquisa == 0)
                {
                    listVei = conn.listaDeVeiculosPorId(Convert.ToInt64(tfId.Text), _inativo);
                }
                else if (tipoPesquisa == 1)
                {
                    listVei = conn.listaDeVeiculosPorPlaca(tfPlaca.Text, _inativo);
                }
                else if (tipoPesquisa == 2)
                {
                    listVei = conn.listaDeVeiculosPorIdClienteEInatividade(Convert.ToInt64(cbCliente.EditValue), _inativo);
                }
                else
                {
                    listVei = conn.listaDeVeiculosPorInatividade(_inativo);
                }

                foreach (veiculo v in listVei)
                {
                    cliente cli = conn.retornaClientePorId(v.id_cliente);
                    if(cli != null)
                        v.nome_cliente = cli.nome_completo;
                    else
                        v.nome_cliente = "";

                    decimal cotas = v.valor / ConfigSistema.valor_por_cota;
                    v.cotas = cotas;
                    listRetorno.Add(v);
                }
                bdgVeiculo.DataSource = listRetorno;
                Log.createLog(SysEventLog.executedSearch, String.Format(""));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            executaBusca();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
            Log.createLog(SysEventLog.exited, String.Format("formulario de busca veiculos"));
        }

        private void ckAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAtivo.CheckState == CheckState.Checked)
            {
                ckInativo.CheckState = CheckState.Unchecked;
                _inativo = false;
                executaBusca();
            }
        }

        private void ckInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInativo.CheckState == CheckState.Checked)
            {
                ckAtivo.CheckState = CheckState.Unchecked;
                _inativo = true;
                executaBusca();
            }
        }

        private void verificaTipoPesquisaTextEdit(TextEdit t, int _tipoPesquisa)
        {
            string valor = t.Text;
            if (!valor.Equals(String.Empty))
            {
                tipoPesquisa = _tipoPesquisa;
            }
            else
            {
                tipoPesquisa = -1;
            }
        }

        private void verificaTipoPesquisaSearchLookUpEdit(SearchLookUpEdit cb, int _tipoPesquisa)
        {
            if (cb.EditValue != null)
            {
                tipoPesquisa = _tipoPesquisa;
            }
            else
            {
                tipoPesquisa = -1;
            }
        }

        private void gridControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            veiculo vei = (veiculo)bdgVeiculo.Current;

            VeiculosForm cf = new VeiculosForm(vei) { formPrincipal = formPrincipal };
            formPrincipal.adicionarControleNavegacao(cf);
        }

        private void tfId_KeyUp(object sender, KeyEventArgs e)
        {
            cbCliente.EditValue = null;
            tfPlaca.Text = "";
            verificaTipoPesquisaTextEdit(tfId, 0);
        }

        private void tfPlaca_KeyUp(object sender, KeyEventArgs e)
        {
            tfId.Text = "";
            cbCliente.EditValue = null;
            verificaTipoPesquisaTextEdit(tfPlaca, 1);
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            tfPlaca.Text = "";
            tfId.Text = "";
            verificaTipoPesquisaSearchLookUpEdit(cbCliente, 2);
        }
    }
}
