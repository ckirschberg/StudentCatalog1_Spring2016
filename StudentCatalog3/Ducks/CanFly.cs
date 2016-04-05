using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class CanFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Wuhuuuiiiii, I am flying!");
        }
    }
}