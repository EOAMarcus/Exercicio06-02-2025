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

        // Loop from 1 to N to print the required output
        for (int i = 1; i <= N; i++)
        {
            // Calculate square and cube
            int square = i * i;
            int cube = i * i * i;

            // Print the output in the specified format
            Console.WriteLine($"{i} {square} {cube}");
        }
    }
}
