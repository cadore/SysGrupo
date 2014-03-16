using EntitiesGrupo;
using PetaPoco;
using ServicosSysFileManager;
using ServicosSysFileManager.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.ServiceModel;
using System.Windows.Forms;
using WcfLibGrupo.Utils;

namespace WcfLibGrupo
{
    public class ServiceGrupo : IServiceGrupo
    {
        #region sistema

        public DateTime retornaDataHoraLocal()
        {
            return DateTime.Now;
        }

        public DateTime retornaDataHoraUTC()
        {
            try
            {
                return Datas.getUTCDateTime();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Color backColorFoco()
        {
            return UtilsSistemaServico.backColorFoco;
        }

        public decimal franquiaSinistro()
        {
            return UtilsSistemaServico.franquiaSinistro;
        }

        public decimal valorPorCota()
        {
            return UtilsSistemaServico.valor_por_cota;
        }

        public void excluiTodasValidacoes()
        {
            db.Execute("DELETE FROM validacoes_sistema");
        }

        public long CountValidacoesSistema()
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT Count(id) FROM validacoes_sistema");
                return db.ExecuteScalar<long>(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.InnerException);
            }
        }

        public validacoes_sistema retornaUltimaValidacaoSistema()
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM validacoes_sistema ORDER BY id DESC LIMIT 1");
                return validacoes_sistema.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.InnerException);
            }
        }

        public long salvarValidacaoSistema(validacoes_sistema obj)
        {
            try
            {
                obj.Save();
                return Convert.ToInt64(obj.id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\n" + ex.InnerException);
            }
        }

        #endregion

        #region db
        private static Database db = new Database("postgresql");
        #endregion

        #region empresa

        public empresa retornaEmpresa()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("empresa");
                return empresa.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                usuario.repo.AbortTransaction();

                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region Usuario
        public long salvarUsuario(usuario obj, permicoes_usuario pu)
        {
            try
            {                
                using (var scope = usuario.repo.GetTransaction())
                {
                    obj.Save();
                    pu.id_usuarios = Convert.ToInt64(obj.id);
                    pu.Save();
                    scope.Complete();
                }
                return Convert.ToInt64(obj.id);
            }
            catch (Exception ex)
            {
                usuario.repo.AbortTransaction();

                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<usuario> listaDeUsuariosAtivos()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("usuarios").Where("inativo = @0", "FALSE").OrderBy("id");
                return usuario.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<usuario> listaDeUsuariosAtivosPorId(long id)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("usuarios").Where("id=@0", id).Where("inativo = @0", "FALSE").OrderBy("id");
                return usuario.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<usuario> listaDeUsuariosAtivosPorNomeOuLogin(string nome)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM usuarios WHERE nome_completo ILIKE @0 AND inativo = @1 " +
                "UNION SELECT * FROM usuarios WHERE login ILIKE @0 AND inativo = @1", "%" + nome + "%", "FALSE").OrderBy("id");
                return usuario.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }      

        public usuario recuperaUsuarioPorId(long id)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("usuarios").Where("id=@0", id);
                return usuario.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public bool verificaSeLoginEhUnico(string login, bool edit)
        {
            try
            {
                long count;

                if (edit == true)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM usuarios WHERE login='{0}';", login);

                long rs = usuario.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaUsuarioAtivoPorLoginESenha(string login, string senha)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT Count(*) FROM usuarios WHERE login=@0 AND senha=@1 AND inativo=@2", login, senha, false);

                long rs = usuario.repo.ExecuteScalar<long>(sql);

                if (rs == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public permicoes_usuario recuperaPermicoesDoUsuarioPorIdUsuario(long id_usuario)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("permicoes_usuarios").Where("id_usuarios=@0", id_usuario);
                return permicoes_usuario.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public usuario recuperaUsuarioPorLoginEhSenha(string login, string senha)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM usuarios WHERE login=@0 AND senha=@1 AND inativo=@2", login, senha, false);
                return usuario.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }
        #endregion

        #region clientes
        public long salvarCliente(cliente obj)
        {
            try
            {
                obj.Save();
                return Convert.ToInt64(obj.id);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<cliente> listaDeTodosClientes()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cliente").OrderBy("id");
                return cliente.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<cliente> listaDeClientesPorInatividade(bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cliente").Where("inativo = @0", inativo).OrderBy("id");
                return cliente.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<cliente> listaDeClientesPorId(long id)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cliente").Where("id=@0", id).OrderBy("id");
                return cliente.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<cliente> listaDeClientesPorNomeOuDocumento(string nome_documento, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM cliente WHERE nome_completo ILIKE @0 AND inativo = @2"+
                " UNION SELECT * FROM cliente WHERE documento=@1 AND inativo = @2", String.Format("%{0}%", nome_documento), nome_documento, inativo);
                return cliente.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public cliente retornaClientePorId(long id)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM cliente WHERE id=@0", id);
                return cliente.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public bool verificaSeCpfCnpjEhUnico(string doc)
        {
            try
            {
                var sql = String.Format("SELECT Count(*) FROM cliente WHERE documento='{0}';", doc);

                long rs = cliente.repo.ExecuteScalar<long>(sql);

                if (rs > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaSeEmailPrincipalEhUnico(string email) 
        {
            try
            {

                string sql = String.Format("SELECT Count(*) FROM cliente WHERE email_principal='{0}';", email);
                //var sql = Sql.Builder.Select("*").From("cliente").Where("email_principal=@0", email);

                long rs = cliente.repo.ExecuteScalar<long>(sql);

                if (rs > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaSeInscricaoRgEhUnico(string insc)
        {
            try
            {
                var sql = String.Format("SELECT Count(*) FROM cliente WHERE inscricao_rg='{0}';", insc);

                long rs = cliente.repo.ExecuteScalar<long>(sql);

                if (rs > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public int countClientesPorDataDeAtivacao(DateTime? data)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT Count(*) FROM cliente WHERE data_ativacao<=@0", data);

                int rs = cliente.repo.ExecuteScalar<int>(sql);

                return rs;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public List<cliente> listaDeClientesPorDataDeAtivacao(DateTime? data)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM cliente WHERE data_ativacao<=@0", data);
                return cliente.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }
        #endregion

        #region fipe

        public List<marca_veiculo> listaDeMarcas()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("marca_veiculos").Where("tipo=@0", "caminhao").OrderBy("id");
                return marca_veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<modelo_veiculo> listaDeModelosPorIdMarca(long id_marca)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("modelo_veiculos").Where("marca=@0", id_marca).Where("tipo=@0", "caminhao").OrderBy("id");
                return modelo_veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<ano_modelo_veiculo> listaDeAnoModelosPorIdModelo(string id_modelo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("ano_modelo_veiculos").Where("modelo=@0", id_modelo).Where("tipo=@0", "caminhao").OrderBy("id");
                return ano_modelo_veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public ano_modelo_veiculo recuperaValorPorIdModelo(long id_modelo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("ano_modelo_veiculos").Where("id=@0", id_modelo).Where("tipo=@0", "caminhao");
                return ano_modelo_veiculo.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public modelo_veiculo retornaModeloPorId(string id_modelo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("modelo_veiculos").Where("id=@0", id_modelo);
                return modelo_veiculo.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region Veiculos

        public long salvarVeiculo(veiculo veiculo_obj)
        {
            try
            {
                veiculo_obj.Save();
                return Convert.ToInt64(veiculo_obj.id);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public veiculo retornaVeiculoPorId(long id_veiculo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("id=@0", id_veiculo);
                return veiculo.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                reboque.repo.AbortTransaction();
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<especies_veiculo> listaDeEspeciesVeiculos()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("especies_veiculos").OrderBy("id");
                return especies_veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<veiculo> listaDeVeiculosPorIdCliente(long id_cliente)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("id_cliente=@0", id_cliente);
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<veiculo> listaDeVeiculosPorIdClienteEDataAtivacao(long id_cliente, DateTime data_ativacao)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("id_cliente=@0", id_cliente).Where("data_ativacao<=@0", data_ativacao);
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<veiculo> listaDeVeiculosPorInatividade(bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("inativo=@0", inativo).OrderBy("id");
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<veiculo> listaDeVeiculosPorPlaca(string placa, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("placa ILIKE @0", "%"+placa+"%").Where("inativo=@0", inativo).OrderBy("id");
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<veiculo> listaDeVeiculosPorId(long id, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("id=@0", id).Where("inativo=@0", inativo).OrderBy("id");
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<veiculo> listaDeVeiculosPorIdClienteEInatividade(long id_cliente, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos").Where("id_cliente=@0", id_cliente).Where("inativo=@0", inativo).OrderBy("id");
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public decimal somaDeValoresDeVeiculosPorInatividade(bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT SUM(valor) FROM veiculos WHERE inativo=@0", inativo);
                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs); 
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public bool verificaSePlacaVeiculoEhUnica(string placa, bool edit)
        {
            try
            {
                long count;

                if (edit == true)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM veiculos WHERE placa='{0}';", placa);

                long rs = veiculo.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaSeNChassiEhUnico(string chassi, bool edit)
        {
            try
            {
                long count;

                if (edit == true)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM veiculos WHERE numero_chassi='{0}';", chassi);

                long rs = veiculo.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaSeRenavamEhUnico(string renavam, bool edit)
        {
            try
            {
                long count;

                if(edit == true){
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM veiculos WHERE cod_renavam='{0}';", renavam);

                long rs = veiculo.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public decimal somaValorTotalVeiculoPorIdClienteEInatividade(long id_cliente, bool inativo)
        {
            try
            {
                string sql = String.Format("SELECT SUM(valor) FROM veiculos WHERE id_cliente = '{0}' AND inativo = '{1}';", id_cliente, inativo);

                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs); 
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public decimal somaValorTotalVeiculoPorDataAtivacao(DateTime? data)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT SUM(valor) FROM veiculos WHERE data_ativacao<=@0;", data);

                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public List<veiculo> listaDeTodosVeiculos()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("veiculos");
                return veiculo.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region reboques

        public long salvarReboques(List<reboque> reboques)
        {
            try
            {
                using (var scope = reboque.repo.GetTransaction())
                {                    
                    foreach(reboque reb in reboques) 
                    {
                        reb.Save();
                    }

                    scope.Complete();
                }
                return 0;
            }
            catch (Exception ex)
            {
                reboque.repo.AbortTransaction();
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public long salvarReboque(reboque reboq)
        {
            try
            {
                long return_id = 0;
                using (var scope = reboque.repo.GetTransaction())
                {
                    reboq.Save();

                    scope.Complete();

                    return_id = reboq.id;
                }
                return return_id;
            }
            catch (Exception ex)
            {
                reboque.repo.AbortTransaction();
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public reboque retornaReboquePorId(long id_reboque)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("id=@0", id_reboque);
                return reboque.SingleOrDefault(sql);
            }
            catch (Exception ex)
            {
                reboque.repo.AbortTransaction();
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<especies_reboque> listaDeEspeciesReboques()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("especies_reboques").OrderBy("id");
                return especies_reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<reboque> listaDeReboquesPorInatividade(bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("inativo=@0", inativo).OrderBy("id");
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<reboque> listaDeReboquesPorPlaca(string placa, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("placa ILIKE @0", String.Format("%{0}%", placa)).Where("inativo=@0", inativo).OrderBy("id");
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<reboque> listaDeReboquesPorId(long id, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("id=@0", id).Where("inativo=@0", inativo).OrderBy("id");
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<reboque> listaDeReboquesPorIdCliente(long id_cliente, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("id_cliente=@0", id_cliente).Where("inativo=@0", inativo).OrderBy("id");
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<reboque> listaDeReboquesPorIdVeiculo(long id_veiculo, bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("id_veiculo=@0", id_veiculo).Where("inativo=@0", inativo).OrderBy("id");
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<reboque> listaDeReboquesPorIdVeiculoEdataAtivacao(long id_veiculo, DateTime data)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques").Where("id_veiculo=@0", id_veiculo).Where("data_ativacao=@0", data);
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public decimal somaDeValoresDeReboquesPorInatividade(bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT SUM(valor) FROM reboques WHERE inativo=@0", inativo);
                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs); 
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public bool verificaSePlacaReboqueEhUnica(string placa, bool edit)
        {
            try
            {
                long count;

                if (edit == true)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM reboques WHERE placa='{0}';", placa);

                long rs = reboque.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaSeNChassiReboqueEhUnico(string chassi, bool edit)
        {
            try
            {
                long count;

                if (edit == true)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM reboques WHERE chassi='{0}';", chassi);

                long rs = reboque.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public bool verificaSeRenavamReboqueEhUnico(string renavam, bool edit)
        {
            try
            {
                long count;

                if (edit == true)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                string sql = String.Format("SELECT Count(*) FROM reboques WHERE renavam='{0}';", renavam);

                long rs = reboque.repo.ExecuteScalar<long>(sql);

                if (rs > count)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public decimal somaValorTotalReboquesPorIdClienteEInatividade(long id_cliente, bool inativo)
        {
            try
            {
                string sql = String.Format("SELECT SUM(valor) FROM reboques WHERE id_cliente = '{0}' AND inativo = '{1}';", id_cliente, inativo);

                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs); 
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public decimal somaValorTotalReboquesPorDataAtivacao(DateTime? data)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT SUM(valor) FROM reboques WHERE data_ativacao<=@0;", data);

                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCEPT: {0}\n\nINNER EXCEPT: {1}", ex.Message, ex.InnerException)),
                    new FaultCode("ERRDB"));
            }
        }

        public List<reboque> listaDeTodosReboques()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("reboques");
                return reboque.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region cidades, bairros, enderecos

        public List<estado> listaDeEstados()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cad_estados").OrderBy("id");
                return estado.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<cidade> listaDeCidadesPorEstado(string estado)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cad_cidades").Where(String.Format("uf='{0}'", estado)).OrderBy("id");
                return cidade.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<bairro> listaDeBairrosPorCidade(long id_cidade)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cad_bairros").Where(String.Format("id_cidades={0}", id_cidade)).OrderBy("id");
                return bairro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<endereco> listaDeEnderecosPorCidade(long id_cidade)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("cad_enderecos").Where(String.Format("id_cidades={0}", id_cidade)).OrderBy("id");
                return endereco.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region arquivos

        public List<ArquivosModel> retornaTodosArquivosPorDiretorio(string diretorio)
        {
            try
            {
                return new SysFile().retornaTodosArquivosPorDiretorio(diretorio);
            }
            catch (Exception ex)
            {
                    throw new FaultException(
                        new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                        new FaultCode("1000"));
            }
        }

        public bool upload(Byte[] b1, string nome_completo)
        {
            try
            {
                return new SysFile().upload(b1, nome_completo);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public Byte[] download(string nome_completo)
        {
            return new SysFile().download(nome_completo);
        }

        public bool verificaArquivoExistente(string arquivo)
        {
            try
            {
                return new SysFile().verificaArquivoExistente(arquivo);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public bool verificaDiretorioExistente(string diretorio)
        {
            try
            {
                return new SysFile().verificaDiretorioExistente(diretorio);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public void criaDiretorio(string diretorio)
        {
            try
            {
                new SysFile().criaDiretorio(diretorio);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }            
        }

        public void excluirArquivo(string nome_completo)
        {
            try
            {
                new SysFile().excluirArquivo(nome_completo);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region diretorios

        public string SUBDIR_EMPRESA()
        {
            return UtilsSistemaServico.SUBDIR_EMPRESA;
        }

        public string SUBDIR_CLIENTES()
        {
            return UtilsSistemaServico.SUBDIR_CLIENTES;
        }

        public string SUBDIR_VEICULOS(){
            return UtilsSistemaServico.SUBDIR_VEICULOS;
        }

        public string SUBDIR_REBOQUES()
        {
            return UtilsSistemaServico.SUBDIR_REBOQUES;
        }

        public string SUBDIR_SINISTROS()
        {
            return UtilsSistemaServico.SUBDIR_SINISTROS;
        } 

        #endregion

        #region email
        public bool EnviaEmail(List<string> destinatarios, string cc, string bcc, string assunto, string menssagem, bool html, MailPriority prioridade, List<FileInfo> anexos)
        {
            try
            {
                return new EMailUtil().EnviaEmail(destinatarios, cc, bcc, assunto, menssagem, html, prioridade, anexos);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion

        #region sinistros

        public long SalvaSinistro(sinistro obj, List<pagamentos_sinistro> listPag)
        {
            try
            {
                long _id_sinistroOriginal = obj.id;
                long _id_sinistro;
                using (var scope = sinistro.repo.GetTransaction())
                {
                    obj.clientes_no_rateio = countClientesPorDataDeAtivacao(obj.data_ocorrido);
                    obj.cotas_na_data = (somaValorTotalReboquesPorDataAtivacao(obj.data_ocorrido) / UtilsSistemaServico.valor_por_cota) +
                        (somaValorTotalVeiculoPorDataAtivacao(obj.data_ocorrido) / UtilsSistemaServico.valor_por_cota);
                    obj.Save();
                    _id_sinistro = Convert.ToInt64(obj.id);                    
                    foreach(pagamentos_sinistro ps in listPag){
                        ps.id_sinistros = _id_sinistro;
                        ps.Save();
                    }
                    if (_id_sinistroOriginal == 0)
                    {
                        foreach(veiculo vei in listaDeTodosVeiculos()){
                            historico_veic_reb_sinistros hv = new historico_veic_reb_sinistros()
                            {
                                id_reboque = 0,
                                id_veiculo = vei.id,
                                identificador = 'v',
                                valor = vei.valor,
                                id_sinistro = _id_sinistro
                            };
                            if (historico_veic_reb_sinistros.repo.IsNew(hv))
                            {
                                historico_veic_reb_sinistros.repo.Save(hv);
                            }
                        }

                        foreach(reboque reb in listaDeTodosReboques()){
                            historico_veic_reb_sinistros hr = new historico_veic_reb_sinistros() 
                            { 
                                id_reboque = reb.id,
                                id_veiculo = 0,
                                identificador = 'r',
                                valor = reb.valor,
                                id_sinistro = _id_sinistro
                            };
                            if (historico_veic_reb_sinistros.repo.IsNew(hr))
                            {
                                historico_veic_reb_sinistros.repo.Save(hr);
                            }
                        }
                    }
                    scope.Complete();
                }
                return _id_sinistro;
            }
            catch (Exception ex)
            {
                sinistro.repo.AbortTransaction();
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeTodosSinistros()
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros");
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistrosPorIdESituacao(long id_sinistro, int situacao)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("id=@0", id_sinistro).Where("situacao_sinistro=@0", situacao);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistrosPorId(long id_sinistro)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("id=@0", id_sinistro);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistrosPorSituacao(int situacao)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("situacao_sinistro=@0", situacao);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistrosPorIdClienteESituacao(long id_cliente, int situacao)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("id_cliente=@0", id_cliente).Where("situacao_sinistro=@0", situacao);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistrosPorIdCliente(long id_cliente)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("id_cliente=@0", id_cliente);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistroPorIdVeiculo(long id_veiculo)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("id_veiculo=@0", id_veiculo);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistroPorIdVeiculoESituacao(long id_veiculo, int situacao)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("sinistros").Where("id_veiculo=@0", id_veiculo).Where("situacao_sinistro=@0", situacao);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistroPorIdReboque(long id_reboque)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM sinistros WHERE id_reboque1=@0 " +
                "UNION SELECT * FROM sinistros WHERE id_reboque2=@0 " +
                "UNION SELECT * FROM sinistros WHERE id_reboque2=@0 ", id_reboque);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<sinistro> listaDeSinistroPorIdReboqueESituacao(long id_reboque, int situacao)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT * FROM sinistros WHERE id_reboque1=@0 AND situacao_sinistro=@1 " +
                "UNION SELECT * FROM sinistros WHERE id_reboque2=@0 AND situacao_sinistro=@1 " +
                "UNION SELECT * FROM sinistros WHERE id_reboque2=@0 AND situacao_sinistro=@1 ", id_reboque, situacao);
                return sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        public List<pagamentos_sinistro> listaDePagamentosSinistrosPorIdSinistro(long id_sinistro)
        {
            try
            {
                var sql = Sql.Builder.Select("*").From("pagamentos_sinistro").Where("id_sinistros=@0", id_sinistro);
                return pagamentos_sinistro.Fetch(sql);
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }
        public decimal somaDePagamentosSinistrosPorIdSinistro(long id_sinistro)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT SUM(valor) FROM pagamentos_sinistro WHERE id_sinistros=@0", id_sinistro);
                var rs = db.ExecuteScalar<string>(sql);
                if (rs.Equals(DBNull.Value) || String.IsNullOrEmpty(rs))
                {
                    return 0;
                }
                return Convert.ToDecimal(rs);                
            }
            catch (Exception ex)
            {
                throw new FaultException(
                    new FaultReason(String.Format("EXCECÃO: {0}{1}INNER EXCEPTION: {2}", ex.Message, Environment.NewLine, ex.InnerException)),
                    new FaultCode("1000"));
            }
        }

        #endregion
    }
}
