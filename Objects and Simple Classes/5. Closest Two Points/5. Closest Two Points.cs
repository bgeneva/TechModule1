using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] arrayOfPoints = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Point currentPoint = ReadPoint();
                arrayOfPoints[i] = currentPoint;
            }

            double minDistance = double.MaxValue;
            Point point1 = null;
            Point point2 = null;

            if (arrayOfPoints.Length > 1)
            {
                for (int start = 0; start < arrayOfPoints.Length; start++)
                {
                    for (int second = start + 1; second < arrayOfPoints.Length; second++)
                    {
                        double currentDistance = CalcDistance(arrayOfPoints[start], arrayOfPoints[second]);
                        if (minDistance > currentDistance)
                        {
                            minDistance = currentDistance;
                            point1 = arrayOfPoints[start];
                            point2 = arrayOfPoints[second];
                        }

                    }
                }

                printDistance(point1, point2, minDistance);
            }

          
        }

        private static void printDistance(Point point1, Point point2, double distance)
        {
            Console.WriteLine("{0:F3}", distance);
            Console.WriteLine("({0}, {1})", point1.X, point1.Y);
            Console.WriteLine("({0}, {1})", point2.X, point2.Y);

        }

        public static double CalcDistance(Point point1, Point point2)
        {
            var squareX = Math.Pow(point2.X - point1.X, 2);
            var squareY = Math.Pow(point2.Y - point1.Y, 2);
            var distance = Math.Sqrt(squareX + squareY);

            return distance;
        }

        public static Point ReadPoint()
        {
            var koordinates = Console.ReadLine().Split(' ');

            return new Point()
            {
                X = int.Parse(koordinates[0]),
                Y = int.Parse(koordinates[1])
            };
        }
    }
}
