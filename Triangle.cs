using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Triangle : IShape
    {
        public Triangle(int width, int height) : base(width, height) 
        {
            this.width = width;
            this.height = height;
        }

        public override int Area()
        {
            int area = (width * height) / 2;
            return area;
        }
        public override int Circumference()
        {
            int circumference = (int)Math.Sqrt((width * width) + (height * height)) + width + height;
            return circumference; 
        }
    }
}
