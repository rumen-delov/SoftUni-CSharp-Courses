﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            Weight = cargoWeight;
            Type = cargoType;
        }

        public int Weight { get; }
        public string Type { get; }
    }
}
