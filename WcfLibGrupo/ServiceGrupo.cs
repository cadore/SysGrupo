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
            return Datas.getUTCDateTime();
        }

        public Color backColorFoco()
        {
            return UtilsSistemaServico.backColorFoco;
        }

        #endregion

        #region db
        private static Database db = new Database("postgresql");
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

        public List<veiculo> listaDeVeiculosPorIdCliente(long id_cliente, bool inativo)
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
                return Convert.ToDecimal(veiculo.repo.ExecuteScalar<decimal>(sql));
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

                decimal rs = veiculo.repo.ExecuteScalar<decimal>(sql);
                return rs;
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

        public long salvarReboque(reboque reboque_obj)
        {
            try
            {
                reboque_obj.Save();
                return Convert.ToInt64(reboque_obj.id);
            }
            catch (Exception ex)
            {
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

        public decimal somaDeValoresDeReboquesPorInatividade(bool inativo)
        {
            try
            {
                var sql = Sql.Builder.Append("SELECT SUM(valor) FROM reboques WHERE inativo=@0", inativo);
                return Convert.ToDecimal(reboque.repo.ExecuteScalar<decimal>(sql));
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

                decimal rs = reboque.repo.ExecuteScalar<decimal>(sql);
                return rs;
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

        public long SalvaSinistro(sinistro obj, List<vei_reb_sinistros> listVR, List<pagamentos_sinistro> listPag)
        {
            try
            {
                long _id_sinistro;
                using (var scope = sinistro.repo.GetTransaction())
                {                    
                    obj.Save();
                    _id_sinistro = Convert.ToInt64(obj.id);
                    foreach(vei_reb_sinistros vr in listVR){
                        vei_reb_sinistros.repo.Save(new vei_reb_sinistros() { id_reboque = vr.id_reboque, id_veiculo = vr.id_veiculo, id_sinistro = _id_sinistro });
                    }
                    foreach(pagamentos_sinistro ps in listPag){
                        pagamentos_sinistro.repo.Save(new pagamentos_sinistro() { valor = ps.valor, observacao = ps.observacao, id_sinistros = _id_sinistro});
                    }

                    foreach(veiculo vei in listaDeTodosVeiculos()){
                        historico_veic_reb_sinistros.repo.Save(new historico_veic_reb_sinistros() { id_reboque = 0, id_veiculo = vei.id, identificador = 'v',
                            valor = vei.valor, id_sinistro = _id_sinistro });
                    }

                    foreach(reboque reb in listaDeTodosReboques()){
                        historico_veic_reb_sinistros.repo.Save(new historico_veic_reb_sinistros() { id_reboque = reb.id, id_veiculo = 0, identificador = 'r',
                            valor = reb.valor, id_sinistro = _id_sinistro});
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

        #endregion
    }
}
