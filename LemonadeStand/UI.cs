using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UI
    {
        public static void DisplayWeather(string forecast, int temperature)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  The forecast for today is {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.Read();
        }

        //public static void DisplayPlayerMenu()
        //{
        //    Console.WriteLine();
        //}
    }
}
