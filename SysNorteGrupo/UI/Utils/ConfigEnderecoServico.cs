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
using System.Net;
using SysNorteGrupo.Utils;

namespace SysNorteGrupo.UI.Utils
{
    public partial class ConfigEnderecoServico : DevExpress.XtraEditors.XtraForm
    {
        private string ip { get; set; }
        private string porta { get; set; }
        public ConfigEnderecoServico()
        {
            ip = GerenteDeConexoes.ipServico;
            porta = GerenteDeConexoes.porta;
            InitializeComponent();

            tfIP.Text = ip;
            tfPorta.Text = porta;
            
        }

        bool validaIP(string ip)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(ip, out ipAddress) || "localhost".Equals(ip.Trim().ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ip = tfIP.Text;
            porta = tfPorta.Text;
            if(!validaIP(ip))
            {
                MessageBox.Show("IP Inválido!");
                return;
            }
            FilesINI.WriteValue("sistema", "ipServico", ip);
            FilesINI.WriteValue("sistema", "porta", porta);
            GerenteDeConexoes.carregaURL(ip, porta);
            if (ckConectarSaida.CheckState == CheckState.Checked)
            {
                try
                {
                    GerenteDeConexoes.iniciaConexaoServico();
                }
                catch(Exception)
                {
                    MessageBox.Show("Não foi possível conectar ao servidor, verifique o endereço e a porta e tente novamente.");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}