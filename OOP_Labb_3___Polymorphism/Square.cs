﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_3___Polymorphism
{
    internal class Square : Geometry
    {
        protected double _height { get; set; }
        protected double _width { get; set; }

        public Square ()
        {
            _height = 3;
            _width = 12;
        }
        public override double Area()
        {
            return result = _height * _width;
        }
    }
}