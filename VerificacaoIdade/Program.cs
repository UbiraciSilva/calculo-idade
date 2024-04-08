using System.Runtime.CompilerServices;

using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.Design;

namespace MeuProjeto
{
    using System;

    class Program
    {
        static void Main()
        {
            DateTime agora = DateTime.Now;

            Console.WriteLine("Digite o dia, mês e ano do seu nascimento (no formato DD/MM/AAAA):");
            string input = Console.ReadLine();
            DateTime dataNascimento = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            TimeSpan intervaloTempo = agora.Subtract(dataNascimento);

            int idade = agora.Year - dataNascimento.Year;

            // Verifica se o aniversário já passou este ano
            if (dataNascimento.Date > agora.Date.AddYears(-idade))
            {
                idade--;
            }

            if (dataNascimento.Date == agora.Date)
            {
                Console.WriteLine("Você nasceu hoje!");
            }
            else if (dataNascimento.Date > agora.Date)
            {
                Console.WriteLine("Você ainda não nasceu!");
            }
            else
            {
                Console.WriteLine("Sua idade é: " + idade + " anos");

            }
        }
    }
}
