using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbPolymorfism
{
    internal class Triangle : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle() //Changes the values to the correct names/size
        {
            Base = 5;
            Height = 7;
            Name = "Triangle";
        }
        public override double Area() //Calculates the area and overrides the virtual mehod in Geometry.cs.
        {
            area = Math.Round((Base * Height) / 2, 2);
            return area;
        }

    }
}
