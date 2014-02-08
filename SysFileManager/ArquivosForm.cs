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

namespace SysFileManager
{
    public partial class ArquivosForm : DevExpress.XtraEditors.XtraUserControl
    {
        public IServiceGrupo conn;
        public string DIRETORIO = "";
        
        public ArquivosForm()
        {
            InitializeComponent();
        }

        public void executaBusca()
        {
            try
            {
                bdgArquivos.Clear();
                List<ArquivosModel> listAm = conn.retornaTodosArquivosPorDiretorio(DIRETORIO);
                bdgArquivos.DataSource = listAm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog sf = new OpenFileDialog();
                sf.Filter = "Todos os Arquivos|*.*";
                sf.AutoUpgradeEnabled = true;
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(sf.FileName);                    
                    if (fi.Length > (30 * 1024) * 1024)
                    {
                        MessageBox.Show("O arquivo: '" + fi.Name + "' excede o tamanho de 30MB");
                        return;
                    }
                    if (conn.verificaArquivoExistente(DIRETORIO + fi.Name) == true)
                    {
                        DialogResult rs = MessageBox.Show("O arquivo com nome: '"+fi.Name+ "' já existe, deseja sobreescrever?", "SYSNORTE", MessageBoxButtons.YesNo);
                        if(rs == DialogResult.No){
                            return;
                        }
                    }                    
                    if (conn.verificaDiretorioExistente(DIRETORIO) == false)
                    {
                        conn.criaDiretorio(DIRETORIO);
                    }
                    progressBar.Properties.ShowTitle = true;
                    progressBar.Position = 5;
                    FileStream f1 = new FileStream(sf.FileName, FileMode.Open);                    
                    long length = Convert.ToInt64(f1.Length);
                    Byte[] b1 = new Byte[length];
                    f1.Read(b1, 0, (Int32)length);
                    string nome = fi.Name;
                    int max = ((Int32)length / 1024) / 1024;
                    progressBar.Properties.Maximum = max;                    
                    for (int i = 0; i < max; i++)
                    {
                        progressBar.PerformStep();
                        progressBar.Update();
                        conn.upload(b1, DIRETORIO + nome);                        
                    }
                    MessageBox.Show("Arquivo enviado com sucesso!");
                    progressBar.Properties.ShowTitle = false;
                    progressBar.Position = 0;
                    f1.Close();
                }
            }
            catch (Exception ex)
            {
                progressBar.Properties.ShowTitle = false;
                progressBar.Position = 0;
                MessageBox.Show("Erro ao copiar arquivo.\n" + ex.Message);
            }
            executaBusca();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {

                ArquivosModel am = (ArquivosModel)bdgArquivos.Current;
                Byte[] by = conn.download(am.nome_completo);
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.AutoUpgradeEnabled = true;
                sfd.Title = "Salvar Arquivo";
                sfd.InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%")+@"\Documents\";
                sfd.Filter = "Todos os Arquivos|*.*";
                sfd.FileName = am.nome + am.extensao;
                DialogResult rs = sfd.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, by);
                    DialogResult dr = MessageBox.Show("Arquivo salvo com sucesso.\nDeseja abrir?", "SYSNORTE", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes){
                        if (File.Exists(sfd.FileName))
                        {
                            Process.Start(sfd.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao abrir arquivo.\n Arquivo não encontrado.");
                        }
                    }
                }
            }catch(Exception ex){
                MessageBox.Show("Erro ao baixar arquivo\n"+ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ArquivosModel am = (ArquivosModel)bdgArquivos.Current;
                conn.excluirArquivo(am.nome_completo);
                MessageBox.Show("Arquivo excluido com sucesso.");
                executaBusca();
            }catch(Exception ex){
                MessageBox.Show("Erro ao excluir arquivo.\n"+ex.Message);
            }
        }

        /*private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo f1 = new FileInfo(@"C:\Users\William\Desktop\1.txt");
                FileInfo f2 = new FileInfo(@"C:\Users\William\Desktop\2.txt");
                FileInfo f3 = new FileInfo(@"C:\Users\William\Desktop\3.txt");

                List<string> des = new List<string>();
                des.Add("william.cadore@hotmail.com");
                //des.Add("guilherme.ganzer@gmail.com");

                List<FileInfo> an = new List<FileInfo>();
                an.Add(f1);
                an.Add(f2);
                an.Add(f3);

                if (conn.EnviaEmail(des, "", "", "TESTE ENVIO", "TESTANDO ENVIO EMAIL", false, MailPriority.Normal, an))
                {
                    MessageBox.Show("Email enviado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}

