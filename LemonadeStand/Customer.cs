using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public bool isBuying;
        public double amountWillingToPay;
        Random random;
        public int temperature;

        public Customer(int temperature)
        {
            this.temperature = temperature;
            random = new Random();
        }

        public void FindOutIfBuying()
        {
            
        }
    }
}
