using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_3___Polymorphism
{
    internal class Rectangle :Geometry
    {
        protected double _height { get; set; }
        protected double _width { get; set; }

        public Rectangle()
        {
            _height = 6.4;
            _width = 3.5;
        }

        public override double Area()
        {
            return _height*_width;
        }
    }
}
