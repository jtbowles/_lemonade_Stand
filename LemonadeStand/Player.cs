﻿using System;
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
        public bool isPitcherSet;


        public Player()
        {
            isPitcherSet = true;
            pitcher = new Pitcher();
            inventory = new Inventory();
            wallet = new Wallet();
        }


        // PITCHER
        public void SetUpPitcher()
        {
            while (!isPitcherSet)
            {
                UI.DisplayPitcherMenu();
                int userInput = Int32.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        UI.SetPriceOfProduct();
                        pitcher.pricePerCup = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        UI.SetNumberOfLemons();
                        pitcher.numberOfLemons = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        UI.SetAmountOfIce();
                        pitcher.icePerCup = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                        UI.SetCupsOfSugar();
                        pitcher.cupsOfSugar = int.Parse(Console.ReadLine());
                        break;

                    case 5:
                        UI.DisplayRecipeContents(pitcher);
                        Console.ReadLine();
                        break;

                    case 6:
                        CheckIfRecipeSet();
                        break;

                    default:
                        break;
                }
            }
            UI.DisplayRecipeContents(pitcher);
            Console.ReadLine();
        }


        public void CheckIfRecipeSet()
        {
            if (pitcher.isPriceSet && pitcher.isLemonSet && pitcher.isIceSet && pitcher.isSugarSet)
            {
                UI.DisplayIfRecipeIsSet();
                string yesNo = Console.ReadLine();
                if(yesNo == "yes")
                {
                    isPitcherSet = true;
                }
            }
            else
            {
                UI.DisplayRecipeIsNotSet();
                Console.ReadLine();
            }
        }
    }
}
