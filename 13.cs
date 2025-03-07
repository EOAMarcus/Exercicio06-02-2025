﻿using System;

class Program
{
    static void Main()
    {
        // Read the two integer numbers
        string[] input = Console.ReadLine().Split();

        // Check if we have exactly two inputs
        if (input.Length != 2)
        {
            Console.WriteLine("Please enter exactly two integers.");
            return; // Exit the program if input is invalid
        }

        int X, Y;

        // Try to parse the integers
        if (!int.TryParse(input[0], out X) || !int.TryParse(input[1], out Y))
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            return; // Exit the program if parsing fails
        }

        // Determine the range
        int start = Math.Min(X, Y);
        int end = Math.Max(X, Y);
        int sum = 0;

        // Calculate the sum of numbers not divisible by 13
        for (int i = start; i <= end; i++)
        {
            if (i % 13 != 0)
            {
                sum += i;
            }
        }

        // Print the result
        Console.WriteLine(sum);
    }
}
