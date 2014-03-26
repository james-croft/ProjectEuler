using System;

namespace Problem2
{
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
