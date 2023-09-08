using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Rectangle: IShape
    {

        int width = 0;
        int height = 0;

        public Rectangle(int width, int height)
        {
           this.width = width;
           this.height = height;
        }
        public int Area()
        {
            int area = width * height;
            return area;
        }
        public int Circumference()
        {
            int area = (width + height) * 2;
            return area;
        }
    }
}
