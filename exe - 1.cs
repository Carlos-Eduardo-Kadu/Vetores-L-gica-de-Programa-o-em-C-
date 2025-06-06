using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, posicao = 0;
            double y = 0;

            x  = int.Parse(Console.ReadLine());
            double[] vet =  new double[x];


            for (int i = 0; i < x; i++) 
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
           
            foreach(double elementoMaior in vet) 
            {
                if (elementoMaior > y) 
                {
                    y = elementoMaior;
                    posicao++;
                }
            }

            Console.WriteLine(y.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
