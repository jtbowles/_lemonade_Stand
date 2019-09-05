using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        public string name;
        public double cost;

        public abstract void CalculateCost(double amount);
    }
}
