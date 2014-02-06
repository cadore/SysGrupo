using System;
using System.Collections;

namespace SysNorteGrupo.Utils
{
    public class ListaAnos
    {
        public ArrayList retornaAnos()
        {
            ArrayList arr = new ArrayList();
            DateTime dt = DateTime.Now;
            int ano_inicio = 1960;
            int ano_atual = Convert.ToInt32(dt.Year);
            while(ano_inicio <= ano_atual){
                arr.Add(ano_inicio);
                ano_inicio++;
            }
            return arr;
        }
    }
}
