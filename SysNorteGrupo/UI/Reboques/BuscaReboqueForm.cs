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

namespace SysNorteGrupo.UI.Veiculos.Reboques
{
    public partial class BuscaReboqueForm : XtraUserControl
    {
        private IServiceGrupo conn = null;
        public FormPrincipal formPrincipal = null;
        private int tipoPesquisa = -1;
        private bool _inativo = false;
        private Color backColor = UtilsSistema.backColorFoco;

        public BuscaReboqueForm()
        {
            InitializeComponent();

            conn = GerenteDeConexoes.iniciaConexao();
            bdgCliente.DataSource = conn.listaDeClientesPorInatividade(false);
            bdgVeiculo.DataSource = conn.listaDeVeiculosPorInatividade(false);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            executaBusca();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            formPrincipal.adicionarControleNavegacao(null);
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

        private void tfId_KeyUp(object sender, KeyEventArgs e)
        {
            cbCliente.EditValue = null;
            cbCliente.EditValue = null;
            tfPlaca.Text = "";
            verificaTipoPesquisaTextEdit(tfId, 0);
        }

        private void tfPlaca_KeyUp(object sender, KeyEventArgs e)
        {
            tfId.Text = "";
            cbCliente.EditValue = null;
            cbCliente.EditValue = null;
            verificaTipoPesquisaTextEdit(tfPlaca, 1);
        }

        private void cbCliente_EditValueChanged(object sender, EventArgs e)
        {
            tfPlaca.Text = "";
            tfId.Text = "";
            cbVeiculo.EditValue = null;
            verificaTipoPesquisaSearchLookUpEdit(cbCliente, 2);
        }

        private void cbVeiculo_EditValueChanged(object sender, EventArgs e)
        {
            tfPlaca.Text = "";
            tfId.Text = "";
            cbCliente.EditValue = null;
            verificaTipoPesquisaSearchLookUpEdit(cbCliente, 3);
        }

        private void executaBusca()
        {
            List<reboque> listRetorno = new List<reboque>();
            List<reboque> listReb = null;

            if (tipoPesquisa == 0)
            {
                listReb = conn.listaDeReboquesPorId(Convert.ToInt64(tfId.Text), _inativo);
            }
            else if (tipoPesquisa == 1)
            {
                listReb = conn.listaDeReboquesPorPlaca(tfPlaca.Text, _inativo);
            }
            else if (tipoPesquisa == 2)
            {
                listReb = conn.listaDeReboquesPorIdCliente(Convert.ToInt64(cbCliente.EditValue), _inativo);
            }
            else if (tipoPesquisa == 3)
            {
                listReb = conn.listaDeReboquesPorIdVeiculo(Convert.ToInt64(cbVeiculo.EditValue), _inativo);
            }
            else
            {
                listReb = conn.listaDeReboquesPorInatividade(_inativo);
            }

            foreach (reboque r in listReb)
            {
                cliente cli = conn.retornaClientePorId(r.id_cliente);
                decimal cotas = r.valor / UtilsSistema.valor_por_cota;

                r.nome_cliente = cli.nome_completo;
                r.cotas = cotas;
                listRetorno.Add(r);
            }
            bdgReboque.DataSource = listRetorno;
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            reboque reb = (reboque)bdgReboque.Current;

            List<reboque> listaReboque = conn.listaDeReboquesPorIdVeiculo(reb.id_veiculo, false);

            ReboqueForm rf = new ReboqueForm(listaReboque) { formPrincipal = formPrincipal };
            formPrincipal.adicionarControleNavegacao(rf);
        }
    }
}
