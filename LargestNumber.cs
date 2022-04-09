using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming_06
{
    public class LargestNumber
    {
        public static void FindTheLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largets of three numbers:");
            Console.WriteLine("Input the 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st number is largest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The 2nd number is largest");
            }
            else
            {
                Console.WriteLine("the 3rd number is largest");
            }

        }
    }
}
