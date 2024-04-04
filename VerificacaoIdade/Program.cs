using System.Runtime.CompilerServices;

using System;
using System.Globalization;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data de nascimento da pessoa (exemplo)
            DateTime dataDeNascimento = new DateTime();

            // Obtendo a data e hora atual
            DateTime agora = DateTime.Now;

            // Calculando a idade
            int idade = agora.Year - dataDeNascimento.Year;
            String dataTela = Console.ReadLine();
            DateTime dataNascimento = DateTime.Now;
            try
            {
                dataNascimento = DateTime.ParseExact(dataTela, "dd/MM/yyyy",
                                           CultureInfo.InvariantCulture);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Data Inválida. Use o formato dd/mm/yyyy.");
                return;
            }
            // Verificando se já passou o aniversário deste ano
            //if (agora.Month < dataDeNascimento.Month || (agora.Month == dataDeNascimento.Month && agora.Day < dataDeNascimento.Day))
            if (dataNascimento.CompareTo(agora) > 0)
            {
                Console.WriteLine("Você ainda não nasceu!");
                return;
               
            }

            // Exibindo a idade
            Console.WriteLine("A idade é: " + idade);

            // Espera até que o usuário pressione uma tecla antes de fechar
            Console.ReadKey();
        }
    }
}