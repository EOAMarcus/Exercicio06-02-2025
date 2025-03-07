﻿using System;

class Program
{
    static void Main()
    {
        // Read the integer N
        int N = int.Parse(Console.ReadLine());

        // Check if N is within the specified range
        if (N <= 0 || N >= 13)
        {
            Console.WriteLine("N must be between 1 and 12.");
            return;
        }

        // Initialize the factorial result
        int factorial = 1;

        // Calculate the factorial
        for (int i = N; i > 0; i--)
        {
            factorial *= i;
        }

        // Print the result
        Console.WriteLine(factorial);
    }
}
