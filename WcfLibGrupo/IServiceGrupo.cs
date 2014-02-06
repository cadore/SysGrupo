﻿using EntitiesGrupo;
using ServicosSysFileManager.Repository;
using System;
using System.Collections.Generic;
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
        DateTime retornaHoraLocal();

        [OperationContract]
        DateTime retornaHoraUTC();

        #endregion

        #region usuarios
        [OperationContract]
        long salvarUsuario(usuario obj, permicoes_usuario pu);

        [OperationContract]
        List<usuario> listaDeUsuariosAtivos();

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
        bool verificaSeCpfCnpjEhUnico(string doc);

        [OperationContract]
        bool verificaSeEmailPrincipalEhUnico(string email);

        [OperationContract]
        bool verificaSeInscricaoRgEhUnico(string insc);

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

        #endregion

        #region veiculos

        [OperationContract]
        long salvarVeiculo(veiculo veiculo_obj);

        [OperationContract]
        List<especies_veiculo> listaDeEspeciesVeiculos();

        [OperationContract]
        List<veiculo> listaDeVeiculosPorInatividade(bool inativo);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorPlaca(string placa, bool inativo);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorId(long id, bool inativo);

        [OperationContract]
        List<veiculo> listaDeVeiculosPorIdCliente(long id_cliente, bool inativo);

        [OperationContract]
        decimal somaDeValoresDeVeiculosPorInatividade(bool inativo);

        [OperationContract]
        bool verificaSePlacaVeiculoEhUnica(string placa, bool edit);        

        [OperationContract]
        bool verificaSeNChassiEhUnico(string chassi, bool edit);

        [OperationContract]
        bool verificaSeRenavamEhUnico(string renavam, bool edit);

        #endregion

        #region cidades, bairros, enderecos

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

        #region e-mail
        [OperationContract]
        bool EnviaEmail(List<string> destinatarios, string cc, string bcc, string assunto, string menssagem, bool html, MailPriority prioridade, List<FileInfo> anexos);

        #endregion
    }

}
