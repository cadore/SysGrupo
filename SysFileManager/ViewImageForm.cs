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
using System.IO;

namespace SysFileManager
{
    public partial class ViewImageForm : DevExpress.XtraEditors.XtraForm
    {
        DialogResult rs = DialogResult.OK;
        public ViewImageForm(string imageLocation)
        {
            InitializeComponent();
            try
            {
                Image i = Image.FromFile(imageLocation);
                this.Size = i.Size + new Size(5, 5);
                this.MinimumSize = this.Size;
                pictureBox.ImageLocation = imageLocation;
                pictureBox.Load();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Occoreu um erro ao carregar a imagem.\n{0}\n\n{1}", 
                    ex.Message, ex.InnerException));
                rs = DialogResult.Abort;
                this.Close();
            }            
        }

        private void ViewImageForm_Resize(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(pictureBox.ImageLocation))
                {
                    pictureBox.Load();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Occoreu um erro ao redimensionar o formulario.\n{0}\n\n{1}", 
                    ex.Message, ex.InnerException));
                rs = DialogResult.Abort;
                this.Close();
            }
        }

        private void ViewImageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = rs;
        }
    }
}