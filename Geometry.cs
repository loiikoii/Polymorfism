using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabbPolymorfism
{
    internal class Geometry
    {
        public string Name { get; set; } = string.Empty;
        public double area;
        public virtual double Area() //Default if shape is unspecified
        {
            return area;
        }
    }
}
