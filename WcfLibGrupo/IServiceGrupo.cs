using EntitiesGrupo;
using ServicosSysFileManager.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfLibGrupo
{
    [ServiceContract]
    public interface IServiceGrupo
    {
        #region sistema

        [OperationContract]
        DateTime retornaDataHoraLocal();

        [OperationContract]
        DateTime retornaDataHoraUTC();

        [OperationContract]
        Color backColorFoco();

        [OperationContract]
        decimal franquiaSinistro();

        [OperationContract]
        decimal valorPorCota();

        #endregion

        #region logs

        [OperationContract]
        int createLog(log _log);

        [OperationContract]
        List<log> ReadLog(string parameter, string parameterTwo, string parameterThree);

        #endregion

        #region BackupDB

        [OperationContract]
        string createBackup(string password);

        [OperationContract]
        bool restoreBackup(string fileInput, string password);

        #endregion

        #region empresa

        [OperationContract]
        empresa retornaEmpresa();

        [OperationContract]
        decimal retornaTotalDeBensDaEmpresaPorInatividade(bool inativo);

        #endregion

        #region usuarios
        [OperationContract]
        long salvarUsuario(usuario obj, permicoes_usuario pu);

        [OperationContract]
        List<usuario> listaDeUsuariosAtivos();

        [OperationContract]
        List<usuario> listaDeTodosUsuarios();

        [OperationContract]
        usuario recuperaUsuarioPorId(long id);

        [OperationContract]
        List<usuario> listaDeUsuariosAtivosPorNomeOuLogin(string nome);

        [OperationContract]
        bool verificaSeLoginEhUnico(string login, bool edit);

        [OperationContract]
        bool verificaUsuarioAtivoPorLoginESenha(string login, string senha);

        [OperationContract]
        List<usuario> listaDeUsuariosAtivosPorId(long id);

        [OperationContract]
        permicoes_usuario recuperaPermicoesDoUsuarioPorIdUsuario(long id_usuario);

        [OperationContract]
        usuario recuperaUsuarioPorLoginEhSenha(string login, string senha);
        #endregion

        #region clientes
        [OperationContract]
        long salvarCliente(cliente obj);

        [OperationContract]
        List<cliente> listaDeTodosClientes();

        [OperationContract]
        List<cliente> listaDeClientesPorInatividade(bool inativo);

        [OperationContract]
        List<cliente> listaDeClientesPorId(long id);

        [OperationContract]
        List<cliente> listaDeClientesPorNomeOuDocumento(string nome_documento, bool inativo);

        [OperationContract]
        cliente retornaClientePorId(long id);

        [OperationContract]
        bool verificaSeCpfCnpjEhUnico(string doc, bool vazio);

        [OperationContract]
        bool verificaSeEmailPrincipalEhUnico(string email, bool vazio);

        [OperationContract]
        bool verificaSeInscricaoRgEhUnico(string insc, bool vazio);

        [OperationContract]
        int countClientesPorDataDeAtivacao(DateTime? data);

        [OperationContract]
        List<cliente> listaDeClientesPorDataDeAtivacao(DateTime? data);

        [OperationContract]
        long totalDeClientesPorInatividade(bool inativo);

        #endregion

        #region fipe

        [OperationContract]
        List<marca_veiculo> listaDeMarcas();

        [OperationContract]
        List<modelo_veiculo> listaDeModelosPorIdMarca(long id_marca);

        [OperationContract]
        List<ano_modelo_veiculo> listaDeAnoModelosPorIdModelo(string id_modelo);

        [OperationContract]
        ano_modelo_veiculo recuperaValorPorIdModelo(long id_modelo);

        [OperationContract]
        modelo_veiculo retornaModeloPorId(string id_modelo);

        #endregion

        #region veiculos

        [OperationContract]
        long salvarVeiculo(veiculo veiculo_obj);

        [OperationContract]
        veiculo retornaVeiculoPorId(long id_veiculo);

        [OperationContract]
        List<especies_veiculo> listaDeEspeciesVeiculos();

        [OperationContract]
        List<veiculo> listaDeVeiculosPorIdCliente(long id_cliente);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorIdClienteEDataAtivacao(long id_cliente, DateTime data_ativacao);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorInatividade(bool inativo);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorPlaca(string placa, bool inativo);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorId(long id, bool inativo);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorIdClienteEInatividade(long id_cliente, bool inativo);

        [OperationContract]
        decimal somaDeValoresDeVeiculosPorInatividade(bool inativo);

        [OperationContract]
        bool verificaSePlacaVeiculoEhUnica(string placa, bool edit);        

        [OperationContract]
        bool verificaSeNChassiEhUnico(string chassi, bool edit);

        [OperationContract]
        bool verificaSeRenavamEhUnico(string renavam, bool edit);

        [OperationContract]
        decimal somaValorTotalVeiculoPorIdClienteEInatividade(long id_cliente, bool inativo);

        [OperationContract]
        decimal somaValorTotalVeiculoPorDataAtivacao(DateTime? data);

        [OperationContract]
        List<veiculo> listaDeTodosVeiculos();

        [OperationContract]
        long totalDeVeiculosPorInatividade(bool inativo);

        #endregion

        #region reboques

        [OperationContract]
        long salvarReboques(List<reboque> reboques);

        [OperationContract]
        long salvarReboque(reboque reboq);

        [OperationContract]
        reboque retornaReboquePorId(long id_reboque);

        [OperationContract]
        List<reboque> listaDeTodosReboques();

        [OperationContract]
        List<especies_reboque> listaDeEspeciesReboques();

        [OperationContract]
        List<reboque> listaDeReboquesPorInatividade(bool inativo);

        [OperationContract]
        List<reboque> listaDeReboquesPorPlaca(string placa, bool inativo);

        [OperationContract]
        List<reboque> listaDeReboquesPorId(long id, bool inativo);

        [OperationContract]
        List<reboque> listaDeReboquesPorIdCliente(long id_cliente, bool inativo);

        [OperationContract]
        List<reboque> listaDeReboquesPorIdVeiculo(long id_veiculo, bool inativo);

        [OperationContract]
        List<reboque> listaDeReboquesPorIdVeiculoEdataAtivacao(long id_veiculo, DateTime data);

        [OperationContract]
        decimal somaDeValoresDeReboquesPorInatividade(bool inativo);

        [OperationContract]
        bool verificaSePlacaReboqueEhUnica(string placa, bool edit);

        [OperationContract]
        bool verificaSeNChassiReboqueEhUnico(string chassi, bool edit);

        [OperationContract]
        bool verificaSeRenavamReboqueEhUnico(string renavam, bool edit);

        [OperationContract]
        decimal somaValorTotalReboquesPorIdClienteEInatividade(long id_cliente, bool inativo);

        [OperationContract]
        decimal somaValorTotalReboquesPorDataAtivacao(DateTime? data);

        [OperationContract]
        void excluiReboquePorId(long id);

        [OperationContract]
        long totalDeReboquesPorInatividade(bool inativo);
        #endregion

        #region cidades, bairros, enderecos

        [OperationContract]
        long SalvaBairro(bairro obj);

        [OperationContract]
        long SalvaEndereco(endereco obj);

        [OperationContract]
        List<estado> listaDeEstados();

        [OperationContract]
        List<cidade> listaDeCidadesPorEstado(string estado);

        [OperationContract]
        List<bairro> listaDeBairrosPorCidade(long id_cidade);

        [OperationContract]
        List<endereco> listaDeEnderecosPorCidade(long id_cidade);

        #endregion

        #region arquivos

        [OperationContract]
        List<ArquivosModel> retornaTodosArquivosPorDiretorio(string diretorio);

        [OperationContract]
        bool upload(Byte[] b1, string nome_completo);

        [OperationContract]
        Byte[] download(string nome_completo);

        [OperationContract]
        bool verificaArquivoExistente(string arquivo);

        [OperationContract]
        bool verificaDiretorioExistente(string diretorio);

        [OperationContract]
        void criaDiretorio(string diretorio);

        [OperationContract]
        void excluirArquivo(string nome_completo);

        #endregion

        #region diretorios

        [OperationContract]
        string SUBDIR_EMPRESA();
        [OperationContract]
        string SUBDIR_CLIENTES();
        [OperationContract]
        string SUBDIR_VEICULOS();
        [OperationContract]
        string SUBDIR_REBOQUES();
        [OperationContract]
        string SUBDIR_SINISTROS();     

        #endregion

        #region e-mail
        [OperationContract]
        bool EnviaEmail(List<string> destinatarios, string cc, string bcc, string assunto, string menssagem, bool html, MailPriority prioridade, List<FileInfo> anexos);

        #endregion

        #region sinistros

        [OperationContract]
        long SalvaSinistro(sinistro obj, List<pagamentos_sinistro> listPag);        

        [OperationContract]
        List<sinistro> listaDeSinistrosPorIdESituacao(long id_sinistro, int situacao);

        [OperationContract]
        List<sinistro> listaDeSinistrosPorId(long id_sinistro);

        [OperationContract]
        List<pagamentos_sinistro> listaDePagamentosSinistrosPorIdSinistro(long id_sinistro);

        [OperationContract]
        List<sinistro> listaDeSinistrosPorSituacao(int situacao);

        [OperationContract]
        List<sinistro> listaDeSinistrosPorIdClienteESituacao(long id_cliente, int situacao);

        [OperationContract]
        List<sinistro> listaDeSinistrosPorIdCliente(long id_cliente);

        [OperationContract]
        List<sinistro> listaDeSinistroPorIdVeiculo(long id_veiculo);

        [OperationContract]
        List<sinistro> listaDeSinistroPorIdVeiculoESituacao(long id_veiculo, int situacao);

        [OperationContract]
        List<sinistro> listaDeSinistroPorIdReboque(long id_reboque);

        [OperationContract]
        List<sinistro> listaDeSinistroPorIdReboqueESituacao(long id_reboque, int situacao);

        [OperationContract]
        decimal somaDePagamentosSinistrosPorIdSinistro(long id_sinistro);

        [OperationContract]
        List<sinistro> listaDeTodosSinistros();

        [OperationContract]
        bool verificaSeVeiculoEstaEmSinistroAtivo(long idVeiculo, bool edit, int situacaoSinistro);

        [OperationContract]
        bool verificaSeReboqueEstaEmSinistroAtivo(long idVeiculo, bool edit, int situacaoSinistro, int numeroReboque);

        [OperationContract]
        long totalDeSinistrosPorSituacao(int situacao);

        #endregion
    }
}
