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
    public partial class SinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {

        public IServiceGrupo conn;
        public FormPrincipal formPrincipal = null;
        private sinistro sinistro_instc = null;
        public SinistrosForm(sinistro _sinistro_instc)
        {
            sinistro_instc = _sinistro_instc;
            InitializeComponent();

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
    }
}
