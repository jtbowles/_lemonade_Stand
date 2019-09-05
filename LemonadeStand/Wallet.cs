using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double totalMoney;

        public Wallet()
        {
            totalMoney = 20.00;
        }

        public void IncrementMoney(double money)
        {
            totalMoney += money;
        }

        public void DecrementMoney(double cost)
        {
            totalMoney -= cost;
        }

        //public bool CheckMoney(double cost)
        //{
        //    if(cost > totalMoney)
        //    {
        //        return false;
        //    }
        //    else if(cost == totalMoney)
        //}
    }
}