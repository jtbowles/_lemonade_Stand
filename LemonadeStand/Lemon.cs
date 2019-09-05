using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon : Item
    {


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
