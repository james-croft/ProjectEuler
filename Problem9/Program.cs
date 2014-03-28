//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem9
{
    using System;

    /// <summary>
    /// Solution for Project Euler Problem 9 - Special Pythagorean triplet
    /// </summary>
    class Program
    {
        static void Main()
        {
            var escape = false;
            int a;
            var b = 0;
            var c = 0;

            for (a = 1; a < 1000 / 3; a++)
            {
                for (b = a; b < 1000 / 2; b++)
                {
                    c = 1000 - a - b;

                    if (a * a + b * b != c * c) continue;

                    escape = true;
                    break;
                }

                if (escape)
                {
                    break;
                }
            }

            var ans = a * b * c;

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
