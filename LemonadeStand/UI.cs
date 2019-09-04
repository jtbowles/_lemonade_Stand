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


        // PITCHER

        public static void SetPriceOfProduct()
        {
            Console.Clear();
            Console.WriteLine("  -------------------------------------------------------------------------------");
            Console.WriteLine("  Please [enter] the amount you wish to charge | we recommend starting at $0.25");
            Console.WriteLine("  -------------------------------------------------------------------------------");
        }

        public static void SetNumberOfLemons()
        {
            Console.Clear();
            Console.WriteLine("  -----------------------------------------------------------------------------------------------");
            Console.WriteLine("  Please [enter] the amount of lemons you wish to use per pitcher | we recommend starting with 4");
            Console.WriteLine("  -----------------------------------------------------------------------------------------------");
        }

        public static void DisplayRecipeContents(Pitcher pitcher)
        {
            Console.Clear();
            Console.WriteLine("  Recipe: ");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("  Lemons per pitcher:        {0}", pitcher.numberOfLemons);
            Console.WriteLine("  Cups of Sugar per pitcher: {0}", pitcher.cupsOfSugar);
            Console.WriteLine("  Ice Cubes per cup:         {0}", pitcher.icePerCup);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("  Price per cup: $ {0}", pitcher.pricePerCup);
        }

        public static void SetAmountOfIce()
        {
            Console.Clear();
            Console.WriteLine("  ---------------------------------------------------------------------------------------");
            Console.WriteLine("  Please [enter] the amount of ice you wish to use per cup | we recommend starting with 4");
            Console.WriteLine("  ---------------------------------------------------------------------------------------");
        }

        public static void SetCupsOfSugar()
        {
            Console.Clear();
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Please [enter] the amount of cups of sugar you wish to use per pitcher | we recommend starting with 4");
            Console.WriteLine("  -----------------------------------------------------------------------------------------------------");
        }

        public static void DisplayPitcherMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Pitcher Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  [1] Set price of product");
            Console.WriteLine("  [2] Set number of lemons per pitcher");
            Console.WriteLine("  [3] Set number of ice cubes per cup");
            Console.WriteLine("  [4] Set cups of sugar per pitcher");
            Console.WriteLine("  [5] Check current recipe");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }



        public static void DisplayWeatherMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Weather Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  [1] View Daily Forecast");
            Console.WriteLine("  [2] View Actual Weather");
            Console.WriteLine("  [3] Generate Customers");
            Console.WriteLine("  [4] To Quit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }

        public static void DisplayPlayerMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Player Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  [1] Set Pitcher");
            Console.WriteLine("  [2] View Pitcher Recipe");
            Console.WriteLine("  [3] View Weekly Forecast");
            Console.WriteLine("  [4] To Quit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }
    }
}
