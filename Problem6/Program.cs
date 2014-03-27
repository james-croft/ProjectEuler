//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem6
{
    using System;

    /// <summary>
    /// Solution for Project Euler Problem 6 - Sum square difference
    /// </summary>
    class Program
    {
        static void Main()
        {
            const int num = 100;
            var sum = num * (num + 1) / 2;
            var squared = (num * (num + 1) * (2 * num + 1)) / 6;
            var ans = sum * sum - squared;

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
