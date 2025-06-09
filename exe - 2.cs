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
            
            int[] numeros = new int[n];

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                numeros[i] = x;
            }

            foreach(int numerosPares in numeros)
            { 
                if(numerosPares % 2 == 0)
                {
                    Console.WriteLine(numerosPares);
                    incre++;
                }
            }
            Console.WriteLine(incre);
        }
    }
}
