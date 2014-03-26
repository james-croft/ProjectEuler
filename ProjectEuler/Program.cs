//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem1
{
    using System;

    /// <summary>
    /// Solution for Project Euler Problem 1 - Multiples of 3 and 5
    /// </summary>
    class Program
    {
        static void Main()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
