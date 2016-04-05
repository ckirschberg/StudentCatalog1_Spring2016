using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class NoFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("*sob* I can't fly *breaks into uncontrollable crying*");
        }
    }
}