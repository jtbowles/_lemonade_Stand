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
        public Pitcher pitcher;
        public List<Weather> weeklyForecast;
        public List<Customer> listOfBuyingCustomers;
        public int numberOfCustomers;
        public Random random;
        public Item item;
        public bool pitcherIsFull;
        public bool cupStatus;
        public int whichDay;

        public double priceOfProduct;
        public int lemonsForRecipe;
        public int sugarForRecipe;
        public int iceForRecipe;
        public bool recipeIsSet;
        public bool exitQualityControlMenu;
        public bool isRunning;


        public Day(int dayCounter)
        {
            whichDay = dayCounter;
            listOfBuyingCustomers = new List<Customer>();
            weeklyForecast = new List<Weather>();
            random = new Random();
        }


        // RUN DAY METHOD

        public void RunDay(Player player, Store store, Day day)
        {
            bool inventoryCheck = player.inventory.InventoryCheck();
            if (inventoryCheck)
            {
                GenerateWeather();
                UI.DisplayActualWeather(weather.actualCondition, weather.actualTemperature);
                SetQualityControl();
            }
            else
            {
                UI.DisplayInventoryContents(player.inventory);
                UI.DisplayNotEnoughInventory();
                // display "not enough inventory items to run a day"
                // travel to the store to purchase items
            }

        }


        // WEATHER
        public void GenerateWeather()
        {
            weather = new Weather(random);
            weather.GetWeatherCondition();
            weather.GetTemperature();
            weather.FlipACoin();
            weather.GetForecastTemperature();
        }

        // CUSTOMERS
        public void GenerateDailyCustomers()
        {
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

        // PITCHER

        public void SetQualityControl()
        {
            exitQualityControlMenu = false;

            while (!exitQualityControlMenu)
            {
                UI.DisplayQualityControl();
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        UI.SetPriceOfProduct();
                        priceOfProduct = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        UI.SetNumberOfLemons();
                        lemonsForRecipe = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        UI.SetAmountOfIce();
                        iceForRecipe = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        UI.SetCupsOfSugar();
                        sugarForRecipe = int.Parse(Console.ReadLine());
                        break;

                    case 5:
                        CheckIfRecipeSet();
                        if (recipeIsSet)
                        {
                            string yesNo = UI.DisplayIfRecipeIsSet();
                            if (yesNo == "yes")
                            {
                                exitQualityControlMenu = true;
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        public void CreateNewPitcher(Player player)
        {
            pitcher = new Pitcher(lemonsForRecipe, sugarForRecipe, iceForRecipe);
            bool inventoryCheck = player.inventory.CheckPitcherRequirements(pitcher);
            if (inventoryCheck)
            {
                // decrement inventory
            }
            else
            {
                // not enough inventory
            }
        }

        public void CheckIfRecipeSet()
        {
            if(priceOfProduct > 0 && lemonsForRecipe > 0 && iceForRecipe > 0 && sugarForRecipe > 0)
            {
                recipeIsSet = true;
            }
            else
            {
                recipeIsSet = false;
                UI.DisplayRecipeIsNotSet();
            }
        }
    }
}
