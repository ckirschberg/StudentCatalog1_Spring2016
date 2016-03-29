using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class FastFlyBehavior : IFly
    {
        public void Fly()
        {
            Console.Write("I fly as an aeroplane");
        }
    }
}