﻿using System;

class Program
{
    static void Main()
    {
        // Read the integer N
        int N = int.Parse(Console.ReadLine());

        // Check if N is within the specified range
        if (N <= 0 || N >= 46)
        {
            Console.WriteLine("N must be between 1 and 45.");
            return;
        }

        // Initialize the first two Fibonacci numbers
        int[] fibonacci = new int[N];

        // Handle the first two cases separately
        if (N >= 1) fibonacci[0] = 0; // First Fibonacci number
        if (N >= 2) fibonacci[1] = 1; // Second Fibonacci number

        // Calculate the Fibonacci sequence
        for (int i = 2; i < N; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        // Print the Fibonacci numbers on the same line
        Console.WriteLine(string.Join(" ", fibonacci));
    }
}
