using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Hight { get; set; }

        public int Right 
        {
                get
                {
                    return Left + Width;
                }
  
        }

        public int Bottom
        {
            get
            {
                return Top + Hight;
            }
        }
        

        public bool isInside(Rectangle r)
        {
            return (r.Left <= Left) &&
                    (r.Right >= Right) &&
                    (r.Top <= Top) && 
                    (r.Bottom >= Bottom);
        }
    }
}
