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
        public List<Weather> weeklyForecast;
        public List<Customer> listOfBuyingCustomers;
        public int numberOfCustomers;
        public double priceOfProduct;
        public Random random;
        public Item item;
        public bool pitcherIsFull;
        public bool cupStatus;


        public Day()
        {
            listOfBuyingCustomers = new List<Customer>();
            weeklyForecast = new List<Weather>();
            random = new Random();
            weather = new Weather(random);
            GenerateWeather();
        }

        public void GenerateWeather()
        {
            weather.GetWeatherCondition();
            weather.GetTemperature();
            weather.FlipACoin();
            weather.GetForecastTemperature();
        }

        public void GenerateDailyCustomers(Player player)
        {
            priceOfProduct = player.pitcher.pricePerCup;

            Random rng = new Random();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customer = new Customer(rng);
                customer.DetermineBuyLogic(priceOfProduct);

                if (customer.isBuying)
                {
                    listOfBuyingCustomers.Add(customer);
                }
            }
        }


        public void SellLemonade(Player player)
        {
            cupStatus = player.CheckCupStatus();
            if (!cupStatus)
            {
                // check if enough inventory items to create a new pitcher
            }
            else if (cupStatus)
            {
                player.pitcher.cupsPerPitcher--;
                item = new Cup();
                player.inventory.DecrementInventory(item, 1);
                item = new IceCube();
                player.inventory.DecrementInventory(item, player.pitcher.icePerCup);
                player.wallet.IncrementMoney(priceOfProduct);
                // process transaction

            }
        }


        public void GetNumberOfCustomers()
        {
            switch (weather.actualCondition)
            {
                case "hazy":
                case "sunny":
                case "humid":
                    if (weather.actualTemperature >= 90 && weather.actualTemperature <=100)
                    {
                        numberOfCustomers = random.Next(80, 100);
                    }
                    else if (weather.actualTemperature >= 80 && weather.actualTemperature < 90)
                    {
                        numberOfCustomers = random.Next(60, 80);
                    }
                    else if (weather.actualTemperature >= 70 && weather.actualTemperature < 80)
                    {
                        numberOfCustomers = random.Next(50, 70);
                    }
                    else
                    {
                        numberOfCustomers = random.Next(50, 60);
                    }
                    break;

                case "rainy":
                case "cloudy":
                    if (weather.actualTemperature >= 90 && weather.actualTemperature <= 100)
                    {
                        numberOfCustomers = random.Next(20, 70);
                    }
                    else if (weather.actualTemperature >= 80 && weather.actualTemperature < 90)
                    {
                        numberOfCustomers = random.Next(20, 50);
                    }
                    else if (weather.actualTemperature >= 70 && weather.actualTemperature < 80)
                    {
                        numberOfCustomers = random.Next(20, 30);
                    }
                    else
                    {
                        numberOfCustomers = random.Next(0, 20);
                    }
                    break;

                default:
                    numberOfCustomers = 50;
                    break;
            }
        }
    }
}
