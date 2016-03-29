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
            this.flyBehavior = fly;
        }

        public void Fly()
        {
            this.flyBehavior.Fly();
        }


        public void Quack()
        {
            Console.Write("Quack");
        }

        public abstract void Display();


    }
}