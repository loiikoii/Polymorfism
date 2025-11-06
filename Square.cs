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
        public Square()
        {
            Name = "Square";
            Side = 4;
        }
        public override double Area()
        {
             area = Side * Side;
            return area;
        }
    }
}
