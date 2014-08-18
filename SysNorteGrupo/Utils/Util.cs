using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace SysNorteGrupo.Utils
{
    public static class Util
    {

        public static string chaveSecureApp = "a1s2 d3f4&beguta";

        public static bool textFieldIsEmpty(TextEdit textField)
        {
            string t = textField.Text.Trim();
            try
            {
                if (t == null || t.Equals(String.Empty) || t.Equals("0"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }

        public static string GetIpHost()
        {
            string _return = "";
            try
            {
                IPHostEntry ipEntry = Dns.GetHostByName(GetHostName());
                IPAddress[] addr = ipEntry.AddressList;
                _return = addr[0].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
            return _return;
        }

        public static string GetHostName()
        {
            string _return = "";
            try
            {
                 _return = Dns.GetHostName();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);           
            }
            return _return;
        }


        public static List<decimal> parcelar(decimal valor, int qntParcelas)
        {
            return parcelar(valor, qntParcelas, 2);
        }
        public static List<decimal> parcelar(decimal valor, int qntParcelas, int quantidadeDeDecimais = 2)
        {
            List<decimal> d = new List<decimal>();
            if (valor == 0 || qntParcelas == 0)
                return null;
            //divide sempre arredondando para baixo
            decimal pow = (decimal)Math.Pow(10, quantidadeDeDecimais);
            decimal valorParcelas = Math.Truncate(valor / qntParcelas * pow) / pow;
            //pega o valor da ultima parcela (com valor maior claro, valor de ajuste)
            decimal valorUltimaParcela = valor - (valorParcelas * (qntParcelas - 1));
            for (int i = 0; i < (qntParcelas - 1); i++)
            {
                d.Add(valorParcelas);
            }
            d.Add(valorUltimaParcela);
            return d;
        }
    }
}
