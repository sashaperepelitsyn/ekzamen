using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System;

namespace UnitTests
{
    [TestClass]
    public class SpisokZada4UnitTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(SpisokZada4.Imya, SpisokZada4.GetName());
        }
        [TestMethod]
        public void GetTaskTest()
        {
            var SpisokZada4 = new SpisokZada4("Новая задача");
            var Zada4a = new Zada4a() { Zagolovok = "Новая задача", Data = DateTime.Now };
            SpisokZada4.AddTask(Zada4a);
            Assert.AreEqual(SpisokZada4, SpisokZada4);
        }
    }
}
