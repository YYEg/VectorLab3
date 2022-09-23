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
    }
}