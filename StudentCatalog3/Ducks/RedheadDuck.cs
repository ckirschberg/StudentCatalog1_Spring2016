using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck(IFly fly) : base(fly)
        {

        }

        public override void Display()
        {
            Console.Write("I am a redhead duck");
        }
    }
}