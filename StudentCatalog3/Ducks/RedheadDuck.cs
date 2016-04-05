using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck(IFly flyBehavior) : base(flyBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a redhead duck.");
        }
    }
}