using BoletoNet;
using System;
namespace SysNorteGrupo.Utils
{
    public class GerenteDeBoletos
    {

        public void geraBoleto(BoletoUtil boletoU, CedenteUtil cedenteU, SacadoUtil sacadoU)
        {
            Cedente cedente = new Cedente(cedenteU.cpfCnpjCedente, cedenteU.nomeCedente, cedenteU.agenciaCedente, cedenteU.contaCedente, cedenteU.digitoContaCedente);
            cedente.Codigo = cedenteU.codigoCedente;
            Boleto boleto = new Boleto(boletoU.dataVencimento, boletoU.valorBoleto, boletoU.carteiraBoleto, boletoU.nossoNumeroBoleto, cedente);
            boleto.NumeroDocumento = boletoU.numeroDocumento;
            Sacado sacado = new Sacado(sacadoU.cpfCnpjSacado, sacadoU.nomeSacado);
            boleto.Sacado = sacado;
            boleto.Sacado.Endereco.End = sacadoU.enderecoSacado;
            boleto.Sacado.Endereco.Bairro = sacadoU.bairroSacado;
            boleto.Sacado.Endereco.Cidade = sacadoU.cidadeSacado;
            boleto.Sacado.Endereco.CEP = sacadoU.cepSacado;
            boleto.Sacado.Endereco.UF = sacadoU.ufSacado;
            boleto.Instrucoes.Add(boletoU.instrucaoBoleto);
            boleto.EspecieDocumento = boletoU.especieDocumento;
            boleto.NumeroParcela = 0;
            boleto.DataProcessamento = boletoU.dataProcessamento;
            boleto.Aceite = boletoU.aceite;
            boleto.JurosMora = boletoU.jurosMora;
            boleto.PercJurosMora = boletoU.percJurosMora;
            boleto.PercMulta = boletoU.percMulta;


            BoletoBancario boleto_bancario = new BoletoBancario();
            boleto_bancario.CodigoBanco = boletoU.codigoBancoBoleto;
            boleto_bancario.Boleto = boleto;
            boleto_bancario.MostrarCodigoCarteira = boletoU.mostrarCodigoCarteira;
            boleto_bancario.Boleto.Valida();
            boleto_bancario.MostrarComprovanteEntrega = boletoU.mostrarComprovanteEntrega;
            boleto_bancario.MontaHtmlNoArquivoLocal(boletoU.diretorioNome);
        }

    }

    public class SacadoUtil
    {
        public string cpfCnpjSacado {get; set;}
        public string nomeSacado { get; set; }
        public string enderecoSacado { get; set; }
        public string bairroSacado { get; set; }
        public string cidadeSacado { get; set; }
        public string cepSacado { get; set; }
        public string ufSacado { get; set; }
    }

    public class CedenteUtil
    {
        public string codigoCedente { get; set; }
        public string cpfCnpjCedente { get; set; }
        public string nomeCedente { get; set; }
        public string agenciaCedente { get; set; }
        public string contaCedente { get; set; }
        public string digitoContaCedente { get; set; }
    }

    public class BoletoUtil
    {
        public DateTime dataVencimento { get; set; }
        public DateTime dataProcessamento { get; set; }
        public decimal valorBoleto { get; set; }
        public string carteiraBoleto { get; set; }
        public string numeroDocumento { get; set; }
        public string nossoNumeroBoleto { get; set; }
        public IInstrucao instrucaoBoleto { get; set; }
        public AbstractEspecieDocumento especieDocumento { get; set; }
        public short codigoBancoBoleto { get; set; }
        public bool mostrarCodigoCarteira { get; set; }
        public bool mostrarComprovanteEntrega { get; set; }
        public int numeroParcela { get; set; }
        public string aceite { get; set; }
        public decimal jurosMora { get; set; }
        public decimal percJurosMora { get; set; }
        public decimal percMulta { get; set; }

        public string diretorioNome { get; set; }
    }
}
