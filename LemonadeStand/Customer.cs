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
        public Random random;

        public Customer(Random rng)
        {
            random = rng;
            DetermineAmountWillingToPay();
        }

        public void DetermineBuyLogic(double priceOfProduct)
        {
            if(amountWillingToPay  < priceOfProduct)
            {
                isBuying = false;
            }
            else if(amountWillingToPay >= priceOfProduct)
            {
                isBuying = true;
            }
        }

        public void DetermineAmountWillingToPay()
        {
            int customerCase = random.Next(4);

            switch (customerCase)
            {
                case 1:
                    amountWillingToPay = 0.12;
                    break;

                case 2:
                    amountWillingToPay = 0.38;
                    break;

                case 3:
                    amountWillingToPay = 0.24;
                    break;

                case 4:
                    amountWillingToPay = 0.19;
                    break;

                default:
                    amountWillingToPay = 0.25;
                    break;
            }
        }


    }
}
