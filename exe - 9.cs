using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine()!);

        string[] nome = new string[n];
        double[] precoCompra = new double[n];
        double[] preco = new double[n];

        double valorTotalCompra = 0.0;
        double valorTotalVenda = 0.0;


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"----Digite {i+1}º Mercadoria----");
            Console.Write("Nome: ");
            nome[i] = Console.ReadLine()!;
            Console.Write("Preço de Compra: ");
            precoCompra[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Preço: ");
            preco[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        }

        double lucroMenor10 = 0.0;
        double luco10e20 = 0.0;
        double lucroMaior20 = 0.0;


        for (int j = 0; j < n; j++)
        { 
            double lucro = preco[j] - precoCompra[j];
            double percentualLucro = (lucro / precoCompra[j]) * 100;

            if (percentualLucro < 10)
            {
                lucroMenor10++;
            }
            else if (percentualLucro <= 20)
            {
                luco10e20++;
            }
            else
            {
                lucroMaior20++; 
            }

            valorTotalCompra = valorTotalCompra + preco[j];

            valorTotalVenda = valorTotalVenda + precoCompra[j];
        }

        Console.WriteLine($"Lucro abaixo de 10%: {lucroMenor10}");
        Console.WriteLine($"Lucro entre 10% e 20%: {luco10e20}");
        Console.WriteLine($"Lucro acima de 20%: {lucroMaior20}");
        Console.WriteLine($"Valor total de compra: {valorTotalCompra.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor total de venda: {valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Lucro total: {(lucroMenor10 + lucroMaior20 + luco10e20).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
