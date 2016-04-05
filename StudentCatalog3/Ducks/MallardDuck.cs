using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck(IFly fly) : base(fly)
        {
        }

        public override void Display()
        {
            Console.Write("I am a Mallard duck (and quite happy about it).");
        }
    }
}