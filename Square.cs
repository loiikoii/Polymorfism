using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbPolymorfism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }
        public Square() //Changes the values to the correct names/size
        {
            Name = "Square";
            Side = 4;
        }
        public override double Area() //Calculates the area and overrides the virtual mehod in Geometry.cs.
        {
             area = Side * Side;
            return area;
        }
    }
}
