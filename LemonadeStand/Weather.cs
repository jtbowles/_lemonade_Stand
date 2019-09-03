using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string weatherCondition;
        public int temperature;
        public List<string> weatherConditions = new List<string>() { "hazy", "rainy", "cloudy", "sunny", "humid"};
        public Random random;
        public int index;
        public int temperatureLow;
        public int temperatureHigh;

        public Weather()
        {
            random = new Random();
            temperatureLow = 60;
            temperatureHigh = 110;
        }

        public void GetForecastType()
        {
            index = random.Next(weatherConditions.Count);
            weatherCondition = weatherConditions[index];
        }

        public void GetTemperature()
        {
            temperature = random.Next(temperatureLow, temperatureHigh);
        }
    }
}
