using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming_06
{
    internal class SwapTwoNum
    {
        public static void SwapNumbers()
        {
            int a = 2, b = 4;
            Console.WriteLine("Before Swap a = " + a + "b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After Swap a = " + a + "b = " + b);
        }
    }
}
