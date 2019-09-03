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
        public Customer customer;
        public List<Customer> listOfCustomers = new List<Customer>();
        public int numberOfCustomers;
        Random random;

        public Day()
        {
            random = new Random();
            weather = new Weather();
        }

        public void GenerateWeather()
        {
            weather.GetForecastType();
            weather.GetTemperature();
        }

        public void GetNumberOfCustomers()
        {
            switch (weather.forecastType)
            {
                case "hazy":
                case "sunny":
                case "humid":
                    numberOfCustomers = random.Next(50, 90);
                    break;

                case "rainy":
                case "cloudy":
                    numberOfCustomers = random.Next(20, 60);
                    break;

                default:
                    numberOfCustomers = 50;
                    break;
            }
        }

        public void GenerateDailyCustomers()
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customer = new Customer(weather.temperature);
                listOfCustomers.Add(customer);
            }
        }
    }
}
