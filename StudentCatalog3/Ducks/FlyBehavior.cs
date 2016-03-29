using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class FlyBehavior : IFly
    {
        public void Fly()
        {
            Console.Write("Uhhhuuuii, I am flying");
        }
    }
}







