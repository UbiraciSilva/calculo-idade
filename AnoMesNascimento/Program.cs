using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO.Pipes;
using System.Text;

namespace AnoMesNascimento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime agora = DateTime.Now;
            // Digite a data de nascimento!
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
        private static void adicionaAno(StringBuilder resultado, int anos)
        {

            resultado.Append(anos);
            resultado.Append(" anos");

        }
        private static void adicionaMeses(StringBuilder resultado, int meses)
        {

            resultado.Append(meses);
            resultado.Append(" meses");

        }
        private static void adicionaDias(StringBuilder resultado, int dias)
        {

            resultado.Append(dias);
            resultado.Append(" dias");

        }
        private static void imprimirResultado(int anos, int meses, int dias)
        {
            StringBuilder resultado = new StringBuilder("Sua idade é: ");

            if (anos > 0)
            {
                adicionaAno(resultado, anos);


                if (meses > 0)
                {
                    if (dias > 0) // Ano, mes e dia
                    {
                        resultado.Append(", ");
                        adicionaMeses(resultado, meses);
                        resultado.Append(" e ");
                        adicionaDias(resultado, dias);
                    }
                    else// ano e mes
                    {
                        resultado.Append(" e ");
                        adicionaMeses(resultado, meses);

                    }
                }
                else if (dias > 0) // Ano e dia
                {
                    resultado.Append(" e ");
                    adicionaDias(resultado, dias);

                }
            }
            else if (meses > 0) //
            {
                resultado.Append(meses);
                resultado.Append(" meses");
                if (dias > 0)
                {
                    resultado.Append(" e ");
                    adicionaDias(resultado, dias);
                }

            }
            Console.WriteLine(resultado.ToString());
        }
    }

}





