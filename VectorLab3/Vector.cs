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
        //Операция возвращения значения
        public double Verbose()
        {
            return this.coordinate;
        }
        //Возведение в степень
        public static Vector Extent(Vector number, double powNumber)
        {
            var newNumber = Math.Pow(number.coordinate, powNumber);
            var extentNumber = new Vector(newNumber);
            return extentNumber;
        }
        //Корень квадратный
        public static Vector Radical(Vector number)
        {
            var newNumber = Math.Sqrt(number.coordinate);
            var extentNumber = new Vector(newNumber);
            return extentNumber;
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