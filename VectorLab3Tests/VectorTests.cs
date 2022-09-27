using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorLab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLab3.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void VerboseXTest()
        {
            var coordinateX = new Vector(3, 4, 5);
            Assert.AreEqual("3", coordinateX.VerboseX());
        }
        [TestMethod()]
        public void VerboseYTest()
        {
            var coordinateY = new Vector(3, 4, 5);
            Assert.AreEqual("4", coordinateY.VerboseY());
        }
        [TestMethod()]
        public void VerboseZTest()
        {
            var coordinateZ = new Vector(3, 4, 5);
            Assert.AreEqual("5", coordinateZ.VerboseZ());
        }
        [TestMethod()]
        public void SumTest()
        {
            var vectorA = new Vector(3, 4, 5);
            var vectorB = new Vector(3, 4, 5);
            var vectorC = Vector.VectorSum(vectorA, vectorB);
            Assert.AreEqual("6", vectorC.VerboseX());
            Assert.AreEqual("8", vectorC.VerboseY());
            Assert.AreEqual("10", vectorC.VerboseZ());
        }
        [TestMethod()]
        public void MinusTest()
        {
            var vectorA = new Vector(3, 4, 5);
            var vectorB = new Vector(3, 4, 5);
            var vectorC = Vector.VectorMinus(vectorA, vectorB);
            Assert.AreEqual("0", vectorC.VerboseX());
            Assert.AreEqual("0", vectorC.VerboseY());
            Assert.AreEqual("0", vectorC.VerboseZ());
        }
        [TestMethod()]
        public void LengthTest()
        {
            var vectorC = new Vector(0, 3, 4);
            var length = Vector.VectorLength(vectorC);
            Assert.AreEqual(5, length);
        }
        [TestMethod()]
        public void DotProductTest()
        {
            var vectorA = new Vector(1, 2, 3);
            var vectorB = new Vector(1, 2, 3);
            var vectorC = Vector.DotProductOfVector(vectorA, vectorB);
            Assert.AreEqual(14, vectorC);
        }
        [TestMethod()]
        public void MultiTest()
        {
            var vectorA = new Vector(1, 3, 5);
            var vectorB = new Vector(2, 4, 6);
            var vectorC = Vector.VectorMultiOfVectors(vectorA, vectorB);
            Assert.AreEqual("-2", vectorC.VerboseX());
            Assert.AreEqual("4", vectorC.VerboseY());
            Assert.AreEqual("-2", vectorC.VerboseZ());
        }
    }
}