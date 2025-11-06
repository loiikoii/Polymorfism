using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbPolymorfism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 4;
            Name = "Circle";
        }
        public override double Area()
        {
            area = Math.Round(Radius * Radius * Math.PI, 2);
            return area;
        }
    }
}
