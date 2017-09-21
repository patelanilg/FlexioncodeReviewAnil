using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlexionCodeReview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace FlexionCodeReview.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            double side1 = 1.5;
            double side2 = 1.5;
            double side3 = 1.5;
            
            Program.checktriangle(side1,side2,side3);
            //Assert.Fail();
            Assert.AreEqual("Equilateral",true);
        }
 
        [TestMethod()]
        public void MainTest2()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 4;
 
            Program.checktriangle(side1, side2, side3);
            //Assert.FailIsoSceles
            Assert.AreEqual("Triangle", true);
        }
        public void MainTest3()
        {
            double side1 = 4.4;
            double side2 = 7.3;
            double side3 = 9.1;
 
            Program.checktriangle(side1, side2, side3);
            //Assert.FailIsoSceles
            Assert.AreEqual("Scalene", true);
        }
        public void MainTest4()
        {
            double side1 = 4;
            double side2 = 6;
            double side3 = 11;
 
            Program.checktriangle(side1, side2, side3);
            //Assert.FailIsoSceles
            Assert.AreEqual("Not Triangle", true);
        }
    }
}
