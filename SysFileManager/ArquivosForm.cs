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
                if (conn.verificaDiretorioExistente(DIRETORIO) == false)
                {
                    conn.criaDiretorio(DIRETORIO);
                }
                List<ArquivosModel> listAm = conn.retornaTodosArquivosPorDiretorio(DIRETORIO);
                bdgArquivos.DataSource = listAm;
                //Log.createLog(EventLog.opened, "arquivos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Todos os Arquivos|*.*";
                ofd.AutoUpgradeEnabled = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);                    
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
                    FileStream f1 = new FileStream(ofd.FileName, FileMode.Open);                    
                    long length = Convert.ToInt64(f1.Length);
                    Byte[] b1 = new Byte[length];
                    f1.Read(b1, 0, (Int32)length);
                    string nome = fi.Name;
                    int max = ((Int32)length);

                    if (((Int32)length > 1024))
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
                    }
                    executaBusca();
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
                    DialogResult dr = MessageBox.Show("Arquivo salvo com sucesso.\nDeseja abrir?", "SYSNORTE", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes){
                        if (File.Exists(sfd.FileName))
                        {
                            Process.Start(sfd.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao abrir arquivo, ele não foi encontrado.");
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
                DialogResult rs = MessageBox.Show("Tem certeza que deseja excluir o arquivo: "+am.nome+"?", "SYSNORTE", MessageBoxButtons.YesNo);
                if(rs == DialogResult.Yes){
                    conn.excluirArquivo(am.nome_completo);
                    MessageBox.Show("Arquivo excluido com sucesso.");   
                }
                executaBusca();
            }catch(Exception ex){
                MessageBox.Show("Erro ao excluir arquivo.\n"+ex.Message);
            }
        }
    }
}

