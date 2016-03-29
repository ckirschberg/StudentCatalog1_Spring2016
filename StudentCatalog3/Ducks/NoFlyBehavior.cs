using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class NoFlyBehavior : IFly
    {
        public void Fly()
        {
            Console.WriteLine("*sobs* I can't fly");
        }
    }
}