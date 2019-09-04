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

        public Pitcher()
        {
            cupsPerPitcher = 12;
            isPriceSet = false;
            isLemonSet = false;
            isSugarSet = false;
            isIceSet = false;
        }

        public void SetPitcherRequirements(int userInput)
        {
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
                    UI.DisplayRecipeContents(this);
                    Console.ReadLine();
                    break;

                case 6:
                    cupsOfSugar = 4;
                    numberOfLemons = 4;
                    icePerCup = 4;
                    pricePerCup = 0.25;
                    isLemonSet = true;
                    isPriceSet = true;
                    isIceSet = true;
                    isSugarSet = true;
                    break;

                default:
                    break;
            }
        }
    }
}
