//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;

namespace Problem10
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Solution for Project Euler Problem 10 - Summation of primes
    /// </summary>
    class Program
    {
        private static void Main()
        {
            Console.WriteLine(new SieveOfAtkin(2000000).Aggregate((sum, x) => sum + x));
            Console.ReadLine();
        }
    }


    /// <summary>
    /// Based on Pseudocode taken from Wikipedia page for the Sieve of Atkin
    /// Sieve of Atkin is an algorithm that can find primes up to a set
    /// upper limit. Great for many of the previous tasks in this project!
    /// http://en.wikipedia.org/wiki/Sieve_of_Atkin#Pseudocode
    /// </summary>
    public class SieveOfAtkin : IEnumerable<long>
    {
        private readonly List<long> _primes = new List<long>();
        private readonly long _limit;

        public SieveOfAtkin(long limit)
        {
            _limit = limit;
        }

        public IEnumerator<long> GetEnumerator()
        {
            if (!_primes.Any())
                FindPrimes();

            return ((IEnumerable<long>)_primes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void FindPrimes()
        {
            var prime = new bool[_limit + 1];
            var sqrt = Math.Sqrt(_limit);

            for (long i = 1; i <= sqrt; i++)
                for (long j = 1; j <= sqrt; j++)
                {
                    var n = 4 * i * i + j * j;
                    if (n <= _limit && (n % 12 == 1 || n % 12 == 5))
                        prime[n] ^= true;

                    n = 3 * i * i + j * j;
                    if (n <= _limit && n % 12 == 7)
                        prime[n] ^= true;

                    n = 3 * i * i - j * j;
                    if (i > j && n <= _limit && n % 12 == 11)
                        prime[n] ^= true;
                }

            for (long n = 5; n <= sqrt; n++)
                if (prime[n])
                {
                    var s = n * n;
                    for (var k = s; k <= _limit; k += s)
                        prime[k] = false;
                }

            _primes.Add(2);
            _primes.Add(3);

            for (long n = 5; n <= _limit; n += 2)
                if (prime[n])
                    _primes.Add(n);
        }
    }
}
