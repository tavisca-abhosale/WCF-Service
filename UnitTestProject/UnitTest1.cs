using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.UserService;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cl = new UserServiceClient();
            var user=cl.GetUser(3285301);
        }
    }
}
