//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem5
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Solution for Project Euler Problem 5 - Smallest multiple
    /// </summary>
    class Program
    {
        static void Main()
        {
            // This is extremely slow, will look into alternative method
            var ans = 1;
            var i = 1;

            while (i <= 20)
            {
                if (ans % i == 0)
                    i++;
                else
                {
                    ans++;
                    i = 1;
                }
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
