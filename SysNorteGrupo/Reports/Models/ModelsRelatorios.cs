
using System;
using System.Collections.Generic;
using System.Drawing;
namespace SysNorteGrupo.Reports
{
    #region 
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
    #endregion

    #region relatorio mensal de entrega para o cliente

    public class RelatorioGerencial
    {
        public decimal totalBensGrupo { get; set; }
        public decimal totalCotasGrupo { get; set; }
        public Image imagemExtratoBancario { get; set; }
        public DateTime datetimenow { get; set; }
        public string cliente { get; set; }
        public List<VeiculosEReboquesRelatorioGerencial> listVeiculosEReboques { get; set; }
        public decimal valoresCapitalizadosNoGrupo { get; set; }
        public decimal valoresAintegralizar { get; set; }
        public decimal valoresEmCaixa { get; set; }
        public decimal valoresPagosDeSinistrosAReintegralizar { get; set; }
        public decimal valoresDepositadosBancos { get; set; }
        public List<SinistrosRelatorioGerencial> listSinistros { get; set; }
    }

    public class VeiculosEReboquesRelatorioGerencial
    {
        public string veiculosReboque { get; set; }
        public decimal cotas { get; set; }
    }

    public class SinistrosRelatorioGerencial
    {
        public string clienteEPlacas { get; set; }
        public decimal orcamentos { get; set; }
        public decimal pagamentoMes { get; set; }
        public decimal valor_por_cota { get; set; }
        public decimal cotas_na_data { get; set; }
        public decimal subTotal { get; set; }
        public Image imgAnterior { get; set; }
        public Image imgSinistro { get; set; }
    }

    #endregion
}
