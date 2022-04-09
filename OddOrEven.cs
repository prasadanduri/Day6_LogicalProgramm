using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming_06
{
    public class OddOrEven
    {
        public static void NumOddOrEven()
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                Console.ReadLine();
            }

        }
    }
}
