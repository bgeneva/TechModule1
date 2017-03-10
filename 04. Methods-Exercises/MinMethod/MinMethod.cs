using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int minNumber;
            if (num1 < num2)
            {
                minNumber = GetMin(num1, num3);
            }else
            {
                minNumber = GetMin(num2, num3);
            }

            Console.WriteLine(minNumber);

        }

        static int GetMin(int a, int b)
        {
            return a > b ? b : a;
        }
    }
}
