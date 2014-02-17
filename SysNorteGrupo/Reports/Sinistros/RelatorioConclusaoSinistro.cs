using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace SysNorteGrupo.Reports
{
    public partial class RelatorioConclusaoSinistro : DevExpress.XtraReports.UI.XtraReport
    {
        XtraReport detailReport;
        public RelatorioConclusaoSinistro(XtraReport _detailReport)
        {
            detailReport = _detailReport;
            InitializeComponent();
            subRelDados.ReportSource = this.detailReport;
        }

    }
}
