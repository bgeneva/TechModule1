using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            int nNumbers = int.Parse(Console.ReadLine());

            Dictionary<int, string> dict = new Dictionary<int, string>()
                                {
                                    {1,"One"},
                                    {2, "Two"},
                                    {3,"Three"}
                                };

            Console.WriteLine(dict[1]);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int numDigits = 0;
                numDigits = Math.Abs(n).ToString().Length;
                if (numDigits == 3)
                {
                    sb.Append(Letterize(n));
                }

            }
        }

        static string Letterize(int num)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<int, string> dictPrime = new Dictionary<int, string>();
            dictPrime.Add(1, "one");
            dictPrime.Add(2, "two");
            dictPrime.Add(3, "three");
            dictPrime.Add(4, "four");
            dictPrime.Add(5, "five");
            dictPrime.Add(6, "six");
            dictPrime.Add(7, "seven");
            dictPrime.Add(8, "eight");
            dictPrime.Add(9, "nine");

            Dictionary<int, string> dictSecond = new Dictionary<int, string>();
            dictSecond.Add(10, "ten");
            dictSecond.Add(11, "eleven");
            dictSecond.Add(12, "tvelve");
            dictSecond.Add(13, "thirteen");
            dictSecond.Add(14, "fourteen");
            dictSecond.Add(15, "fifteen");
            dictSecond.Add(16, "sixteen");
            dictSecond.Add(17, "seventeen");
            dictSecond.Add(18, "eighteen");
            dictSecond.Add(19, "nineteen");

            Dictionary<int, string> dictThird = new Dictionary<int, string>();
            dictThird.Add(2, "twenty");
            dictThird.Add(3, "thirty");
            dictThird.Add(4, "fourty");
            dictThird.Add(5, "fifty");
            dictThird.Add(6, "sixty");
            dictThird.Add(7, "seventy");
            dictThird.Add(8, "eighty");
            dictThird.Add(9, "ninety");

            int index = 0;
            string currentStr;
            while (num != 0)
            {
                int digit = num % 10;
                index++;
                //1. digit
                if (digit != 0)
                {
                    if (index == 1)
                    {
                        currentStr = dictPrime[digit];
                        sb.Insert(0, currentStr);
                    }
                    if (index == 2)
                    {
                        if (digit == 1)
                        {
                            sb.Insert(0, dictSecond[digit]);
                        }
                        else
                        {
                            sb.Insert(0, dictThird[digit] + "-");
                        }

                    }

                    if (index == 3)
                    {
                        sb.Insert(0, dictPrime[digit] + "-hundred");
                    }
                    num = num / 10;
                }
            }
            return sb.ToString();
        }
    }
}
