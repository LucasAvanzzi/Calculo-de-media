using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, media;

            Console.WriteLine("Digite o nome do aluno: \t");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro bimestre: \t");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo bimestre: \t");
            nota2 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;


            if (media >= 8.05)
            {
                Console.WriteLine("Sua média é A \t");

            }

            if (media >= 7.0 && media <= 8.04)
            {
                Console.WriteLine("Sua média é B \t");

            }

            if (media >= 6.0 && media <= 6.9)
            {
                Console.WriteLine("Sua média é C \t");

            }
            if (media >= 0.1 && media <= 5.09)
            {
                Console.WriteLine("Sua média é D \t");
            }
            if (media == 0.0)
            {
                Console.WriteLine("Sua média é E \t");
            }

            Console.ReadKey();
        }
    }
}
