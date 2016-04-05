using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentCatalog3.Ducks;
using StudentCatalog3.Discount;

namespace StudentCatalog3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_DiscountRules_Group1_0()
        {
            //0 - 499.999: 0
            //500-1000: 10
            //1000- ?: 20


            //Arrange
            DiscountRules dr = new DiscountRules();

            //Act (Action)
            int result = dr.Calculate(0);

            //Assert
            Assert.AreEqual(0, result);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]//Assert statement here
        public void Test_DiscountRules_Invalid1_NegativeNumber()
        {
            DiscountRules dr = new DiscountRules();

            int result = dr.Calculate(-1);
        }



        [TestMethod]
        public void Test_DiscountRules_Group1_LargeNumber()
        {
            DiscountRules dr = new DiscountRules();
   
            int result = dr.Calculate(499.99);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test_DiscountRules_Group2_SmallNumber()
        {
            DiscountRules dr = new DiscountRules();

            int result = dr.Calculate(500);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Test_DiscountRules_Group2_LargeNumber()
        {
            DiscountRules dr = new DiscountRules();

            int result = dr.Calculate(999.99);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Test_DiscountRules_Group3_LargeNumber()
        {
            DiscountRules dr = new DiscountRules();

            int result = dr.Calculate(99999);

            Assert.AreEqual(20, result);
        }

       // [TestMethod]
        public void TestMethod1()
        {
            CanFly canFly = new CanFly();
            MallardDuck mallard = new MallardDuck(canFly);
            mallard.Display();
            mallard.Fly();

            RubberDuck rubberDuck =
                new RubberDuck(new NoFly());
            rubberDuck.Display();
            rubberDuck.Fly();


        }

    }
}
