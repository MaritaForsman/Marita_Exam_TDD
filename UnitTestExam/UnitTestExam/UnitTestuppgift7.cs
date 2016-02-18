using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam.Classes;

namespace UnitTestExam
{
    [TestClass]
    public class UnitTestuppgift7
    {
    Grönalund g;

        [TestInitialize]
         public void setup()
          {
            g = new Grönalund();
          }
        [TestMethod]
        public void TestålderBarn()
        {
            
            g.ålder(7);
            Assert.AreEqual("Gratis" , g.getMessage());
        }
        [TestMethod]
        public void TestålderUngdom()
        {
            
            g.ålder(10);
            Assert.AreEqual("Ungdom", g.getMessage());
        }
        [TestMethod]
        public void TestålderVuxen()
        {

            g.ålder(16);
            Assert.AreEqual("Vuxen", g.getMessage());
        }
        [TestMethod]
        public void TestSelection()
        {

            g.val("Fortsätta");
            //Assert.AreEqual("Vuxen", g.getMessage());
        }
        [TestMethod]
        public void Test1vuxen1UngdomVardag()
        {
            g.ålder(50);
            g.ålder(14);
            g.Veckodag("tisdag");
            Assert.AreEqual(150, g.getSumma());
        }
        [TestMethod]
        public void Test2UngdomVardag()
        {
            g.ålder(13);
            g.ålder(14);
            g.Veckodag("tisdag");
            Assert.AreEqual(100, g.getSumma());
        }
        [TestMethod]
        public void Test2FamiljHelg()
        {
            g.ålder(7);
            g.ålder(14);
            g.ålder(30);
            g.Veckodag("söndag");
            Assert.AreEqual(300, g.getSumma());
        }
        [TestMethod]
        public void TestSelectionBetala()
        {
            g.ålder(50);
            g.ålder(14);
            g.val("betala");
            g.Veckodag("tisdag");
            Assert.AreEqual(150, g.getSumma());
        }
    }
}
