using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._2
{
    internal class Sphere : ISolid
    {
        public double R { get; set; } 

        public Sphere(double r)
        {
            R = r;
        }

        public double GetVolume()
        {
            return (4.0 / 3) * Math.Pow(R, 3);
        }
    }
}
