using System;
using System.Globalization;
using System.Security.Cryptography;

namespace ExeUri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int pessoaVelha = 0;
            int incre = 0;


            string[] nome = new string[n];
            int[] idade = new int[n];

            for (int i = 0; i < n; i++)
            {
                nome[i] = Console.ReadLine();
                idade[i] = int.Parse(Console.ReadLine());
            }

            foreach(int idadeMaior in  idade)
            {
                if (idadeMaior > pessoaVelha)
                { 
                    pessoaVelha = idadeMaior;
                    incre++;
                }
                
            }
            Console.WriteLine($"Pessoa mais velha: {nome[incre]} {pessoaVelha}");

        }
    }
}
