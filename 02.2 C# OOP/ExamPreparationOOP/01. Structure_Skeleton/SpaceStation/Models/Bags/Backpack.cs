﻿using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Bags
{
    public class Backpack : IBag
    {
        public Backpack()
        {
            this.Items = new List<string>(); // TO CHECK
        }
        
        public ICollection<string> Items { get; private set; } // TO CHECK
    }
}
