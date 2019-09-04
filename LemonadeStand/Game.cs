using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public bool isOn = true;
        Day day = new Day();
        Player player = new Player();
        //Store store = new Store();



        public void RunGame(int userInput)
        {

            switch (userInput)
            {
                case 1:
                    UI.DisplayWeather(day.weather.actualCondition, day.weather.forecastTemperature);
                    Console.ReadLine();
                    break;
                case 2:
                    UI.DisplayActualWeather(day.weather.actualCondition, day.weather.actualTemperature);
                    Console.ReadLine();
                    break;
                case 3:
                    GenerateCustomers();
                    UI.DisplayNumberOfCustomers(day.listOfCustomers);
                    Console.ReadLine();
                    break;
                case 4:
                    isOn = false;
                    break;
                default:
                    
                    break;
            }
        }

        public void RunPlayerMenu()
        {
            while (isOn)
            {
                UI.DisplayPlayerMenu();
                int userInput = Int32.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        // Set Pitcher
                        Console.ReadLine();
                        break;
                    case 2:
                        // View Recipe
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.ReadLine();
                        break;
                    case 4:
                        isOn = false;
                        break;
                    default:
                        RunPlayerMenu();
                        break;
                }
            }
        }

        public void GenerateCustomers()
        {
            day.GetNumberOfCustomers();
            day.GenerateDailyCustomers();
        }
    }
}
