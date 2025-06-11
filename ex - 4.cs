using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, incre = 1;
            n = int.Parse(Console.ReadLine());
            double somaNotas = 0.0;
            double[] vet = new double[n];

            for (int i = 0; i < n; i++) 
            {
                double numeros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = numeros;
            }

            for(int j = 0;  j < vet.Length; j++)
            {
                somaNotas += vet[j];
                incre++;
            }

            double media = somaNotas / vet.Length;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            foreach(double abaixoMedia in vet) 
            { 
                if(abaixoMedia < 11.00)
                {
                    Console.WriteLine(abaixoMedia);
                }
            }

            
        }
    }
}
