﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Octopus:IAnimal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }
}
