using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbPolymorfism
{
    internal class Rectangle : Geometry
    {
        public double sideOne { get; set; }
        public double sideTwo { get; set; }
        public Rectangle() //Changes the values to the correct names/size
        {
            Name = "Rectangle";
            sideOne = 6;
            sideTwo = 4;
        }
        public override double Area() //Calculates the area and overrides the virtual mehod in Geometry.cs.
        {
            area = Math.Round(sideOne * sideTwo);
            return area;
        }
    }
}
