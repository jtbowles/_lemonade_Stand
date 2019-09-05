using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<Item> cups;
        public List<Item> cupsOfSugar;
        public List<Item> iceCubes;
        public Item item;

        public Inventory()
        {
            lemons = new List<Lemon>();
        }
    }
}
