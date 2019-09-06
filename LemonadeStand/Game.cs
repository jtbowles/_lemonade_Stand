using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public bool isOn;
        public bool dayIsRunning;
        public int daysToPlay;
        public int dayCount;
        public int totalBuyingCustomers;
        public double dailyProfit;
        public Player player;
        public Day day;
        public Store store;


        public Game()
        {
            isOn = true;
            dayCount = 1;
            day = new Day();
            player = new Player();
            store = new Store();
        }

        public void RunGame()
        {
            SetDaysToPlay();

            while (dayCount <= daysToPlay)
            {
                UI.DisplayGameMenu();
                int userInput = Int32.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        UI.DisplayWeather(day.weather.actualCondition, day.weather.forecastTemperature);

                        //UI.DisplayRecipeContents(player.pitcher);
                        //Console.ReadLine();
                        //player.isPitcherSet = false;
                        //player.SetUpPitcher();
                        break;

                    case 2:
                        UI.DisplayInventoryContents(player.inventory);
                        break;

                    case 3:
                        UI.DisplayTotalMoney(player.wallet);
                        break;

                    case 4:
                        store.isShopping = true;
                        store.VisitStore(player);
                        break;

                    case 5:
                        dayIsRunning = true;
                        GenerateBuyingCustomers();
                        RunDay();
                        // dayCount ++
                        break;

                    case 6:
                        dayCount = daysToPlay + 1;
                        break;

                    default:
                        RunGame();
                        break;
                }
            }
            // End of game
        }

        public void SetDaysToPlay()
        {
            UI.GetDaysToPlay();
            daysToPlay = Int32.Parse(Console.ReadLine());
            
            // write a user validation check
        }

        public void RunDay()
        {
            while (dayIsRunning)
            {
                UI.DisplayDayMenu();
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        UI.DisplayActualWeather(day.weather.actualCondition, day.weather.actualTemperature);
                        break;

                    case 2:
                        day.SetQualityControl();
                        // recipe quality control
                        break;

                    case 3:
                        // simulate buying and selling lemonade
                        break;

                    case 4:
                        // display daily scoresheet
                        break;

                    case 5:
                        // end the day
                        // check if day can be finalized
                        // dayIsRunning = false;
                    default:
                        break;
                }


            }
            // Simulate day
            // Increment totalMoney
            // Decrement inventory
            // dayCount++

        }

        public void GenerateBuyingCustomers()
        {
            day.GetNumberOfCustomers();
            day.GenerateDailyCustomers();
            totalBuyingCustomers = day.listOfBuyingCustomers.Count();
        }
    }
}
