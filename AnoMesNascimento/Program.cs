using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO.Pipes;
using System.Text;

namespace DiaMesAnosNascimento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime agora = DateTime.Now;

            Console.WriteLine("Entre com a data do dia, més e ano nascimento (no formato DD/MM/YYYY):");
            String input = Console.ReadLine();

            // Converte a entrada do usuário para um objeto DateTime
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dataNascimento))
            {
                if (agora.Date == dataNascimento.Date)
                {
                    Console.WriteLine("Voce faz aniversário hojé. Parabéns!");
                    return;

                }
                if (dataNascimento.Date > agora.Date)
                {
                    Console.WriteLine("Você ainda não naceu!");
                    return;
                }
                // Calcula a diferença entre a data de nascimento e a data atual
                TimeSpan diferenca = agora - dataNascimento;
                // Calcula a idade em anos e fração dos dias
                int anos = (int)(diferenca.TotalDays / 365.25);
                int meses = (int)((diferenca.TotalDays % 365.25) / 30.44); // Esse calculo .25 e relacionado a uma fração do dia!
                int dias = (int)((diferenca.TotalDays % 365.25) % 30.44);

                imprimirResultado(anos, meses, dias);

            }
            else
            {
                Console.WriteLine("Formato inválido. Certifique-se de digitar a data no formato correto (DD/MM/AAAA).");
            }

        }
        private static void imprimeAnos(StringBuilder resultado, int anos)
        {
            resultado.Append(anos);
            resultado.Append(" ano");
            if (anos > 1)
                resultado.Append("s");
        }
        private static void imprimeMeses(StringBuilder resultado, int meses)
        {
            resultado.Append(meses);
            if (meses > 1)
                resultado.Append(" meses");
           else
                resultado.Append("mês");
        }
        private static void imprimeDias(StringBuilder resultado, int dias)
        {
            resultado.Append(dias);
            resultado.Append(" dia");
            if (dias > 1)
                resultado.Append("s");
        }

        private static Boolean temDias(int dias)
        {
            if (dias > 0)
                return true;
            return false;
        }

        private static Boolean temMeses(int meses)
        {
            if (meses > 0)
                return true;
            return false;
        }

        private static Boolean temAnos(int anos)
        {
            if (anos > 0)
                return true;
            return false;
        }
        private static void imprimirResultado(int anos, int meses, int dias)
        {
            StringBuilder resultado = new StringBuilder("Sua idade é: ");

            if (temAnos(anos))
            {

                if (temMeses(meses))
                {
                    if (temDias(dias)) // Ano, mes e dia
                    {
                        imprimeAnos(resultado, anos);
                        resultado.Append(", ");
                        imprimeMeses(resultado, meses);
                        resultado.Append(" e ");
                        imprimeDias(resultado, dias);
                    }
                    else //ano e mes
                    {
                        imprimeAnos(resultado, anos);
                        resultado.Append(" e ");
                        imprimeMeses(resultado, meses);
                    }
                }
                else //Não tem Mês
                {
                    if (temDias(dias)) // Ano e dia
                    {
                        imprimeAnos(resultado, anos);
                        resultado.Append(" e ");
                        imprimeDias(resultado, dias);
                    }
                    else //Ano
                    {
                        imprimeAnos(resultado, anos);
                    }
                }
            }
            else //Não tem Ano
            {
                if (temMeses(meses)) 
                {
                    if (temDias(dias)) //Mês e dia
                    {
                        imprimeMeses(resultado, meses);
                        resultado.Append(" e ");
                        imprimeDias(resultado, dias);
                    }
                    else //Mês
                    {
                        imprimeMeses(resultado, meses);
                    }
                }
                else //Não tem mês
                {
                    if(temDias(dias)) //Dia
                    {
                        imprimeDias(resultado, dias);
                    }
                    //O caso de não ter mês, ano e dia já foi tratado em outro lugar
                }
            }
            Console.WriteLine(resultado.ToString());
        }
    }

}





