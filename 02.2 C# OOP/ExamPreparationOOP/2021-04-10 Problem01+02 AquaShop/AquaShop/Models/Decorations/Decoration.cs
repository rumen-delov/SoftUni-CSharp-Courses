using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public abstract class Decoration : IDecoration
    {
        // the constructor is protected because the class is abstract
        protected Decoration(int comfort, decimal price)
        {
            this.Comfort = comfort;
            this.Price = price;
        }

        public int Comfort { get; private set; }

        public decimal Price { get; private set; }
    }
}
