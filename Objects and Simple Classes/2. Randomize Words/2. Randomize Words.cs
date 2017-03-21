using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main()
        {
            string[] inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < inputLine.Length; i++)
            {
                int randomNumber = rnd.Next(0, inputLine.Length);
                string temp = inputLine[i];
                inputLine[i] = inputLine[randomNumber];
                inputLine[randomNumber] = temp;

            }

            for (int i = 0; i < inputLine.Length; i++)
            {
                Console.WriteLine(inputLine[i]);
            }


        }
    }
}
