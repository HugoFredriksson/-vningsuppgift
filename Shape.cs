using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningsUppgifter
{
    internal class Shape
    {
        protected int width;
        protected int height;

        public Shape(int width, int height) 
        {
            this.width = width;
            this.height = height;
        }

        public int Width { get { return width; } }
        public int Height { get { return height; } }

        public virtual int Area()
        {
            return 0;
        }

        public virtual int Circumference()
        {
            return 0;
        }
    }
}
