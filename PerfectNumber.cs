using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming_06
{
    public class PerfectNumber
    {
        public static void CheckPerfectNumber()
        {
            int n, i, sum;
            int max, min;

            Console.WriteLine("Find the Perfect Number within the given range");
            Console.WriteLine("Input the Starting rang or number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range or number");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect number within the given range");

            for (n = min; n < max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0}", n);
            }

        }
    }
}
