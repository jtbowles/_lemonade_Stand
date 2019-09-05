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
        public List<Cup> cups;
        public List<CupOfSugar> cupsOfSugar;
        public List<IceCube> iceCubes;
        public Item item;

        public Inventory()
        {
            lemons = new List<Lemon>();
        }
    }
}
