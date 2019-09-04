using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        
        public string actualCondition;
        public int actualTemperature;
        public int forecastTemperature;
        public bool flipCoin;
        public List<string> weatherConditions = new List<string>() { "hazy", "rainy", "cloudy", "sunny", "humid" };
        public Random random;

        public Weather(Random rng)
        {
            random = rng;
        }

        public void GetForecastTemperature()
        {
            int forecastCurve = random.Next(1, 6);
            
            if (flipCoin)
            {
                forecastTemperature = actualTemperature + forecastCurve;
            }
            else if (!flipCoin)
            {
                forecastTemperature = actualTemperature - forecastCurve;
            }
        }

        public void FlipACoin()
        {
            int randomNumber = random.Next(0, 11);
            if(randomNumber >= 0 && randomNumber < 6)
            {
                flipCoin = true;
            }
            else if(randomNumber >= 6 && randomNumber < 11)
            {
                flipCoin = false;
            }
        }

        public void GetWeatherCondition()
        {
            int index = random.Next(weatherConditions.Count);
            actualCondition = weatherConditions[index];
        }

        public void GetTemperature()
        {
            actualTemperature = random.Next(60, 100);
        }
    }
}
