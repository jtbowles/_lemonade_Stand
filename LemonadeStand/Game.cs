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
        public int daysToPlay;
        public int dayCount;
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
                        player.SetUpPitcher();
                        // Set Pitcher
                        break;

                    case 2:
                        UI.DisplayWeather(day.weather.actualCondition, day.weather.forecastTemperature);
                        Console.ReadLine();
                        // View daily forecast
                        break;

                    case 3:
                        UI.DisplayInventoryContents(player.inventory);
                        Console.ReadLine();
                        // Display Inventory
                        break;

                    case 4:
                        store.isShopping = true;
                        store.VisitStore(player);
                        // Visit store
                        // instantiate new store and pass player as a parameter "visiting the store"
                        break;

                    case 5:
                        GenerateCustomers(player);
                        // Simulate day
                        // Increment totalMoney
                        // Decrement inventory
                        // dayCount++
                        break;

                    case 6:
                        dayCount = daysToPlay + 1;
                        break;

                    case 7:
                        // Display wallet totalMoney
                        break;

                    // Exit

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

        public void GenerateCustomers(Player player)
        {
            day.GetNumberOfCustomers();
            day.GenerateDailyCustomers(player);
        }



        //public void RunGame(int userInput)
        //{

        //    switch (userInput)
        //    {
        //        case 1:
        //            UI.DisplayWeather(day.weather.actualCondition, day.weather.forecastTemperature);
        //            Console.ReadLine();
        //            break;
        //        case 2:
        //            UI.DisplayActualWeather(day.weather.actualCondition, day.weather.actualTemperature);
        //            Console.ReadLine();
        //            break;
        //        case 3:
        //            GenerateCustomers();
        //            UI.DisplayNumberOfCustomers(day.listOfCustomers);
        //            Console.ReadLine();
        //            break;
        //        case 4:
        //            isOn = false;
        //            break;
        //        default:

        //            break;
        //    }
        //}

        //public void RunPlayerMenu()
        //{
        //    while (isOn)
        //    {
        //        UI.DisplayPlayerMenu();
        //        int userInput = Int32.Parse(Console.ReadLine());

        //        switch (userInput)
        //        {
        //            case 1:
        //                player.pitcher.SetUpPitcher();
        //                Console.ReadLine();
        //                break;
        //            case 2:
        //                UI.DisplayRecipeContents(player.pitcher);
        //                Console.ReadLine();
        //                break;
        //            case 3:
        //                Console.ReadLine();
        //                break;
        //            case 4:
        //                isOn = false;
        //                break;
        //            default:
        //                RunPlayerMenu();
        //                break;
        //        }
        //    }
        //}
    }
}
