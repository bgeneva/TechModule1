using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main()
        {
            Rectangle r1 = ReadReactangle();
            Rectangle r2 = ReadReactangle();

            var result = r1.isInside(r2);
            var printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);

        }

        public static Rectangle ReadReactangle()
        {
            var rectangleParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            return new Rectangle()
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Hight = rectangleParts[3]
            };
        }
    }
}
