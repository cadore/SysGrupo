using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace SysFileManager
{
    public partial class PleaseWaitForm : WaitForm
    {
        public PleaseWaitForm()
        {
            InitializeComponent();
            this.panelProgesso.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.panelProgesso.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.panelProgesso.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}