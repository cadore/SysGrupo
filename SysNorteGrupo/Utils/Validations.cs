using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SysNorteGrupo.Utils
{
    public static class Validations
    {
        public static bool validCPF(string CPF)
        {

            int[] Multiplier = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] MultiplierII = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digit;

            int _Sum;
            int _Rest;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if ((CPF.Length != 11) || (CPF == "00000000000") || (CPF == "11111111111") ||
                (CPF == "22222222222") || (CPF == "33333333333") || (CPF == "44444444444") || (CPF == "55555555555") ||
                (CPF == "66666666666") || (CPF == "77777777777") || (CPF == "88888888888") || (CPF == "99999999999"))
            {
                return false;
            }
            TempCPF = CPF.Substring(0, 9);

            _Sum = 0;

            for (int i = 0; i < 9; i++)
            {
                _Sum += int.Parse(TempCPF[i].ToString()) * (Multiplier[i]);
            }
            _Rest = _Sum % 11;

            if (_Rest < 2)
            {
                _Rest = 0;
            }
            else
            {
                _Rest = 11 - _Rest;
            }

            Digit = _Rest.ToString();
            TempCPF = TempCPF + Digit;
            int _SumII = 0;

            for (int i = 0; i < 10; i++)
            {
                _SumII += int.Parse(TempCPF[i].ToString()) * MultiplierII[i];
            }

            _Rest = _SumII % 11;

            if (_Rest < 2)
            {
                _Rest = 0;
            }
            else
            {
                _Rest = 11 - _Rest;
            }

            Digit = Digit + _Rest.ToString();
            return CPF.EndsWith(Digit);
        }

        public static bool validCNPJ(string CNPJ)
        {
            CNPJ = CNPJ.Trim();
            CNPJ = CNPJ.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            CNPJ = CNPJ.Replace("+", "").Replace("*", "").Replace(",", "").Replace("?", "");
            CNPJ = CNPJ.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            CNPJ = CNPJ.Replace("%", "").Replace("¨", "").Replace("&", "").Replace("(", "");
            CNPJ = CNPJ.Replace("=", "").Replace("[", "").Replace("]", "").Replace(")", "");
            CNPJ = CNPJ.Replace("{", "").Replace("}", "").Replace(":", "").Replace(";", "");
            CNPJ = CNPJ.Replace("<", "").Replace(">", "").Replace("ç", "").Replace("Ç", "");

            switch (CNPJ)
            {       //00000000000000
                case "11111111111111":
                    return false;
                case "00000000000000":
                    return false;
                case "22222222222222":
                    return false;
                case "33333333333333":
                    return false;
                case "44444444444444":
                    return false;
                case "55555555555555":
                    return false;
                case "66666666666666":
                    return false;
                case "77777777777777":
                    return false;
                case "88888888888888":
                    return false;
                case "99999999999999":
                    return false;
            }
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            int resto;
            string digito;
            string tempCnpj;
            CNPJ = CNPJ.Trim();
            CNPJ = CNPJ.Replace(
            ".", "").Replace("-", "").Replace("/", "");
            if (CNPJ.Length != 14)
                return false;
            tempCnpj = CNPJ.Substring(0, 12);
            for (int i = 0; i < 12; i++)
                soma +=
                int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma +=
                int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto;
            return CNPJ.EndsWith(digito);
        }

        /// <summary>
        /// Valida se um cpf é válido
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>

        // o metodo isCPFCNPJ recebe dois parâmetros:
        // uma string contendo o cpf ou cnpj a ser validado
        // e um valor do tipo boolean, indicando se o método irá
        // considerar como válido um cpf ou cnpj em branco.
        // o retorno do método também é do tipo boolean:
        // (true = cpf ou cnpj válido; false = cpf ou cnpj inválido)
        public static bool isCPFCNPJ(string cpfcnpj, bool vazio)
        {
            if (string.IsNullOrEmpty(cpfcnpj))
                return vazio;
            else
            {
                int[] d = new int[14];
                int[] v = new int[2];
                int j, i, soma;
                string Sequencia, SoNumero;

                SoNumero = Regex.Replace(cpfcnpj, "[^0-9]", string.Empty);

                //verificando se todos os numeros são iguais
                if (new string(SoNumero[0], SoNumero.Length) == SoNumero) return false;

                // se a quantidade de dígitos numérios for igual a 11
                // iremos verificar como CPF
                if (SoNumero.Length == 11)
                {
                    for (i = 0; i <= 10; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 8 + i; j++) soma += d[j] * (10 + i - j);

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[9] & v[1] == d[10]);
                }
                // se a quantidade de dígitos numérios for igual a 14
                // iremos verificar como CNPJ
                else if (SoNumero.Length == 14)
                {
                    Sequencia = "6543298765432";
                    for (i = 0; i <= 13; i++) d[i] = Convert.ToInt32(SoNumero.Substring(i, 1));
                    for (i = 0; i <= 1; i++)
                    {
                        soma = 0;
                        for (j = 0; j <= 11 + i; j++)
                            soma += d[j] * Convert.ToInt32(Sequencia.Substring(j + 1 - i, 1));

                        v[i] = (soma * 10) % 11;
                        if (v[i] == 10) v[i] = 0;
                    }
                    return (v[0] == d[12] & v[1] == d[13]);
                }
                // CPF ou CNPJ inválido se
                // a quantidade de dígitos numérios for diferente de 11 e 14
                else return false;
            }
        }

        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string cInsc, string cUF);

        public static bool validIE(string ie, string estado)
        {
            int retorno = ConsisteInscricaoEstadual(ie, estado);

            if (retorno == 0)
                return true;
            else
                return false;
        }
    }
}
