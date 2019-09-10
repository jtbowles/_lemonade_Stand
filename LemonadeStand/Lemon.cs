using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon : Item
    {
        // LISKOV SUBSTITUTION PRINCIPLE
        // child classes of the parent class Item can be used in the same way as the parent class

        public Lemon()
        {
            name = "lemon";
            cost = .08;
        }
        public override void CalculateCost(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
