using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Rectangle: Shape
    {
        public Rectangle(int width, int height) : base(width, height) 
        {
            this.width = width;
            this.height = height;
        }
        public override int Area()
        {
            int area = width * height;
            return area;
        }
        public override int Circumference()
        {
            int area = (width + height) * 2;
            return area;
        }
    }
}
