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
using EntitiesGrupo;
using WcfLibGrupo;
using SysNorteGrupo.UI.Clientes;

namespace SysNorteGrupo.UI.Utils.Enderecos
{
    public partial class CadastraBairroForm : DevExpress.XtraEditors.XtraForm
    {
        private string nomeCidade;
        private long idCidade;
        private ClienteForm clienteForm;
        private IServiceGrupo conn;
        public CadastraBairroForm(ClienteForm _clienteForm, string _nomeCidade, long _idCidade)
        {
            nomeCidade = _nomeCidade;
            idCidade = _idCidade;
            clienteForm = _clienteForm;
            conn = GerenteDeConexoes.conexaoServico();
            InitializeComponent();
            lbNomeCidade.Text = nomeCidade.ToUpper();
            bdgBairro.DataSource = new bairro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validator.Validate())
            {
                DialogResult rs = MessageBox.Show(String.Format("CONFIRMA O CADASTRO DO BAIRRO '{0}'?\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO.", tfNomeBairro.Text.ToUpper()),
                "SYSNORTE TECNOLOGIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        bairro b = (bairro)bdgBairro.Current;
                        b.id_cidades = idCidade;
                        long idBairro = conn.SalvaBairro(b);
                        this.DialogResult = DialogResult.OK;
                        clienteForm.carregaBairrosPorIdCidade();
                        clienteForm.cbBairro.EditValue = idBairro;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void CadastraBairroForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnSalvar_Click(sender, e);

            else if (e.KeyCode == Keys.Escape)
            {
                this.btnCancelar_Click(sender, e);
            }
        }
    }
}
