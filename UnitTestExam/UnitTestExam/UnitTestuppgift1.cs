using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam.Classes;

namespace UnitTestExam
{
    [TestClass]
    public class UnitTestuppgift1
    {
        Invånare i;
        [TestInitialize]
        public void setup()
        {
            i = new Invånare();
        }
        [TestMethod]
        public void TestAntalInvånare()
        {
            Invånare i = new Invånare();
            i.AntalInvånare(2016);

            Assert.AreEqual(26313, i.AntalInvånare(2016));

        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestAntalÅrTidigare()
        {
            i.AntalInvånare(2014);

        }
        [TestMethod]
        public void TestAntalInvånareMedFöddaOchDöda()
        {
            Assert.AreEqual(27277, i.AntalInvånare(2019));

        }
        


    }
}
