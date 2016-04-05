using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public abstract class Duck
    {
        private IFly flyBehavior;
        public Duck(IFly fly)
        {
            flyBehavior = fly;
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }


        public abstract void Display(); 
        public void Quack()
        {
            Console.WriteLine("Quack quack, I am a duck");
        }


    }
}