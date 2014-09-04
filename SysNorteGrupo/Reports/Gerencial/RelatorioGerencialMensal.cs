using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SysNorteGrupo.Reports.Gerencial
{
    public partial class RelatorioGerencialMensal : DevExpress.XtraReports.UI.XtraReport
    {
        public RelatorioGerencialMensal()
        {
            InitializeComponent();
        }

        public void list()
        {
            if (bdgRelatorio.List != null)
                foreach (SinistrosRelatorioGerencial s in ((RelatorioGerencial)bdgRelatorio.Current).cliente.listSin)
                    Console.WriteLine(s.subTotal);
        }

    }
}
