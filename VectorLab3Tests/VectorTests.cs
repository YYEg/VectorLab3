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
        public void VerboseTest()
        {
            var coordinateX = new Vector(3);
            Assert.AreEqual(3, coordinateX.Verbose());
        }

        [TestMethod()]
        public void VectorCoordinateSum()
        {
            var coordinateX = new Vector(3);
            coordinateX = coordinateX + 3;
            Assert.AreEqual(6, coordinateX.Verbose());
        }

        [TestMethod()]
        public void VectorCoordinateDelete()
        {
            var coordinateX = new Vector(3);
            coordinateX = coordinateX - 3;
            Assert.AreEqual(0, coordinateX.Verbose());
        }
        [TestMethod()]
        public void VectorCoordinateMultiply()
        {
            var coordinateX = new Vector(3);
            coordinateX = coordinateX * 3;
            Assert.AreEqual(9, coordinateX.Verbose());
        }
        [TestMethod()]
        public void TwoVectorCoordinateSum()
        {
            var w = new Vector(3);
            var e = new Vector(3);
            Assert.AreEqual(6, (w+e).Verbose());
        }
        [TestMethod()]
        public void VectorCoordinateExtent()
        {
            var coordinateX = new Vector(3);
            coordinateX = Vector.Extent(coordinateX,3);
            Assert.AreEqual(27, coordinateX.Verbose());
        }
        [TestMethod()]
        public void VectorCoordinateRadical()
        {
            var coordinateX = new Vector(9);
            coordinateX = Vector.Radical(coordinateX);
            Assert.AreEqual(3, coordinateX.Verbose());
        }
    }
}