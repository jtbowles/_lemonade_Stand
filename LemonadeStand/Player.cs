using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Pitcher pitcher;
        public Inventory inventory;
        public Wallet wallet;


        public Player()
        {
            pitcher = new Pitcher();
            inventory = new Inventory();
            wallet = new Wallet();
        }


    }
}
