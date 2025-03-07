﻿using System;

class Program
{
    static void Main()
    {
        int maxValue = int.MinValue;
        int maxPosition = -1;

        Console.WriteLine("Digite 100 numeros:");

        for (int i = 1; i <= 100; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                if (value > maxValue)
                {
                    maxValue = value;
                    maxPosition = i;
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida. Digite um numero inteiro.");
                i--; // Decrementa o contador para garantir que 100 entradas válidas sejam lidas
            }
        }

        Console.WriteLine($"Maior valor: {maxValue}");
        Console.WriteLine($"Posição: {maxPosition}");
    }
}
