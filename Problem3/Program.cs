//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem3
{
    using System;

    /// <summary>
    /// Solution for Project Euler Problem 3 - Largest prime factor
    /// </summary>
    class Program
    {
        static void Main()
        {
            const long prime = 600851475143;
            var temp = prime;
            long largest = 0;
            var i = 2;

            while (i * i <= temp)
            {
                if (temp % i == 0)
                {
                    temp = temp / i;
                    largest = i;
                }
                else
                    i++;
            }

            if (temp > largest)
                largest = temp;

            Console.WriteLine(largest);
            Console.ReadLine();
        }
    }
}
