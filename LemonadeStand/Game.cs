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
        public Day currentDay;
        public Store store;

        public List<Day> listOfDays;


        public Game()
        {
            isOn = true;
            dayCount = 1;
            player = new Player();
            store = new Store();
            listOfDays = new List<Day>();
        }

        public void RunGame()
        {
            SetDaysToPlay();
            //GenerateListOfDays();

            while (dayCount <= daysToPlay)
            {
                UI.DisplayGameMenu();
                int userInput = Int32.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        //UI.DisplayWeeklyForecast(listOfDays);
                        //UI.DisplayWeather(day.weather.actualCondition, day.weather.forecastTemperature);
                        // display weekly forecast
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
                        day.isRunning = true;
                        day.RunDay(player, store, day);
                        //dayIsRunning = true;
                        //GenerateBuyingCustomers();
                        // foreach(Day day in listOfDay){day.runDay}
                        // day.RunDay(day[i]);
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


        public void GenerateListOfDays()
        {
            for (int i = 1; i <= daysToPlay; i++)
            {
                CreateDay(i);
                listOfDays.Add(day);
            }
        }

        public void GetCurrentDay()
        {
        }

        public void CreateDay(int dayCounter)
        {
            day = new Day(dayCounter);
            day.GenerateWeather();
        }

        public void GenerateBuyingCustomers()
        {
            day.GetNumberOfCustomers();
            day.GenerateDailyCustomers();
            totalBuyingCustomers = day.listOfBuyingCustomers.Count();
        }
    }
}
