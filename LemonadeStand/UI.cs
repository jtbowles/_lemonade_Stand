﻿using System;
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
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  The forecast for today is {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.Read();
        }

        public static void DisplayActualWeather(string forecast, int temperature)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  Today's actual forecast is {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.Read();
        }

        public static void DisplayNumberOfCustomers(int numberOfCustomers)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  The amount of customers for the day is {0}", numberOfCustomers);
            Console.WriteLine("-----------------------------------------------------");
            Console.Read();
        }

        public static double SetPriceOfProduct()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  Please enter the price you wish to charge per cup: ");
            Console.WriteLine("-----------------------------------------------------");
            string userInput = Console.ReadLine();
            double userInputToDouble = double.Parse(userInput);
            return userInputToDouble;

        }

        public static int DisplayPlayerMenu()
        {
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Player Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  [1] View Daily Forecast");
            Console.WriteLine("  [2] View Actual Weather");
            Console.WriteLine("  [3] ");
            Console.WriteLine("  [4] ");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
    }
}
