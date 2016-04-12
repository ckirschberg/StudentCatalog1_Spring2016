using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentCatalog3.DateSpanExercise;

namespace StudentCatalog3.Tests
{
    [TestClass]
    public class DateSpanTest2
    {
        //Arrange
        DateSpan span = new DateSpan
        {
            from = new DateTime(2016, 6, 1),
            to = new DateTime(2016, 6, 20)
        };


        [TestMethod]
        public void Test_BeforeSpan_ShouldReturnFalse()
        {
            //Arrange
            //Act
            //Assert
            //Assert.IsFalse(DateSpan.IsOverlap(new DateTime(2015, 1, 1), new DateTime(2016, 4, 4)));
        }




        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            //Act
            //Assert
            Boolean result = span.IsOverlap(
                new DateTime(2016, 1, 1),
                new DateTime(2016, 8, 20));

            Assert.IsTrue(result);    
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            //Act
            //Assert
            Boolean result = span.IsOverlap(
                new DateTime(2016, 10, 1),
                new DateTime(2016, 10, 20));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            //Act
            //Assert
            Boolean result = span.IsOverlap(
                new DateTime(2016, 5, 1),
                new DateTime(2016, 6, 10));

            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            //Act
            //Assert
            Boolean result = span.IsOverlap(
                new DateTime(2016, 6, 10),
                new DateTime(2016, 6, 29));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            //Act
            //Assert
            Boolean result = span.IsOverlap(
                new DateTime(2016, 6, 10),
                new DateTime(2016, 6, 13));

            Assert.IsTrue(result);
        }
        
    }
}
