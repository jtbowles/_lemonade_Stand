using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string forecastType;
        public int temperature;
        public List<string> forecasts = new List<string>() { "hazy", "rainy", "cloudy", "sunny", "humid"};
        public Random random;
        public int index;
        public int temperatureLow;
        public int temperatureHigh;

        public Weather()
        {
            random = new Random();
            temperatureLow = 60;
            temperatureHigh = 110;
            GetForecastType();
            GetTemperature();
        }

        public void GetForecastType()
        {
            index = random.Next(forecasts.Count);
            forecastType = forecasts[index];
        }

        public void GetTemperature()
        {
            temperature = random.Next(temperatureLow, temperatureHigh);
        }
    }
}
