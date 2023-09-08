using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Triangle : IShape
    {
        int width = 0;
        int height = 0;

        public Triangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            int area = (width * height) / 2;
            return area;
        }
        public int Circumference()
        {
            int circumference = (int)Math.Sqrt((width * width) + (height * height)) + width + height;
            return circumference; 
        }
    }
}
