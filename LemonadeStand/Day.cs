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
        public double priceOfProduct;
        Random random;

        public Day()
        {
            random = new Random();
            weather = new Weather();
        }

        public void GenerateWeather()
        {
            weather.GetWeatherCondition();
            weather.GetTemperature();
            weather.FlipACoin();
            weather.GetForecastTemperature();
        }

        //public void GetNumberOfCustomers()
        //{
        //    switch (weather.actualCondition)
        //    {
        //        case "hazy":
        //        case "sunny":
        //        case "humid":
        //            if(priceOfProduct <= 0.20)
        //            {
        //                numberOfCustomers = random.Next(50, 100);
        //            }
        //            else if(priceOfProduct > 0.20 && priceOfProduct <= 0.25)
        //            {
        //                numberOfCustomers = random.Next(50, 90);
        //            }
        //            else if(priceOfProduct > 0.25 && priceOfProduct <= 0.35)
        //            {
        //                numberOfCustomers = random.Next(50, 80);
        //            }
        //            else
        //            {
        //                numberOfCustomers = random.Next(50, 70);
        //            }
        //            break;

        //        case "rainy":
        //        case "cloudy":
        //            if (priceOfProduct <= 0.20)
        //            {
        //                numberOfCustomers = random.Next(20, 70);
        //            }
        //            else if (priceOfProduct > 0.20 && priceOfProduct <= 0.25)
        //            {
        //                numberOfCustomers = random.Next(20, 50);
        //            }
        //            else if (priceOfProduct > 0.25 && priceOfProduct <= 0.35)
        //            {
        //                numberOfCustomers = random.Next(20, 30);
        //            }
        //            else
        //            {
        //                numberOfCustomers = random.Next(0, 20);
        //            }
        //            break;

        //        default:
        //            numberOfCustomers = 50;
        //            break;
        //    }
        //}


        //public void GenerateDailyCustomers()
        //{
        //    for (int i = 0; i < numberOfCustomers; i++)
        //    {
        //        customer = new Customer(weather.temperature);
        //        listOfCustomers.Add(customer);
        //    }
        //}
    }
}
