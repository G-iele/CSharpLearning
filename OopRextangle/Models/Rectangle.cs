using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopRectangle.Models
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            return Height * Width;
        }
    }
}
