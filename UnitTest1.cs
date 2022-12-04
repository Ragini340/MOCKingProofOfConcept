using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MOCKingProofOfConcept.Models;
using MOCKingProofOfConcept.Controllers;
using System;

namespace TestProjectMockingProofOfConcept
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IGetDataRepository>();
            mock.Setup(p => p.GetNameById(1)).Returns("Ragini");
            HomeController home = new HomeController(mock.Object);
            string result = home.GetNameById(1);
            Console.WriteLine(result);
            Assert.AreEqual("Ragini", result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var mocking = new Mock<IGetDataRepository>();
            mocking.Setup(mocking => mocking.GetNameById(2)).Returns("Ragini Singh");
            HomeController obj = new HomeController(mocking.Object);
            string result1 = obj.GetNameById(2);
            Console.WriteLine(result1);
            Assert.AreEqual("Ragini Singh", result1);
            
        }
        [TestMethod]
        public void TestMethod3()
        {
            var mocked = new Mock<IGetDataRepository>();
            mocked.Setup(mocking => mocking.GetNameById(3)).Returns("Not Found");
            HomeController obj = new HomeController(mocked.Object);
            string result2 = obj.GetNameById(3);
            Console.WriteLine(result2);
            Assert.AreEqual("Not Found", result2);
        }
        
    }
}
