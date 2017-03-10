using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(number, index));
        }

        static int FindNthDigit(long number, int index)
        {
            int currentDigit = 0;
            int currentIndex = 1;
            while (number != 0){
                currentDigit = (int) number % 10;
                number = number / 10;
                if (currentIndex == index)
                {
                    return currentDigit;
                }
                else
                {
                    currentIndex++;
                }
            }
            return currentDigit;
        }

    }
}
