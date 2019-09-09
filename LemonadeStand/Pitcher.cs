using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public int lemonsRequired;
        public int cupsOfSugarRequired;
        public int iceCubesRequired;
        public int cupsPerPitcher = 12;

        public Pitcher(int lemons, int sugar, int ice)
        {
            lemonsRequired = lemons;
            cupsOfSugarRequired = sugar;
            iceCubesRequired = ice * cupsPerPitcher;
        }
    }
}
