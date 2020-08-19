using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            //Act
            string result = currentActor.GetOccupation();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestParameterizedConstructor()
        {
            //Arrange
            var currentActor = new Actor("Jonny Boy");
            var expected = "Jonny Boy";
            //Act
            string result = currentActor.ActorName;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSettingObjectProperty()
        {
            //Arrange
            var currentActor = new Actor();
            currentActor.ActorName = "Jonny Boy";
            var expected = "Jonny Boy";
            //Act
            string result = currentActor.ActorName;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActor()
        {
            //Arrange
            string details = "Booking can change if" +
                " actor starts trouble";
            var currentActor = new Actor("Adrian");
            var expected = "Actor Adrian is booked. " + details; ;
            //Act
            string result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestBookActorOnSpecificDate()
        {
            //Arrange
            string details = "Booking can change if" +
                " actor starts trouble";
            var currentActor = new Actor("Adrian");
            var expected = "Actor Adrian is booked on " + DateTime.Today.ToShortDateString() + ". " + details; ;
            //Act
            string result = currentActor.BookActor(DateTime.Today.ToShortDateString());
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFormattingOnSetterForBookActor()
        {
            //Arrange
            string details = "Booking can change if" +
                " actor starts trouble";
            var currentActor = new Actor("Adrian    ");
            var expected = "Actor Adrian is booked. " + details; ;
            //Act
            string result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            //Arrange
            var currentActor = new Actor { ActorName = "Ruth Love" };
            var expected = "Regular actor";
            //Act
            string result = currentActor.ActorDescription;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            //Arrange
            var currentActor = new Actor { ActorName = "Ruth Love", ActorAge = 27 };
            var expected = 27;
            //Act
            int result = currentActor.ActorAge;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
