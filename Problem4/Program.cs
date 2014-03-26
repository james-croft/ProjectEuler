//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="James Croft">
//     Copyright (c) James Croft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Problem4
{
    using System;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// Solution for Project Euler Problem 4 - Largest palindrome product
    /// </summary>
    class Program
    {
        static void Main()
        {
            var ans = 0;

            for (var i = 999; i > 99; i--)
            {
                for (var j = i; j > 99; j--)
                {
                    var val = i * j;
                    var str = val.ToString(CultureInfo.InvariantCulture);
                    var reversedStr = str.Reverse().ToArray();

                    if (str != new string(reversedStr)) continue;

                    if (val > ans)
                        ans = val;
                }
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
