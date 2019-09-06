using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public double pricePerCup;

        public int numberOfLemons;
        public int cupsOfSugar;
        public int icePerCup;
        public int cupsPerPitcher;

        public bool isPriceSet;
        public bool isLemonSet;
        public bool isSugarSet;
        public bool isIceSet;
        public bool isFull;

        public Pitcher()
        {
            cupsPerPitcher = 12;
            cupsOfSugar = 4;
            numberOfLemons = 4;
            icePerCup = 4;
            pricePerCup = 0.25;
            isLemonSet = true;
            isPriceSet = true;
            isIceSet = true;
            isSugarSet = true;
            isFull = true;
        }
    }
}
