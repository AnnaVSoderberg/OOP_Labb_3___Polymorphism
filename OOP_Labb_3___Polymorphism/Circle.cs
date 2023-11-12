using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_3___Polymorphism
{
    internal class Circle : Geometry
    {
        protected double _radius {  get; set; }

        public Circle()
        {
            _radius = 4;
        }

        public override double Area() 
        {
            return _radius * _radius * Math.PI; 
        }
    }
}
