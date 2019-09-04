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
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  The forecast for today is {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("             press [enter] to continue");
        }

        public static void DisplayActualWeather(string forecast, int temperature)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  Today's actual weather is {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("             press [enter] to continue");
        }

        public static void DisplayNumberOfCustomers(List<Customer> customers)
        {
            Console.WriteLine("There are {0} customers willing to buy", customers.Count);
        }

        public static void DisplayWeeklyForecast(List<Weather> weeklyWeatherForecast)
        {
            Console.Clear();
            for (int i = 1; i < weeklyWeatherForecast.Count; i++)
            {

                Console.WriteLine("  Day {0} forecast is {1} and {2} degrees.", i, weeklyWeatherForecast[i].actualCondition ,weeklyWeatherForecast[i].forecastTemperature);
            }
        }


        public static void DisplayWeatherMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Weather Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  [1] View Daily Forecast");
            Console.WriteLine("  [2] View Actual Weather");
            Console.WriteLine("  [3] View Weekly Forecast");
            Console.WriteLine("  [4] To Quit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }
    }
}
