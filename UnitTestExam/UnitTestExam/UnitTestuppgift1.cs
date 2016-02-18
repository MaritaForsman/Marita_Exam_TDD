using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam.Classes;

namespace UnitTestExam
{
    [TestClass]
    public class UnitTestuppgift1
    {
        [TestMethod]
        public void TestAntalInvånare()
        {
            Invånare i = new Invånare();
            var inv = i.AntalInvånare(i.antalår(3));
            Assert.AreEqual(25875, inv);

        }

        
    }
}
