using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLab3
{
    public enum CoordinateType {x, y, z};
    internal class Vector
    {
        private double coordinate;
        private CoordinateType type;

        public Vector(double coordinate, CoordinateType type)
        {
            this.coordinate = coordinate;
            this.type = type;
        }

        public string Verbose()
        {
            string typeVerbose = "";
        }
    }
}
