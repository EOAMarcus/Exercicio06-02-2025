﻿using System;

class Program
{
    static void Main()
    {
        // Initialize the sum S
        double S = 0.0;

        // Calculate the sum S
        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i; // Add the reciprocal of i to S
        }

        // Print the result formatted to two decimal places
        Console.WriteLine($"{S:F2}");
    }
}

