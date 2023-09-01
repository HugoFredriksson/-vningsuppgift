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
        public int rArea()
        {
            return width * height;
        }
        public int rCirc() 
        {
            return (width + height) * 2;
        }
    }
}
