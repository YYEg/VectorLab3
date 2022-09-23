using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLab3
{
    public class Vector
    {
        private double coordinate;

        public Vector(double coordinate)
        {
            this.coordinate = coordinate;
        }

        public double Verbose()
        {
            return this.coordinate;
        }
        
    }
}