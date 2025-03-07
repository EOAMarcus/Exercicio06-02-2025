﻿using System;

class Program
{
    static void Main()
    {
        // Read the number of pairs
        int N;
        if (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
        {
            Console.WriteLine("Invalid number of pairs.");
            return;
        }

        // Loop through each pair
        for (int i = 0; i < N; i++)
        {
            // Read the pair of integers X and Y
            string[] input = Console.ReadLine().Split();

            // Check if we have exactly two inputs
            if (input.Length != 2)
            {
                Console.WriteLine("Invalid input. Please enter two integers.");
                continue; // Skip to the next iteration
            }

            int X, Y;

            // Try to parse the integers
            if (!int.TryParse(input[0], out X) || !int.TryParse(input[1], out Y))
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
                continue; // Skip to the next iteration
            }

            // Check if Y is zero to avoid division by zero
            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                // Perform the division and format the output to one decimal place
                double result = (double)X / Y;
                Console.WriteLine($"{result:F1}");
            }
        }
    }
}
