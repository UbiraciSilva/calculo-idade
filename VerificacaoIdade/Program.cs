using System.Runtime.CompilerServices;

using System;
using System.Globalization;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia, més ano do seu nascimento");
            String dataTela = Console.ReadLine();
            
            DateTime dataNascimento;

            try
            {
                dataNascimento = DateTime.ParseExact(dataTela, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch(FormatException)
            {
                Console.WriteLine("Data Inválida. Use o formato dd/mm/yyyy.");
                return;
            }
            DateTime agora = DateTime.Now;
            int idade = agora.Year - dataNascimento.Year;
            
            if (agora.Month < dataNascimento.Month || (agora.Month == dataNascimento.Month && agora.Day < dataNascimento.Day))

           if (dataNascimento.CompareTo(agora) > 0)
                {
                    return;
                    Console.WriteLine("Você ainda não nasceu!");
                
           }
            Console.WriteLine("Sua idade é: " + idade + " anos");

           
            
         
            Console.ReadKey();
        }
    }
}