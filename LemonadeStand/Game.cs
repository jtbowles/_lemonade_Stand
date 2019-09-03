using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Day day;
        


        //public void DisplayPlayerMenu()
        //{
        //    string userInput = Console.ReadLine();

        //    switch (userInput)
        //    {
        //        case "1":
        //            // display weather forecast
        //            break;

        //        case "2":
        //            // visit store
        //            break;

        //        case "3":
        //            // set pitcher requirements
        //            break;

        //        case "4":
        //            // simulate day
        //            break;

        //        default:
        //            break;
        //    }
        //}

        public void GenerateNewDay()
        {
            day = new Day();
        }

        public void RunGame()
        {
            GenerateNewDay();
            day.GenerateWeather();
            UI.DisplayWeather(day.weather.forecastType, day.weather.temperature);
        }
    }
}
