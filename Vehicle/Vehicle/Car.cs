﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven..");
        }
    }
}
