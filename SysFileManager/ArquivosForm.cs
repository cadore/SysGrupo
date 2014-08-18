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
using ServicosSysFileManager.Repository;
using System.IO;
using System.Diagnostics;
using System.Net.Mail;
using WcfLibGrupo.Utils;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace SysFileManager
{
    public partial class ArquivosForm : DevExpress.XtraEditors.XtraUserControl
    {
        public IServiceGrupo conn;
        public string DIRETORIO = "";
        string tempPathViewFiles = Path.GetTempPath() + @"SysNorte\SysGrupo\ViewFiles\";
        
        public ArquivosForm()
        {
            InitializeComponent();
            if (Directory.Exists(tempPathViewFiles))
            {
                Directory.Delete(tempPathViewFiles, true);
            }
        }

        public void executaBusca()
        {
            try
            {
                bdgArquivos.Clear();
                if (!conn.verificaDiretorioExistente(DIRETORIO))
                {
                    conn.criaDiretorio(DIRETORIO);
                }
                List<ArquivosModel> listAm = conn.retornaTodosArquivosPorDiretorio(DIRETORIO);
                bdgArquivos.DataSource = listAm;
                //Log.createLog(EventLog.opened, "arquivos");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                vereficaArquivos();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            executaBusca();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ArquivosModel am = (ArquivosModel) bdgArquivos.Current;
            if(am != null && !am.Equals(string.Empty)){
                Process.Start(am.nome_completo);
            }
        }

        void vereficaArquivos(){
            if(bdgArquivos.Current != null){
                btnExcluir.Enabled = true;
                btnDownload.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
                btnDownload.Enabled = false;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string arquivosComTamanhoExcedido = "";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Todos os Arquivos|*.*";
                ofd.AutoUpgradeEnabled = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {                                        
                    if (conn.verificaDiretorioExistente(DIRETORIO) == false)
                    {
                        conn.criaDiretorio(DIRETORIO);
                    }                    
                    foreach (string file in ofd.FileNames)
                    {
                        SplashScreenManager.ShowForm(typeof(PleaseWaitForm));
                        bool exist = false;
                        bool exced = false;
                        FileInfo fi = new FileInfo(file);
                        if (fi.Length > (30 * 1024) * 1024)
                        {
                            arquivosComTamanhoExcedido += "O arquivo: " + fi.Name + " excede o tamanho de 30MB e não foi copiado.\n";
                            exced = true;
                        }
                        if (conn.verificaArquivoExistente(DIRETORIO + fi.Name) == true)
                        {
                            //DialogResult rs = XtraMessageBox.Show("O arquivo com nome: " + fi.Name + " já existe, deseja sobreescrever?", "SYSNORTE", MessageBoxButtons.YesNo);
                            //if (rs == DialogResult.No)
                            //{
                                exist = true;
                            //}
                        }
                        if (!exced)
                        {
                            progressBar.Properties.ShowTitle = true;
                            progressBar.Position = 5;
                            FileStream f1 = new FileStream(file, FileMode.Open);
                            long length = Convert.ToInt64(f1.Length);
                            Byte[] b1 = new Byte[length];
                            f1.Read(b1, 0, (Int32)length);
                            string nome = fi.Name;
                            //int max = ((Int32)length);

                            /*if (((Int32)length > 1024))
                            {
                                max = ((Int32)length / 1024);
                            }
                            if ((Int32)length > 1048576)
                            {
                                max = ((Int32)length / 1024 / 1024);
                            }
                            progressBar.Properties.Maximum = max;                    
                            for (int i = 0; i < max; i++)
                            {
                                progressBar.PerformStep();
                                progressBar.Update();
                                conn.upload(b1, DIRETORIO + nome);                        
                            }*/
                            if (exist)
                            {
                                nome = "-" + nome;
                            }
                            conn.upload(b1, DIRETORIO + nome);
                            executaBusca();
                            progressBar.Position = 100;
                            f1.Close();
                        }
                        SplashScreenManager.CloseForm();
                        Thread.Sleep(300);
                    }                    
                    string msg = "";
                    if (!String.IsNullOrEmpty(arquivosComTamanhoExcedido))
                    {
                        msg = "\n\nOBS: \n" + arquivosComTamanhoExcedido;
                    }
                    XtraMessageBox.Show("Operação concluida com sucesso!" + msg);
                    progressBar.Properties.ShowTitle = false;
                    progressBar.Position = 0;                    
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                progressBar.Properties.ShowTitle = false;
                progressBar.Position = 0;
                XtraMessageBox.Show("Erro ao copiar arquivos.\n" + ex.Message);
            }            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            vereficaArquivos();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                ArquivosModel am = (ArquivosModel)bdgArquivos.Current;                
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.AutoUpgradeEnabled = true;
                sfd.Title = "Salvar Arquivo";
                sfd.InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%")+@"\Documents\";
                sfd.Filter = "Todos os Arquivos|*.*";
                sfd.FileName = am.nome + am.extensao;
                DialogResult rs = sfd.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    Byte[] by = conn.download(am.nome_completo);
                    File.WriteAllBytes(sfd.FileName, by);
                    DialogResult dr = XtraMessageBox.Show("Arquivo salvo com sucesso.\nDeseja abrir?", "SYSNORTE", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes){
                        if (File.Exists(sfd.FileName))
                        {
                            Process.Start(sfd.FileName);
                        }
                        else
                        {
                            XtraMessageBox.Show("Erro ao abrir arquivo, ele não foi encontrado.");
                        }
                    }
                }
            }catch(Exception ex)
            {
                XtraMessageBox.Show("Erro ao baixar arquivo\n"+ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ArquivosModel am = (ArquivosModel)bdgArquivos.Current;
                DialogResult rs = XtraMessageBox.Show("Tem certeza que deseja excluir o arquivo: " 
                    + am.nome + "?", "SYSNORTE", MessageBoxButtons.YesNo);
                if(rs == DialogResult.Yes){
                    conn.excluirArquivo(am.nome_completo);   
                }
                executaBusca();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Erro ao excluir arquivo.\n"+ex.Message);
            }
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(tempPathViewFiles))
                {
                    Directory.CreateDirectory(tempPathViewFiles);
                }
                ArquivosModel am = (ArquivosModel)bdgArquivos.Current;                
                if (am == null)
                    return;
                string file = String.Format("{0}{1}_{2:yyyy-MM-dd_HH-mm-ss}_tmp{3}", tempPathViewFiles, am.nome, DateTime.Now, am.extensao);
                Byte[] by = conn.download(am.nome_completo);
                File.WriteAllBytes(file, by);
                Process.Start(file);          
            }
            catch (Exception ex) 
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro:\n{0}\n\n{1}", ex.Message, ex.InnerException));
            }
        }
    }
}

