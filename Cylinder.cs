using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Cylinder : IShape
    {
        int height = 0;
        int radius = 0;
        double pi = 3.14;

        public Cylinder(int height, int radius)
        {
            this.height = height;
            this.radius = radius;
        }
        public int Area()
        {
            int area = (int)(pi * (radius * radius) * (height));
            return area;
        }
        public int Circumference()
        {
            int circumference = (int)(2 * (pi * radius));
            return circumference;
        }
    }
}
