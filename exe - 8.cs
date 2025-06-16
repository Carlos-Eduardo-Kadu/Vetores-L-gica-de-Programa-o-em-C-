using System;
using System.Globalization;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, numeroHomens = 0, numeroMulheres = 0;
            double maiorAltura = 0.0, menorAltura = 0.0, somaAlturaMulheres = 0.0, media = 0.0;
            n = int.Parse(Console.ReadLine()!);

            string[] sexo = new string[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++)
            {
                altura[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                sexo[i] = Console.ReadLine()!;
            }

            for(int j = 0; j < n; j++)
            {
                if (altura[j] > maiorAltura)
                { 
                    maiorAltura = altura[j];
                    menorAltura = maiorAltura;
                }
                else if (altura[j] < menorAltura)
                {
                    menorAltura = altura[j];
                }
                
                if (sexo[j] == "M" || sexo[j] == "m") 
                { 
                    numeroHomens++;
                }
                else if (sexo[j] == "F" || sexo[j] == "f")
                {
                    somaAlturaMulheres = somaAlturaMulheres + altura[j];
                    numeroMulheres++;
                }
            }
            media = somaAlturaMulheres / numeroMulheres;
            Console.WriteLine("Menor altura: " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura: " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens: " + numeroHomens);

        }
    }
}
