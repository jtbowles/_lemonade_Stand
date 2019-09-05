using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Pitcher pitcher;
        public Inventory inventory;
        public Wallet wallet;
        public bool pitcherIsSet;


        public Player()
        {
            pitcherIsSet = false;
            pitcher = new Pitcher();
            inventory = new Inventory();
            wallet = new Wallet();
        }


        // PITCHER
        public void SetUpPitcher()
        {
            while (!pitcherIsSet)
            {
                UI.DisplayPitcherMenu();
                int userInput = Int32.Parse(Console.ReadLine());
                pitcher.SetPitcherRequirements(userInput);
                CheckIfRecipeSet();
            }
            UI.DisplayRecipeContents(pitcher);
            Console.ReadLine();
        }


        public void CheckIfRecipeSet()
        {
            if (pitcher.isPriceSet && pitcher.isLemonSet && pitcher.isIceSet && pitcher.isSugarSet)
            {
                pitcherIsSet = true;
            }
        }

        // EditPitcher() { pitcherIsSet = false; \n SetUpPitcher()}


        // INVENTORY

        public void CheckInventory()
        {

        }




    }
}
