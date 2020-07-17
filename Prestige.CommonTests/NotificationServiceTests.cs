using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Common;

namespace Prestige.CommonTests
{
    [TestClass]
    public class NotificationServiceTests
    {
        [TestMethod]
        public void TestNotifyTalent()
        {
            //Arrange
            var expect = "Notify talent: Adrian";
            //Act
            var actual = NotificationService.NotifyTalent("Adrian");
            //Assert
            Assert.AreEqual(expect, actual);
        }
    }
}
