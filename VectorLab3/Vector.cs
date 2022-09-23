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
        //Операция сложения векторов
        public static Vector operator +(Vector instance, double number)
        {
            var newCoordinate = instance.coordinate + number;
            var coordinateX2 = new Vector(newCoordinate);
            return coordinateX2;
        }
        public static Vector operator +(double number, Vector instance)
        {
            return instance + number;
        }
        public static Vector operator +(Vector instance1, Vector instance2)
        {
            return instance1 + instance2.coordinate;
        }
        //Операция вычитания векторов
        public static Vector operator -(Vector instance, double number)
        {
            var newCoordinate = instance.coordinate - number;
            var coordinateX2 = new Vector(newCoordinate);
            return coordinateX2;
        }
        public static Vector operator -(double number, Vector instance)
        {
            return instance - number;
        }
        public static Vector operator-(Vector instance1, Vector instance2)
        {
            return instance1 - instance2.coordinate;
        }
        //Операции умножения векторов
        public static Vector operator *(Vector instance, double number)
        {
            var newCoordinate = instance.coordinate * number;
            var coordinateX2 = new Vector(newCoordinate);
            return coordinateX2;
        }
        public static Vector operator *(double number, Vector instance)
        {
            return instance * number;
        }
        public static Vector operator *(Vector instance1, Vector instance2)
        {
            return instance1 * instance2.coordinate;
        }
    }
}