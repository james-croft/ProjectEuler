//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace Problem7
{
    using System;

    /// <summary>
    /// Solution for Project Euler Problem 7 - 10001st prime
    /// </summary>
    class Program
    {
        static void Main()
        {
            const int largest = 10001;
            var ans = 1;
            var primes = new List<int> { 2 };

            while (primes.Count < largest)
            {
                ans += 2;

                var i = 0;
                var prime = true;

                while (primes[i] * primes[i] <= ans)
                {
                    if (ans % primes[i] == 0)
                    {
                        prime = false;
                        break;
                    }

                    i++;
                }

                if (prime)
                {
                    primes.Add(ans);
                }
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
