using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Circle : IShape 
    {
        int radius = 0;
        double pi = 3.14;

        public Circle (int radius)
        {
            this.radius = radius;
        }
        public int Area()
        {
            int area = (int)(pi * (radius * radius));
            return area;
        }
        public int Circumference()
        {
            int circumference = (int)(2 * (pi * radius));
            return circumference;
        }
    }
}
