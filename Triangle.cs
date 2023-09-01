using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Triangle: Shape
    {
        public Triangle(int width, int height) : base(width, height) 
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return (width * height) / 2;
        }
        public float Circ()
        {
            return (int)Math.Sqrt((width * width) + (height * height)) + width + height;
        }
    }
}
