using ServicosSysFileManager.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicosSysFileManager
{
    public class SysFile
    {
        public List<ArquivosModel> retornaTodosArquivosPorDiretorio(string diretorio)
        {
            List<ArquivosModel> listAm = new List<ArquivosModel>();
            try
            {
                DirectoryInfo dir = new DirectoryInfo(diretorio);
                foreach (FileInfo file in dir.GetFiles())
                {
                    string _nome = file.Name.Replace(file.Extension, "");

                    listAm.Add(new ArquivosModel()
                    {
                        nome = _nome,
                        tamanho = Convert.ToInt32(file.Length / 1024),
                        extensao = file.Extension,
                        diretorio = file.DirectoryName,
                        nome_completo = file.FullName
                    });
                }
                foreach (DirectoryInfo dirNomes in dir.GetDirectories())
                {

                    foreach (FileInfo file in dirNomes.GetFiles())
                    {
                        string[] nomes = file.Name.Split('.');
                        listAm.Add(new ArquivosModel()
                        {
                            nome = nomes[0],
                            tamanho = Convert.ToInt32(file.Length / 1024),
                            extensao = file.Extension,
                            diretorio = file.DirectoryName,
                            nome_completo = file.FullName
                        });
                    }
                }                    
            }
            catch (Exception ex)
            {
                    throw new Exception(ex.Message);
            }
            return listAm;
        }

        public bool upload(Byte[] b1, string nome_completo)
        {
            try
            {
                Byte[] b = new Byte[b1.Length];
                b = b1;
                File.WriteAllBytes(nome_completo, b);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Byte[] download(string nome_completo)
        {
            FileStream f1 = null;
            try
            {
                f1 = new FileStream(nome_completo, FileMode.Open);
                long length = Convert.ToInt64(f1.Length);
                Byte[] b1 = new Byte[length];
                f1.Read(b1, 0, (Int32)length);
                return b1;                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                f1.Close();
            }
        }

        public bool verificaArquivoExistente(string arquivo)
        {
            bool flag;
            try
            {
                if(File.Exists(arquivo) == true){
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                    throw new Exception(ex.Message);
            }
            return flag;
        }

        public bool verificaDiretorioExistente(string diretorio)
        {
            bool flag;
            try
            {
                if (Directory.Exists(diretorio) == true)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flag;
        }

        public void criaDiretorio(string diretorio)
        {
            try
            {
                Directory.CreateDirectory(diretorio);
            }catch(Exception ex){
                throw new Exception(ex.Message);
            }
        }

        public void excluirArquivo(string nome_completo)
        {
            try
            {
                File.Delete(nome_completo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
