using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double tirePessure, int tireAge)
        {
            Pessure = tirePessure;
            Age = tireAge;
        }

        public double Pessure { get; }
        public int Age { get; }
    }
}
