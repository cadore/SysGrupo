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

namespace SysNorteGrupo.UI.Sinistros
{
    public partial class BuscaSinistrosForm : DevExpress.XtraEditors.XtraUserControl
    {
        public IServiceGrupo conn = null;
        public FormPricipal formPrincipal = null;
        public BuscaSinistrosForm()
        {
            InitializeComponent();
        }
    }
}
