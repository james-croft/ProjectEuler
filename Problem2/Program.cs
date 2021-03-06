﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem2
{
    using System;

    /// <summary>
    /// Solution for Project Euler Problem 2 - Even Fibonacci numbers
    /// </summary>
    class Program
    {
        static void Main()
        {
            var fibonnaci = 0;
            var last = 1;
            var sum = 0;

            while (fibonnaci < 4000000)
            {
                var temp = fibonnaci;
                fibonnaci += last;
                last = temp;

                // Check if the fibonnaci number is even
                if (fibonnaci % 2 == 0)
                {
                    sum += fibonnaci;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
