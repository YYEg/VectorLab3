using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLab3
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.x = coordinateX;
            this.y = coordinateY;
            this.z = coordinateZ;
        }
        //Операция возвращения значения
        public string VerboseX()
        {
            return String.Format("{0}", this.x);
        }
        public string VerboseY()
        {
            return String.Format("{0}", this.y);
        }
        public string VerboseZ()
        {
            return String.Format("{0}", this.z);
        }
        public static Vector operator +(Vector vectorA, Vector vectorB)
        {
            Vector vectorC = new Vector(0, 0, 0);
            vectorC.x = vectorA.x + vectorB.x;
            vectorC.y = vectorA.y + vectorB.y;
            vectorC.z = vectorA.z + vectorB.z;
            return vectorC;
        }
        public static Vector operator -(Vector vectorA, Vector vectorB)
        {
            Vector vectorC = new Vector(0, 0, 0);
            vectorC.x = vectorA.x - vectorB.x;
            vectorC.y = vectorA.y - vectorB.y;
            vectorC.z = vectorA.z - vectorB.z;
            return vectorC;
        }
        public static Vector operator *(Vector vectorA, Vector vectorB)
        {
            Vector vectorC = new Vector(0, 0, 0);
            vectorC.x = vectorA.y * vectorB.z - vectorA.z * vectorB.y;
            vectorC.y = vectorA.z * vectorB.x - vectorA.x * vectorB.z;
            vectorC.z = vectorA.x * vectorB.y - vectorA.y * vectorB.x;
            return vectorC;
        }
        public double VectorLength()
        {
            var length = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            return length;
        }
        public double DotProductOfVector(Vector vectorA)
        {
            double dotProduct = vectorA.x * this.x
            + vectorA.y * this.y + vectorA.z * this.z;
            return dotProduct;
        }

        public override bool Equals(object obj)
        {
            Vector other = obj as Vector;
            if (other == null)
                return false;
            return other.x == this.x && other.y == this.y && other.z == this.z;
        }
    }
}