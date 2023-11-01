using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_3___Polymorphism
{
    internal class Geometry
    {
        protected double result;
        public virtual double Area()
        {
            return result;
        }
    }
}
