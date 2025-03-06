﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de casos de teste: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite um número: ");
            int X = int.Parse(Console.ReadLine());

            if (X == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                string paridade = (X % 2 == 0) ? "EVEN" : "ODD";
                string sinal = (X > 0) ? "POSITIVE" : "NEGATIVE";
                Console.WriteLine($"{paridade} {sinal}");
            }
        }
    }
}
