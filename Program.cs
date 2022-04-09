using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPorgramming_06

{
    public class Odd
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("find odd num ");
            for (int i = 1; i < 20; i = i + 2)
            {
                flag = flag + 1;

            }
            Console.WriteLine("No of odd num are " + flag);

        }
    }
}