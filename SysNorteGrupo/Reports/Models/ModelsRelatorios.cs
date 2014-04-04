using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace SysNorteGrupo.Reports
{
    #region relatorio de cotas por cliente

    public class RelatorioClientesECotasModel
    {
        public decimal percentCotas { get; set; }
        public decimal cotas { get; set; }
        public decimal valorTotalDeBens { get; set; }
        public DateTime dataInclusao { get; set; }
        public string nomeCliente { get; set; }
    }
    #endregion
    public class ListaClientesRateio
    {        
        public string cliente { get; set; }
        public decimal totalParticipacao { get; set; }
        public List<VeiculosRelatorio> listaVeiculo { get; set; }        
    }

    public class ListaClientesInclusao
    {
        public string cliente { get; set; }
        public decimal totalDeBens { get; set; }
        public decimal totalDeCotas { get; set; }
        public DateTime dataInclusao { get; set; }
        public List<VeiculosRelatorio> listaVeiculo { get; set; }
    }



    public class ReboquesRelatorio
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public decimal valor { get; set; }
        public string cotas { get; set; }
        public decimal participacao { get; set; }
    }

    public class VeiculosRelatorio
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public decimal valor { get; set; }
        public string cotas { get; set; }
        public decimal participacao { get; set; }
        public List<ReboquesRelatorio> listaReboques { get; set; }
    }

    public class PagamentosSinistroRelatorio
    {
        public decimal valor { get; set; }
        public string observação { get; set; }
    }

    public class ConclusaoSinistro
    {
        public string cliente { get; set; }
        public string veiculoReboquesSinistrados { get; set; }
        public decimal valorTotalDosBensSinistrados { get; set; }
        public string cotasDosBensSinistrados { get; set; }
        public string dataOcorrido { get; set; }
        public string dataConclusao { get; set; }
        public string boletimOcorrencia { get; set; }
        public string observacao { get; set; }
        public decimal valorTotalSinistro { get; set; }
        public decimal cotasNaData { get; set; }
        public decimal valorPorCota { get; set; }
        public string totalDeClientes { get; set; }
        public string franquia { get; set; }
        public List<PagamentosSinistroRelatorio> listaPagamentos { get; set; }
    }
}
