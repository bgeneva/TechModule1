using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(number,toBase));
        }

        static string IntToBase(long num, int baseConv)
        {
             var sb = new StringBuilder();
            /*
             * 1. Take the remainder of the number, divided by the base.
             * 2. Add the remainder to the front of the result string.
             * 3. Divide the number by the base
             * 4. The above algorithm should run until the number is 0
            */

            int lastDigit = 0;
            while (num != 0)
            {
                lastDigit = (int)num % baseConv;
                sb.Insert(0,lastDigit);
                num = num / baseConv;
            }

            return sb.ToString();
        }

    }
}
