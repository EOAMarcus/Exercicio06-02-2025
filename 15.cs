﻿namespace _1142
{
    using System;

    class Program
    {
        static void Main()
        {
            // Read the integer N
            int N = int.Parse(Console.ReadLine());

            // Initialize a counter for the numbers
            int number = 1;

            // Loop N times to print the required output
            for (int i = 0; i < N; i++)
            {
                // Print three consecutive numbers followed by "PUM"
                Console.WriteLine($"{number} {number + 1} {number + 2} PUM");
                // Increment the number by 4 for the next line
                number += 4;
            }
        }
    }
}

