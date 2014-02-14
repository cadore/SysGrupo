﻿using System.Collections.Generic;
using System.Windows.Documents;

namespace SysNorteGrupo.Reports
{
    public class ListaConclusaoSinistro
    {        
        public string cliente { get; set; }
        public List<VeiculosRelatorio> listaVeiculo { get; set; }        
    }

    public class ReboquesRelatorio
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string valor { get; set; }
        public string cotas { get; set; }
    }

    public class VeiculosRelatorio
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string valor { get; set; }
        public string cotas { get; set; }
        public List<ReboquesRelatorio> listaReboques { get; set; }
    }

    public class PagamentosSinistroRelatorio
    {
        public string valor { get; set; }
        public string observação { get; set; }
    }

    public class ConclusaoSinistro
    {
        public string veiculoReboquesSinistrados { get; set; }
        public string dataOcorrido { get; set; }
        public string dataConclusao { get; set; }
        public string boletimOcorrencia { get; set; }
        public string observacao { get; set; }
        public List<PagamentosSinistroRelatorio> listaPagamentos { get; set; }
    }
}
