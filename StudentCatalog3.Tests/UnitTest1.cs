using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentCatalog3.Ducks;

namespace StudentCatalog3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FlyBehavior fly = new FlyBehavior();
            MallardDuck mallard = new MallardDuck(fly);
            mallard.Fly();

            //Manual constructor injection - Dependency injection
            RubberDuck rubberDuck = 
                new RubberDuck(new NoFlyBehavior());
            rubberDuck.Fly();


        }
    }
}
