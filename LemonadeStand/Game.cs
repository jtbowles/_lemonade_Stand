using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player = new Player();
        //Store store = new Store();
        Day day = new Day();



        public void RunGame()
        {
            day.GenerateWeather();
            UI.DisplayWeather(day.weather.weatherCondition, day.weather.temperature);
            double priceOfProduct = UI.SetPriceOfProduct();
            day.priceOfProduct = priceOfProduct;
            day.GetNumberOfCustomers();
            UI.DisplayNumberOfCustomers(day.numberOfCustomers);
            Console.Read();

        }
    }
}
