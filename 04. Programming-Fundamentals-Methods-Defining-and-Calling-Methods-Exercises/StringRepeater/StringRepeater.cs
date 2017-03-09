using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int timeRepeated = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, timeRepeated));
        }

        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                 strBuilder.Append(str);
            }

            return strBuilder.ToString();
        }

    }
}
