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


        public Day(int dayCounter)
        {
            whichDay = dayCounter;
            listOfBuyingCustomers = new List<Customer>();
            weeklyForecast = new List<Weather>();
            random = new Random();
        }


        // RUN DAY METHOD

        public void RunDay()
        {
            GenerateWeather();
            UI.DisplayActualWeather(weather.actualCondition, weather.actualTemperature);
            SetQualityControl();

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
            // set ForRecipe fields equal to the pitcher requirements
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



        //public void CheckIfRecipeSet()
        //{
        //    if (pitcher.isPriceSet && pitcher.isLemonSet && pitcher.isIceSet && pitcher.isSugarSet)
        //    {
        //        UI.DisplayIfRecipeIsSet();
        //        string yesNo = Console.ReadLine();
        //        if (yesNo == "yes")
        //        {
        //            isPitcherSet = true;
        //        }
        //    }
        //    else
        //    {
        //        UI.DisplayRecipeIsNotSet();
        //        Console.ReadLine();
        //    }
        //}

        //public void SellLemonade(Player player)
        //{
        //    cupStatus = player.CheckCupStatus();
        //    if (!cupStatus)
        //    {
        //        // check if enough inventory items to create a new pitcher
        //    }
        //    else if (cupStatus)
        //    {
        //        player.pitcher.cupsPerPitcher--;
        //        item = new Cup();
        //        player.inventory.DecrementInventory(item, 1);
        //        item = new IceCube();
        //        player.inventory.DecrementInventory(item, player.pitcher.icePerCup);
        //        player.wallet.IncrementMoney(priceOfProduct);
        //        // process transaction

        //    }
        //}

        //public void ValidateEnoughInventoryToCreatePitcher(Pitcher pitcher)
        //{
        //    if (inventory.lemons.Count >= pitcher.numberOfLemons && inventory.cupsOfSugar.Count >= pitcher.cupsOfSugar)
        //    {
        //        enoughInventory = true;
        //    }
        //}

        //public bool CheckCupStatus()
        //{
        //    if (pitcher.cupsPerPitcher == 0)
        //    {
        //        pitcher.isFull = false;
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}


    }
}
