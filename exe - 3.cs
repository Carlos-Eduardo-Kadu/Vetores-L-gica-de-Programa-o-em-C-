using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int[] a =  new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            for (int i = 0; i < n; i++)
            { 
                int numA = int.Parse(Console.ReadLine());
                a[i] = numA;
            }

            for (int i = 0; i < n; i++)
            {
                int numB = int.Parse(Console.ReadLine());
                b[i] = numB;
            }

            for (int j = 0; j < n; j++) 
            {
                c[j] = a[j] + b[j];
            }

            foreach (int vetC in c) 
            {
                Console.WriteLine($"Vetor C ={vetC}");
            }
        }
    }
}
