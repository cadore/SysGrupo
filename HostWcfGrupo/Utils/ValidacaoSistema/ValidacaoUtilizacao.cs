using Npgsql;
using System;
using System.Collections.Generic;
namespace HostWcfGrupo.Utils.ValidacaoSistema
{
    public class ValidacaoUtilizacao
    {
        public long id { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public bool inativo { get; set; }
        public DateTime data_expiracao { get; set; }
        public DateTime data_cadastro { get; set; }
    }

    public class ValidacoesDAO
    {
        public static string GET_BY_NOME_STATMENT = 
            "SELECT id, razao_social, inativo, data_cadastro, data_expiracao, nome_fantasia FROM clientes_sys WHERE razao_social = razao_social;";

        public ValidacaoUtilizacao recuperarPorNome(string nome)
        {
            NpgsqlConnection conn = null;
            NpgsqlCommand stmt = null;
            NpgsqlDataReader dr = null;
            ValidacaoUtilizacao validacao = null;

            try
            {
                conn = GerenteDeConexoes.getConnection();
                stmt = new NpgsqlCommand(GET_BY_NOME_STATMENT, conn);
                stmt.Parameters.AddWithValue("razao_social", nome);
                dr = stmt.ExecuteReader();
                if(dr.Read()){
                    //id, razao_social, inativo, data_cadastro, data_expiracao, nome_fantasia
                    long _id = Convert.ToInt64(dr[0]);
                    string _razao_social = dr[1].ToString();
                    bool _inativo = Convert.ToBoolean(dr[2]);
                    DateTime _data_cadastro = Convert.ToDateTime(dr[3]);
                    DateTime _data_expiracao = Convert.ToDateTime(dr[4]);
                    
                    string _nome_fantasia = dr[5].ToString();
                    
                    validacao = new ValidacaoUtilizacao()
                    {
                        id = _id,
                        razao_social = _razao_social,
                        inativo = _inativo,
                        data_expiracao = _data_expiracao,
                        data_cadastro = _data_cadastro,
                        nome_fantasia = _nome_fantasia
                    };
                }
                return validacao;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(String.Format("    {0}\n    {1}", ex.Message, ex.InnerException));
            }
            finally
            {
                GerenteDeConexoes.closeAll(conn);
            }
        }

        /*public List<ValidacaoUtilizacao> recuperarTodosPorDataExpiracao(DateTime data)
        {
            NpgsqlConnection conn = null;
            NpgsqlCommand stmt = null;
            NpgsqlDataReader dr = null;

            try
            {
                conn = GerenteDeConexoes.getConnection();
                stmt = new NpgsqlCommand(GET_ALL_BY_DATA_EXPIRACAO_STATMENT, conn);
                stmt.Parameters.AddWithValue("data_expiracao", data);
                dr = stmt.ExecuteReader();

                return converteParaLista(dr);
            }
            catch (NpgsqlException ex)
            {
                throw new Exception(String.Format("    {0}\n    {1}", ex.Message, ex.InnerException));
            }
            finally
            {
                GerenteDeConexoes.closeAll(conn);
            }
        }*/

        /*private List<ValidacaoUtilizacao> converteParaLista(NpgsqlDataReader dr)
        {
            List<ValidacaoUtilizacao> lista = new List<ValidacaoUtilizacao>();
            while (dr.Read())
            {
                //id, razao_social, inativo, data_cadastro, data_expiracao, nome_fantasia
                long _id = Convert.ToInt64(dr[0]);
                string _razao_social = dr[1].ToString();
                bool _inativo = Convert.ToBoolean(dr[2]);
                DateTime _data_expiracao = Convert.ToDateTime(dr[3]);
                DateTime _data_cadastro = Convert.ToDateTime(dr[4]);
                string _nome_fantasia = dr[5].ToString();

                ValidacaoUtilizacao validacao = new ValidacaoUtilizacao()
                {
                    id = _id,
                    razao_social = _razao_social,
                    inativo = _inativo,
                    data_expiracao = _data_expiracao,
                    data_cadastro = _data_cadastro,
                    nome_fantasia = _nome_fantasia
                };
                lista.Add(validacao);
            }
            return lista;
        }*/
    }
}
