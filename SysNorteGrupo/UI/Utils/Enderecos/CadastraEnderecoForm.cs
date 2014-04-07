using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EntitiesGrupo;
using SysNorteGrupo.UI.Clientes;
using WcfLibGrupo;

namespace SysNorteGrupo.UI.Utils.Enderecos
{
    public partial class CadastraEnderecoForm : DevExpress.XtraEditors.XtraForm
    {
        private ClienteForm clienteForm;
        private string nomeBairro;
        private long idBairro;
        private long idCidade;
        private IServiceGrupo conn;
        public CadastraEnderecoForm(ClienteForm _clienteForm, string _nomeBairro, long _idBairro, long _idCidade)
        {
            InitializeComponent();
            clienteForm = _clienteForm;
            nomeBairro = _nomeBairro;
            idBairro = _idBairro;
            idCidade = _idCidade;
            bdgEndereco.DataSource = new endereco();
            lbBairro.Text = nomeBairro.ToUpper();
            conn = GerenteDeConexoes.conexaoServico();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validator.Validate())
            {
                DialogResult rs = MessageBox.Show(String.Format("CONFIRMA O CADASTRO DO ENDEREÇO '{0}'?\nNÃO SERÁ POSSÍVEL REVERTER ESTA AÇÃO.", tfEndereco.Text.ToUpper()),
                "SYSNORTE TECNOLOGIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        endereco en = (endereco)bdgEndereco.Current;
                        en.bairro_id = idBairro;
                        en.id_cidades = idCidade;
                        long id = conn.SalvaEndereco(en);
                        clienteForm.carregaEnderecosPorIdCidade();
                        clienteForm.cbEndereco.EditValue = id;
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CadastraEnderecoForm_KeyDown(object sender, KeyEventArgs e)
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