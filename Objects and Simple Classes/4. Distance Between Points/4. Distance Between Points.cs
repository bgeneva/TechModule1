using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{

    class Program
    {
        static void Main()
        {

            Point point1 = ReadPoint();
            Point point2 = ReadPoint();

            double distance = CalcDistance(point1, point2);

            Console.WriteLine("{0:F3}", distance);

        }

        public static Point ReadPoint()
        {
            var inputKoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return new Point()
            {
                X = double.Parse(inputKoordinates[0]),
                Y = double.Parse(inputKoordinates[1])
            };
        }

        public static double CalcDistance(Point point1, Point point2)
        {
            var squareX = Math.Pow(point2.X - point1.X, 2);
            var squareY = Math.Pow(point2.Y - point1.Y, 2);
            var distance = Math.Sqrt(squareX + squareY); 

            return distance;
        }
    }

   }
