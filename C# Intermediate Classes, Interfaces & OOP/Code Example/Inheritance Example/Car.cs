﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Car : Vehicle
    {
        public void openTrunk()
        {
            Console.WriteLine("Trunk is open");
        }
    }
}
