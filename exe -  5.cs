using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, incre = 0;

            n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];
            double somaPares = 0.0;
            double media = 0.0;

            for(int i = 0; i < n; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            foreach(double numerosPares in numeros)
            { 
                if(numerosPares % 2 == 0)
                { 
                    somaPares += numerosPares;
                    incre++;
                }
            }

            media = somaPares / incre;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
