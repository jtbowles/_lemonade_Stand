using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public List<Customer> customers = new List<Customer>();

        public Day()
        {
            weather = new Weather();
        }

        public void GenerateWeather()
        {
            weather.GetForecastType();
            weather.GetTemperature();
        }

    }
}
