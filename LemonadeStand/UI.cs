using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UI
    {
        public static void GetDaysToPlay()
        {
            Console.Clear();
            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine("  How many days would you like to play for?");
            Console.WriteLine("     [7]    or    [14]    or    [21]  ");
            Console.WriteLine(" -------------------------------------------");
        }

        public static void DisplayWeather(string forecast, int temperature)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  The forecast for today is {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("             press [enter] to continue");
        }

        public static void DisplayActualWeather(string forecast, int temperature)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("  Today's actual weather was {0} and {1} degrees.", forecast, temperature);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("             press [enter] to continue");
        }

        public static void DisplayNumberOfCustomers(List<Customer> customers)
        {
            Console.WriteLine("There are {0} customers willing to buy", customers.Count);
        }

        // WALLET

        public static void DisplayTotalMoney(Wallet wallet)
        {
            Console.Clear();
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("   Your account balance is currently at: ${0}", wallet.totalMoney);
            Console.WriteLine("  --------------------------------------------");
            Console.WriteLine("         press [enter] to continue");
        }

        // INVENTORY

        public static void DisplayInventoryContents(Inventory inventory)
        {
            Console.Clear();
            Console.WriteLine("  -------------------------");
            Console.WriteLine("      Your Inventory:");
            Console.WriteLine("  -------------------------");
            Console.WriteLine("   Lemons:           {0}", inventory.lemons.Count);
            Console.WriteLine("   Cups of Sugar:    {0}", inventory.cupsOfSugar.Count);
            Console.WriteLine("   Ice Cubes:        {0}", inventory.iceCubes.Count);
            Console.WriteLine("   Cups:             {0}", inventory.cups.Count);
            Console.WriteLine("  -------------------------");
            Console.WriteLine("  press [enter] to continue");
        }

        // STORE

        public static void DisplayDidNotPurchase()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------");
            Console.WriteLine("    Transaction did not occur.");
            Console.WriteLine("  ------------------------------");
            Console.WriteLine("   press [enter] for Store Menu");
        }

        public static void GetAmountToBuy(Item item)
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------------");
            Console.WriteLine("   A {0} costs: ${1}", item.name, item.cost);
            Console.WriteLine("   How many {0}(s) would you like to purchase?",item.name);
            Console.WriteLine("  ------------------------------------------");
        }

        public static void CheckAmountToBuy(Item item, int amountToPurchase)
        {
            Console.Clear();
            double totalItemCost = Convert.ToDouble(item.cost * amountToPurchase);
            Console.WriteLine("  ---------------------------------------------------");
            Console.WriteLine("   You wish to purchase {0} {1}(s) for ${2}?", amountToPurchase, item.name, totalItemCost);
            Console.WriteLine("  ---------------------------------------------------");
            Console.WriteLine("                enter [yes] or [no]");
        }

        public static void DisplayInsufficientFunds()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine("  I'm sorry but you don't have enough funds in your wallet");
            Console.WriteLine(" ----------------------------------------------------------");
            Console.WriteLine("         press [enter] to continue");
        }

        // PITCHER


        public static void DisplayIfRecipeIsSet()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------------------");
            Console.WriteLine("   Recipe Status : Complete ");
            Console.WriteLine("   Would you like to return to the Player Menu?");
            Console.WriteLine("  ------------------------------------------------");
            Console.WriteLine("               enter [yes] or [no]");
        }

        public static void DisplayRecipeIsNotSet()
        {
            Console.Clear();
            Console.WriteLine("  ----------------------------");
            Console.WriteLine("   Recipe Status : Incomplete ");
            Console.WriteLine("  ----------------------------");
            Console.WriteLine("   press [enter] to continue");
        }

        public static void SetPriceOfProduct()
        {
            Console.Clear();
            Console.WriteLine("  -------------------------------------------------------------------------------");
            Console.WriteLine("   Please [enter] the amount you wish to charge | we recommend starting at $0.25");
            Console.WriteLine("  -------------------------------------------------------------------------------");
        }

        public static void SetNumberOfLemons()
        {
            Console.Clear();
            Console.WriteLine("  ------------------------------------------------------------------------------------------------");
            Console.WriteLine("   Please [enter] the amount of lemons you wish to use per pitcher | we recommend starting with 4");
            Console.WriteLine("  ------------------------------------------------------------------------------------------------");
        }

        public static void DisplayRecipeContents(Pitcher pitcher)
        {
            Console.Clear();
            Console.WriteLine("  Current Recipe: ");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("  Lemons per pitcher:        {0}", pitcher.numberOfLemons);
            Console.WriteLine("  Cups of Sugar per pitcher: {0}", pitcher.cupsOfSugar);
            Console.WriteLine("  Ice Cubes per cup:         {0}", pitcher.icePerCup);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine("  Cost per cup: $ {0}", pitcher.pricePerCup);
        }

        public static void SetAmountOfIce()
        {
            Console.Clear();
            Console.WriteLine("  -----------------------------------------------------------------------------------------");
            Console.WriteLine("   Please [enter] the amount of ice you wish to use per cup | we recommend starting with 4");
            Console.WriteLine("  -----------------------------------------------------------------------------------------");
        }

        public static void SetCupsOfSugar()
        {
            Console.Clear();
            Console.WriteLine("  -------------------------------------------------------------------------------------------------------");
            Console.WriteLine("   Please [enter] the amount of cups of sugar you wish to use per pitcher | we recommend starting with 4");
            Console.WriteLine("  -------------------------------------------------------------------------------------------------------");
        }


        // GAME MENUS

        public static void DisplayStoreMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Store Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter [1] for lemons");
            Console.WriteLine("  enter [2] for sugar");
            Console.WriteLine("  enter [3] for ice cubes");
            Console.WriteLine("  enter [4] for cups");
            Console.WriteLine("  enter [5] to check your inventory");
            Console.WriteLine("  enter [6] to check your wallet");
            Console.WriteLine("  enter [7] to exit the store");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }


        public static void DisplayGameMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Game Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  Enter [1] to set and view your lemonade recipe");
            Console.WriteLine("  Enter [2] to view the daily forecast");
            Console.WriteLine("  Enter [3] to check your inventory");
            Console.WriteLine("  Enter [4] to visit the store");
            Console.WriteLine("  Enter [5] to simulate the day");
            Console.WriteLine("  Enter [6] to exit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }

        public static void DisplayPitcherMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Pitcher Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter [1] Set price of product");
            Console.WriteLine("  enter [2] Set number of lemons per pitcher");
            Console.WriteLine("  enter [3] Set number of ice cubes per cup");
            Console.WriteLine("  enter [4] Set cups of sugar per pitcher");
            Console.WriteLine("  enter [5] Check current recipe");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }



        public static void DisplayWeatherMenu()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("        Welcome to the Weather Menu");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  [1] View Daily Forecast");
            Console.WriteLine("  [2] View Actual Weather");
            Console.WriteLine("  [3] Generate Customers");
            Console.WriteLine("  [4] To Quit");
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("  enter the corresponding [number] value ");
        }
    }
}
