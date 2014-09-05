using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

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
            Console.WriteLine(bdgRelatorio.Count);
            Console.WriteLine(((RelatorioGerencial)bdgRelatorio.Current).cliente.listSin.Count);
            //if (bdgRelatorio.List != null)
                //foreach (SinistrosRelatorioGerencial s in ((RelatorioGerencial)bdgRelatorio.Current).cliente.listSin)
                    //Console.WriteLine(s.subTotal);
        }

        private void xrSubreport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //((XRSubreport)sender).ReportSource = ((SubRelatorioGerencialMensal)
               // ((RelatorioGerencial)bdgRelatorio.DataSource).cliente.reportListSin);
        }
    }
}
