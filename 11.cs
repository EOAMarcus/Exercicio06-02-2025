﻿using System;

class Program
{
    static void Main()
    {
        // Loop through odd values of I from 1 to 9
        for (int I = 1; I <= 9; I += 2)
        {
            // Calculate the starting value of J
            int J = 7 + (I - 1) * 2;

            // Print the three values of J for each I
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"I={I} J={J}");
                J--; // Decrement J
            }
        }
    }
}
