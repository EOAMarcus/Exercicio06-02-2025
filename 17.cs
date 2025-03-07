﻿using System;

class Program
{
    static void Main()
    {
        // Read the integer N
        int N = int.Parse(Console.ReadLine());

        // Check if N is within the specified range
        if (N <= 1 || N >= 1000)
        {
            Console.WriteLine("N must be between 1 and 1000.");
            return;
        }

        // Loop through each group from 1 to N
        for (int i = 1; i <= N; i++)
        {
            // For each group, print 2 lines
            for (int j = 1; j <= 2; j++)
            {
                // Calculate the first number and its square
                int firstNumber = i;
                int square = firstNumber * firstNumber;

                // Calculate the second number and its cube
                int secondNumber = firstNumber + j;
                int cube = secondNumber * secondNumber * secondNumber;

                // Print the output in the specified format
                Console.WriteLine($"{firstNumber} {square} {cube}");
            }
        }
    }
}
