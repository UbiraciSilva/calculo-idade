using System.Runtime.CompilerServices;

using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.Design;

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
            catch (FormatException)
            {
                Console.WriteLine("Data Inválida. Use o formato dd/MM/yyyy.");
                return;
            }
            DateTime agora = DateTime.Now;
            int idade = agora.Year - dataNascimento.Year;

            if (dataNascimento.CompareTo(agora) == 0)
            {
                Console.WriteLine("Você nasceu hoje!");
            }
            else if (dataNascimento.CompareTo(agora.Date) <= 0)
            {
                Console.WriteLine("Você não nasceu!");   
            }
            else
            {
                Console.WriteLine("Sua idade é: " + idade + " anos");
            }
          





        }
    }
}