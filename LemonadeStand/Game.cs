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
        

        public void GenerateNewDay()
        {
            day = new Day();
        }

        public void RunGame()
        {
            GenerateNewDay();
            UI.DisplayWeather(day.weather.forecastType, day.weather.temperature);
        }
    }
}
