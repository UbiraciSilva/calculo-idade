using System.ComponentModel;
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
                // Calcula a diferença entre a data de nascimento e a data atual
                TimeSpan diferenca = agora - dataNascimento;

                // Calcula a idade em anos
                int anos = (int)(diferenca.TotalDays / 365.25);

                // Calcula a fração de meses restantes
                int meses = (int)((diferenca.TotalDays % 365.25) / 30.44);
                int dias = (int)((diferenca.TotalDays % 365.25) % 30.44);

                // Exibe a idade calculada
                StringBuilder resultado = new StringBuilder("Sua idade é: ");
                if (anos > 0)
                {
                    resultado.Append(anos);
                    resultado.Append(" anos");

                    if (meses > 0)
                    {
                        if (dias > 0)
                        {
                            resultado.Append(", ");
                            resultado.Append(meses);
                            resultado.Append(" meses");

                            resultado.Append(" e ");
                            resultado.Append(dias);
                            resultado.Append(" dias");
                        }
                        resultado.Append(anos);
                    }
                }
                else if (meses > 0)
                {
                    resultado.Append(meses);
                    resultado.Append(" meses");
                    if (dias > 0) 
                    {
                        resultado.Append(" e ");
                        resultado.Append(dias);
                        resultado.Append(" dias");
                    }
                }
                Console.WriteLine(resultado.ToString());



                //Console.WriteLine($"Sua idade é: {anos} anos e {meses} meses {dias} dias!");
                //Console.WriteLine("Sua idade é: " + anos + " anos " + meses + " e" + " meses!");
            }
            else
            {
                Console.WriteLine("Formato inválido. Certifique-se de digitar a data no formato correto (DD/MM/AAAA).");
            }
            // if (dataNascimento < DateTime.Now)
            {
                //     Console.WriteLine("Você ainda não naceu!");
                //   Console.WriteLine("Voc");
                // Console.WriteLine("Voce faz aniversário hojé. Parabéns!");
            }
        }
    }
}

