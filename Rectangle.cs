using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
