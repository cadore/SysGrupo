using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace EntitiesGrupo
{

	public partial class SysGrupoRepo : Database
	{
        public static string host = "localhost";
        public static string port = "5432";
        public static string user = "postgres";
        public static string passwd = "p@ssw0rd";
        public static string db = "sysgrupodb";

        public static string connectionName = String.Format("Server={0};Port={1};User id={2};password={3};Database={4};",
            host, port, user, passwd, db);
        public static string providerName = "Npgsql";
        public SysGrupoRepo()
            : base(connectionName, providerName)
		{
			CommonConstruct();
		}

		public SysGrupoRepo(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			SysGrupoRepo GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static SysGrupoRepo GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new SysGrupoRepo();
        }

		[ThreadStatic] static SysGrupoRepo _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static SysGrupoRepo repo { get { return SysGrupoRepo.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    
	[TableName("preferencias_do_sistema")]


	[ExplicitColumns]
    public partial class preferencias_do_sistema : SysGrupoRepo.Record<preferencias_do_sistema>  
    {



		[Column] public decimal valor_cota { get; set; }



	}


    [TableName("validacoes_sistema")]

    [PrimaryKey("id")]

    [ExplicitColumns]
    public partial class validacoes_sistema : SysGrupoRepo.Record<validacoes_sistema>
    {
        [Column] public long id { get; set; }
        [Column] public DateTime data_verificacao { get; set; }
        [Column] public DateTime data_expiracao { get; set; }
        [Column] public bool inativo { get; set; }
    }

    
	[TableName("cad_estados")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class estado : SysGrupoRepo.Record<estado>  
    {



		[Column] public long id { get; set; }





		[Column] public string uf { get; set; }





		[Column] public string nome_estado { get; set; }





		[Column] public string cod_ibge { get; set; }



	}

    
	[TableName("cad_enderecos")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class endereco : SysGrupoRepo.Record<endereco>  
    {



		[Column] public long id { get; set; }





		[Column] public string cep { get; set; }





        [Column("endereco")] public string _endereco { get; set; }





		[Column] public long bairro_id { get; set; }





		[Column] public long id_cidades { get; set; }



	}

    
	[TableName("cad_bairros")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class bairro : SysGrupoRepo.Record<bairro>  
    {



		[Column] public long id { get; set; }





		[Column] public string nome_bairro { get; set; }





		[Column] public long id_cidades { get; set; }



	}

    
	[TableName("veiculos")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class veiculo : SysGrupoRepo.Record<veiculo>  
    {



		[Column] public long id { get; set; }





		[Column] public long id_cliente { get; set; }





		[Column] public decimal tara { get; set; }





		[Column] public decimal capacidade { get; set; }





		[Column] public string pot_cil { get; set; }





		[Column] public decimal valor { get; set; }





		[Column] public string placa { get; set; }





		[Column] public int ano_fabricacao { get; set; }





		[Column] public string cod_renavam { get; set; }





		[Column] public string numero_chassi { get; set; }





		[Column] public string tipo_combustivel { get; set; }





		[Column] public long id_cidades { get; set; }



        [Column] public string uf_estado { get; set; }




		[Column] public string cor_predominante { get; set; }





		[Column] public long id_especies_veiculos { get; set; }





		[Column] public string id_modelo_veiculos { get; set; }





		[Column] public long id_marca_veiculos { get; set; }





		[Column] public long id_ano_modelo_veiculos { get; set; }





		[Column] public string observacao { get; set; }





		[Column] public bool inativo { get; set; }





		[Column] public DateTime data_cadastro { get; set; }





		[Column] public DateTime data_ativacao { get; set; }





		[Column] public DateTime data_inativacao { get; set; }

        [Column] public bool gerada_parcela_cc { get; set; }


        public string nome_cliente { get; set; }


        public decimal cotas { get; set; }



	}

    
	[TableName("cliente")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cliente : SysGrupoRepo.Record<cliente>  
    {



		[Column] public long id { get; set; }





		[Column] public string nome_completo { get; set; }





		[Column] public string tipo_cliente { get; set; }





		[Column] public string documento { get; set; }





		[Column] public string inscricao_rg { get; set; }





		[Column] public bool isento_ICMS { get; set; }





		[Column] public string telefone_fixo { get; set; }





		[Column] public string telefone_celular { get; set; }





		[Column] public string email_principal { get; set; }





		[Column] public string email_secundario { get; set; }





		[Column] public string numero { get; set; }





		[Column] public string complemento { get; set; }





		[Column] public string cep { get; set; }





		[Column] public string referencia_comercial { get; set; }





		[Column] public string contato_referencia_comercial { get; set; }





		[Column] public string referencia_de_servico { get; set; }





		[Column] public string contato_referencia_de_servico { get; set; }





		[Column] public string referencia_de_transporte { get; set; }





		[Column] public string contato_referencia_de_transporte { get; set; }





		[Column] public string observacoes { get; set; }





		[Column] public DateTime data_cadastro { get; set; }





		[Column] public DateTime data_ativacao { get; set; }





		[Column] public DateTime data_inativacao { get; set; }





		[Column] public bool inativo { get; set; }





		[Column] public long id_cidades { get; set; }





		[Column] public long id_enderecos { get; set; }





		[Column] public long id_bairros { get; set; }
        


        [Column]
        public string uf_estado { get; set; }



        public decimal cotas { get; set; }



        public decimal valor_total { get; set; }


	}
    
	[TableName("cad_cidades")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class cidade : SysGrupoRepo.Record<cidade>  
    {



		[Column] public long id { get; set; }





		[Column("cidade")] public string nome_cidade { get; set; }





		[Column] public string uf { get; set; }





		[Column] public string cod_ibge { get; set; }





		[Column] public long area { get; set; }



	}

    
	[TableName("usuarios")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class usuario : SysGrupoRepo.Record<usuario>  
    {



		[Column] public long id { get; set; }





		[Column] public string login { get; set; }





		[Column] public string senha { get; set; }





		[Column] public string nome_completo { get; set; }





		[Column] public string contato { get; set; }





		[Column] public string email { get; set; }





		[Column] public bool inativo { get; set; }



	}

    
	[TableName("permicoes_usuarios")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class permicoes_usuario : SysGrupoRepo.Record<permicoes_usuario>  
    {



		[Column] public long id { get; set; }





		[Column] public long id_usuarios { get; set; }





		[Column] public bool financeiro { get; set; }





		[Column] public bool usuarios { get; set; }





		[Column] public bool relatorios { get; set; }





		[Column] public bool cadastrar_veiculo { get; set; }





		[Column] public bool inativar_veiculo { get; set; }





		[Column] public bool cadastrar_cliente { get; set; }





		[Column] public bool inativar_cliente { get; set; }





		[Column] public bool cadastrar_sinistro { get; set; }





		[Column] public bool finalizar_sinistro { get; set; }





		[Column] public bool inativar_sinistro { get; set; }



	}

    
	[TableName("sinistros")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class sinistro : SysGrupoRepo.Record<sinistro>  
    {   



		[Column] public long id { get; set; }





		[Column] public long situacao_sinistro { get; set; }





		[Column] public DateTime? data_ocorrido { get; set; }





		[Column] public DateTime? data_conclusao { get; set; }





		[Column] public DateTime data_cadastro { get; set; }





		[Column] public DateTime data_inativacao { get; set; }





		[Column] public string observacoes { get; set; }





		[Column] public string numero_bo { get; set; }





		[Column] public long id_cliente { get; set; }




        [Column]
        public long id_veiculo { get; set; }



        [Column]
        public long id_reboque1 { get; set; }



        [Column]
        public long id_reboque2 { get; set; }



        [Column]
        public long id_reboque3 { get; set; }




        [Column]
        public decimal cotas_na_data { get; set; }




        [Column]
        public int clientes_no_rateio { get; set; }


        [Column]
        public decimal valor_total { get; set; }




        public string nome_cliente { get; set; }




        public string situacao { get; set; }



        public string veiculos_reboques { get; set; }



	}




    [TableName("historico_veic_reb_sinistros")]


    [PrimaryKey("id")]



    [ExplicitColumns]
    public partial class historico_veic_reb_sinistros : SysGrupoRepo.Record<historico_veic_reb_sinistros>
    {


        [Column]
        public long id { get; set; }
        [Column]
        public long id_sinistro { get; set; }
        [Column]
        public long id_veiculo { get; set; }
        [Column]
        public long id_reboque { get; set; }
        [Column]
        public long id_cliente { get; set; }
        [Column]
        public char identificador { get; set; }
        [Column]
        public decimal valor { get; set; }
        [Column]
        public decimal valor_a_pagar { get; set; }
    }




    
	[TableName("pagamentos_sinistro")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class pagamentos_sinistro : SysGrupoRepo.Record<pagamentos_sinistro>  
    {



		[Column] public long id { get; set; }





		[Column] public decimal valor { get; set; }





		[Column] public string observacao { get; set; }





		[Column] public long id_sinistros { get; set; }



	}

    
	[TableName("modelo_veiculos")]


	[PrimaryKey("id", autoIncrement=false)]

	[ExplicitColumns]
    public partial class modelo_veiculo : SysGrupoRepo.Record<modelo_veiculo>  
    {



		[Column] public string id { get; set; }





		[Column] public string nome { get; set; }





		[Column] public long marca { get; set; }





		[Column] public string tipo { get; set; }



	}

    
	[TableName("especies_veiculos")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class especies_veiculo : SysGrupoRepo.Record<especies_veiculo>  
    {



		[Column] public long id { get; set; }





		[Column] public string especie { get; set; }



	}



    [TableName("especies_reboques")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class especies_reboque : SysGrupoRepo.Record<especies_reboque>
    {



        [Column]
        public long id { get; set; }





        [Column]
        public string especie { get; set; }



    }

    
	[TableName("marca_veiculos")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class marca_veiculo : SysGrupoRepo.Record<marca_veiculo>  
    {



		[Column] public long id { get; set; }





		[Column] public string nome { get; set; }





		[Column] public string tipo { get; set; }



	}


    [TableName("reboques")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class reboque : SysGrupoRepo.Record<reboque>  
    {
        
		[Column] public long id { get; set; }


		[Column] public long id_cliente { get; set; }


        [Column] public string renavam { get; set; }


        [Column] public int ano_modelo { get; set; }


        [Column] public string cor_carroceria { get; set; }


        [Column] public decimal tara { get; set; }


        [Column] public long id_especies_reboques { get; set; }


        [Column] public int ano_fabricacao { get; set; }

        [Column] public string chassi { get; set; }

		[Column] public string placa { get; set; }

        [Column] public string marca { get; set; }
        
        [Column] public string modelo { get; set; }
        
		[Column] public decimal capacidade { get; set; }


		[Column] public string cor_chassi { get; set; }

        
        [Column] public DateTime data_cadastro { get; set; }


        [Column] public DateTime data_ativacao { get; set; }


        [Column] public DateTime data_inativacao { get; set; }

        [Column] public bool inativo { get; set; }


        [Column] public long id_cidade { get; set; }


        [Column] public decimal valor { get; set; }

        [Column] public string uf_estado { get; set; }

        [Column] public long id_veiculo { get; set; }

        [Column] public int ordem { get; set; }

        public string nome_cliente { get; set; }


        public decimal cotas { get; set; }
	}

    
	[TableName("ano_modelo_veiculos")]


	[PrimaryKey("id")]



	[ExplicitColumns]
    public partial class ano_modelo_veiculo : SysGrupoRepo.Record<ano_modelo_veiculo>  
    {



		[Column] public long id { get; set; }





		[Column] public string nome { get; set; }





		[Column] public string modelo { get; set; }





		[Column] public decimal valor { get; set; }





		[Column] public string tipo { get; set; }



	}

    [TableName("empresa")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class empresa : SysGrupoRepo.Record<empresa>
    {
        [Column] public long id { get; set; }

        [Column] public string razao_social { get; set; }

        [Column] public string nome_fantasia { get; set; }
        
        [Column] public string cnpj { get; set; }
    }

    [TableName("empresa_dados_bancarios")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class empresa_dados_bancarios : SysGrupoRepo.Record<empresa_dados_bancarios>
    {
        [Column] public long id { get; set; }

        [Column] public long id_cliente { get; set; }

        [Column] public string codigo_banco { get; set; }

        [Column] public string agencia { get; set; }

        [Column] public string conta { get; set; }

        [Column] public string digito_conta { get; set; }
    }

    [TableName("parcelas_sinistros")]
    [PrimaryKey("id")]
    public partial class parcelas_sinistros : SysGrupoRepo.Record<parcelas_sinistros>
    {
        public long id { get; set; }
        public int numero_parcela { get; set; }
        public decimal valor { get; set; }
        public int mes_parcela { get; set; }
        public int ano_parcela { get; set; }
        public long id_sinistro { get; set; }
        public long id_cliente { get; set; }
        public bool gerado_conta_receber { get; set; }
    }


    [TableName("parcelas_veiculos_cc")]
    [PrimaryKey("id")]
    public partial class parcelas_veiculos_cc : SysGrupoRepo.Record<parcelas_veiculos_cc>
    {
        public long id { get; set; }
        public int numero_parcela { get; set; }
        public decimal valor { get; set; }
        public int mes_parcela { get; set; }
        public int ano_parcela { get; set; }
        public long id_veiculo { get; set; }
        public long id_cliente { get; set; }
        public bool gerado_conta_receber { get; set; }
    }


    [TableName("mensalidades_veiculos")]
    [PrimaryKey("id")]
    public partial class mensalidades_veiculos : SysGrupoRepo.Record<mensalidades_veiculos>
    {
        public long id { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public long id_veiculo { get; set; }
        public long id_cliente { get; set; }
        public decimal valor { get; set; }
    }

    [TableName("contas_a_receber")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    public partial class contas_a_receber : SysGrupoRepo.Record<contas_a_receber>
    {
        [Column]
        public long id { get; set; }
        [Column]
        public long id_cliente { get; set; }
        [Column]
        public DateTime data_documento { get; set; }
        [Column]
        public DateTime data_vencimento { get; set; }
        [Column]
        public DateTime data_quitacao { get; set; }
        [Column]
        public decimal valor_total { get; set; }
        [Column]
        public decimal valor_desconto { get; set; }
        [Column]
        public decimal valor_quitado { get; set; }
        [Column]
        public bool gerado_boleto { get; set; }
        [Column]
        public string descricao { get; set; }

        public string nome_cliente { get; set; }
    }


    public partial class log
    {

        public string eventLog { get; set; }

        public string message { get; set; }

        public string user { get; set; }

        public string dateTime { get; set; }

        public string host { get; set; }
    }

    public partial class ParcelaUtil
    {
        public int numero_parcelas { get; set; }
        public decimal valor { get; set; }
        public int mes_parcela { get; set; }
        public int ano_parcela { get; set; }
    }

}