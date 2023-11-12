using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_3___Polymorphism
{
    internal class Square : Geometry
    {
        protected double _height { get; set; }

        public Square ()
        {
            _height = 6;
        }
        public override double Area()
        {
            return  _height * _height;
        }
    }
}
