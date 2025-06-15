using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine()!);

            string[] nome = new string[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"----Digite o Nome e as Notas dos Alunoa {i}----");
                nome[i] = Console.ReadLine()!;
                nota1[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }

            Console.WriteLine("---Alunos Aprovados---");
            for(int j = 0; j < n; j++)
            {
                if (((nota1[j] + nota2[j]) / 2) >= 6) 
                {
                    Console.WriteLine(nome[j]);
                }
            }
        }
    }
}
