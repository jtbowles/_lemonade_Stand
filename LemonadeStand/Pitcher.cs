using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public double pricePerCup;

        public int numberOfLemons;
        public int cupsOfSugar;
        public int icePerCup;
        public int cupsPerPitcher;

        public bool isPriceSet;
        public bool isLemonSet;
        public bool isSugarSet;
        public bool isIceSet;
        public bool isSet;

        public Pitcher()
        {
            cupsPerPitcher = 12;
            isPriceSet = false;
            isLemonSet = false;
            isSugarSet = false;
            isIceSet = false;
            isSet = false;
        }

        public void SetUpPitcher()
        {
            while (!isSet)
            {
                UI.DisplayPitcherMenu();
                int userInput = Int32.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        UI.SetPriceOfProduct();
                        pricePerCup = double.Parse(Console.ReadLine());
                        isPriceSet = true;
                        break;

                    case 2:
                        UI.SetNumberOfLemons();
                        numberOfLemons = int.Parse(Console.ReadLine());
                        isLemonSet = true;
                        break;

                    case 3:
                        UI.SetAmountOfIce();
                        icePerCup = int.Parse(Console.ReadLine());
                        isIceSet = true;
                        break;

                    case 4:
                        UI.SetCupsOfSugar();
                        cupsOfSugar = int.Parse(Console.ReadLine());
                        isSugarSet = true;
                        break;

                    case 5:
                        UI.CheckWhatToSetForRecipe(isLemonSet, isIceSet, isSugarSet, isPriceSet);
                        Console.ReadLine();
                        break;

                    case 6:
                        UI.DisplayRecipeContents(this);
                        Console.ReadLine();
                        break;

                    default:
                        SetUpPitcher();
                        break;
                }
                CheckIfRecipeIsSet();
            }
            UI.DisplayRecipeContents(this);
            Console.ReadLine();
        }


        public void CheckIfRecipeIsSet()
        {
            if(isPriceSet && isLemonSet && isIceSet && isSugarSet)
            {
                isSet = true;
            }
        }
    }
}
