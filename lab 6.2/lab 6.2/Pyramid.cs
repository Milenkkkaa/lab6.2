using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6._2
{
    internal class Pyramid : ISolid
    {
        public double A { get; set; } // Довжина сторони основи
        public double H { get; set; } // Висота піраміди

        public Pyramid(double a, double h)
        {
            A = a;
            H = h;
        }

        // Реалізація методу GetVolume для обчислення об'єму піраміди
        public double GetVolume()
        {
            return ((1.0 / 3) * (A * A)) * H;
        }
    }
}
