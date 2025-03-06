﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número N: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            for (int i = 1; i <= 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}
