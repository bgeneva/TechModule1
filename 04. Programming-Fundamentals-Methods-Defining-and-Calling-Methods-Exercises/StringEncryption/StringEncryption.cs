using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string strEncripted = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var letterToEncr = char.Parse(Console.ReadLine());

                int firstD = findFirstDigit((int)letterToEncr);
                int lastD = findLastDigit((int)letterToEncr);

                strEncripted = strEncripted + EncryptSymbol(letterToEncr, firstD, lastD);

            }

            Console.WriteLine(strEncripted);

        }

        static string EncryptSymbol(char letterToEncr, int first, int last)
        {

            //find ascii symbols
            //Append the character, resulting from the ASCII code + last digit to the start
            char edcodSymbolStart = (char)((int)letterToEncr + last);
            //Append the character, resulting from the ASCII code - first digit to the end
            char edcodSymbolEnd = (char)((int)letterToEncr - first);

            string result = ($"{edcodSymbolStart}{first}{last}{edcodSymbolEnd}");
            return result;
        }

        static int findLastDigit(int letterToEncr)
        {
            return letterToEncr % 10;
        }

        static int findFirstDigit(int letterToEncr)
        {
            while(letterToEncr >= 10)
            {
                letterToEncr = letterToEncr / 10;
            }

            return letterToEncr;
        }
    }
}
