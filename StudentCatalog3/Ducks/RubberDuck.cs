﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentCatalog3.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IFly fly) : base(fly)
        {
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck");
        }
    }
}