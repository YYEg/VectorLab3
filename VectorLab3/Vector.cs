using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLab3
{
    public class Vector
    {
        private double coordinateX;
        private double coordinateY;
        private double coordinateZ;

        public Vector(double coordinateX, double coordinateY, double coordinateZ)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.coordinateZ = coordinateZ;
        }
        //Операция возвращения значения
        public string VerboseX()
        {
            return String.Format("{0}", this.coordinateX);
        }
        public string VerboseY()
        {
            return String.Format("{0}", this.coordinateY);
        }
        public string VerboseZ()
        {
            return String.Format("{0}", this.coordinateZ);
        }

        public static Vector VectorSum(Vector vectorA, Vector vectorB)
        {
            Vector vectorC = new Vector(0, 0, 0);
            vectorC.coordinateX = vectorA.coordinateX + vectorB.coordinateX;
            vectorC.coordinateY = vectorA.coordinateY + vectorB.coordinateY;
            vectorC.coordinateZ = vectorA.coordinateZ + vectorB.coordinateZ;
            return vectorC;
        }

        public static Vector VectorMinus(Vector vectorA, Vector vectorB)
        {
            Vector vectorC = new Vector(0, 0, 0);
            vectorC.coordinateX = vectorA.coordinateX - vectorB.coordinateX;
            vectorC.coordinateY = vectorA.coordinateY - vectorB.coordinateY;
            vectorC.coordinateZ = vectorA.coordinateZ - vectorB.coordinateZ;
            return vectorC;
        }

        public static double VectorLength(Vector vector)
        {
            var length = Math.Sqrt(Math.Pow(vector.coordinateX, 2) + Math.Pow(vector.coordinateY, 2) + Math.Pow(vector.coordinateZ, 2));
            return length;
        }
        public static double DotProductOfVector(Vector vectorA, Vector vectorB)
        {
            double dotProduct = vectorA.coordinateX * vectorB.coordinateX
            + vectorA.coordinateY * vectorB.coordinateY + vectorA.coordinateZ * vectorB.coordinateZ;
            return dotProduct;
        }

        public static Vector VectorMultiOfVectors(Vector vectorA, Vector vectorB)
        {
            Vector vectorC = new Vector(0, 0, 0);
            vectorC.coordinateX = vectorA.coordinateY * vectorB.coordinateZ - vectorA.coordinateZ * vectorB.coordinateY;
            vectorC.coordinateY = vectorA.coordinateZ * vectorB.coordinateX - vectorA.coordinateX * vectorB.coordinateZ;
            vectorC.coordinateZ = vectorA.coordinateX * vectorB.coordinateY - vectorA.coordinateY * vectorB.coordinateZ;
            return vectorC;

        }
        public static double MultiOfVector(Vector vectorA, Vector vectorB)
        {
            var cosinusValue = DotProductOfVector(vectorA, vectorB) / (VectorLength(vectorA) * VectorLength(vectorB));
            var sinusValue = Math.Sqrt(1 - Math.Pow(cosinusValue, 2));
            var multiOfVector = VectorLength(vectorA) * VectorLength(vectorB) * sinusValue;
            return multiOfVector;
        }
    }
}