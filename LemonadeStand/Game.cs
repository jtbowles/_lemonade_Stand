using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Day day = new Day();
        //Player player = new Player();
        //Store store = new Store();



        public void RunGame()
        {
            day.GenerateWeather();
            UI.DisplayWeather(day.weather.actualCondition, day.weather.forecastTemperature);
            UI.DisplayActualWeather(day.weather.actualCondition, day.weather.actualTemperature);



            //double priceOfProduct = UI.SetPriceOfProduct();
            //day.priceOfProduct = priceOfProduct;
            //day.GetNumberOfCustomers();
            //UI.DisplayNumberOfCustomers(day.numberOfCustomers);
            Console.Read();

        }
    }
}
