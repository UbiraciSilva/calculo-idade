using System.Runtime.CompilerServices;

namespace Texte1VerificacaoIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {   int diaNascimento;
            int mesNascimento;
            int anoNascimento;
            int diaAtual;
            int mesAtual;
            int anoAtual;


            //Console.WriteLine(anoAtual - anoNascimento); Esse seria o código inicialmente.
            Console.WriteLine("Digite o dia, do seu nascimento!");
            diaNascimento = Convert.ToInt32( Console.ReadLine());

            Console.Write("Digite o més do seu Nascimento");
            Console.WriteLine();
            mesNascimento = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Digite o ano, do seu nascimento!");
            Console.WriteLine();
            anoNascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o dia atua");
            Console.WriteLine();
            diaAtual = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Digite o més, Aatual!");
            Console.WriteLine();
            mesAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Ano atual!");
            Console.WriteLine();
            anoAtual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(diaNascimento - diaAtual - mesNascimento - mesAtual - anoNascimento - anoAtual);
        }
    }
}