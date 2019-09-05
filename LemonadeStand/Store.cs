using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public bool isShopping;
        public bool sufficientFunds;
        public Item item;
        public int amountToPurchase;
        public double totalCostOfPurchase;

        public Store()
        {
            isShopping = false;
        }


        public void GetAmountToBuy()
        {
            UI.GetAmountToBuy(item);
            amountToPurchase = Convert.ToInt32(Console.ReadLine());
        }

        public void GetTotalCost()
        {
            totalCostOfPurchase = Convert.ToDouble(item.cost * amountToPurchase);
        }

        public void CheckSufficientFunds(Player player)
        {
            sufficientFunds = player.wallet.CheckMoney(totalCostOfPurchase);

            if (sufficientFunds)
            {
                UI.CheckAmountToBuy(item, amountToPurchase);
                string yesNo = Console.ReadLine();
                if(yesNo == "yes")
                {
                    CheckOutAtRegister(player);
                }
            }
            else if (!sufficientFunds)
            {
                UI.DisplayInsufficientFunds();
            }
        }

        public void CheckOutAtRegister(Player player)
        {
            player.wallet.DecrementMoney(totalCostOfPurchase);
            // display wallet
            player.inventory.IncrementInventory(item, amountToPurchase);
            // display inventory
        }

        public void VisitStore(Player player)
        {
            while (isShopping)
            {
                UI.DisplayStoreMenu();
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        item = new Lemon();
                        break;

                    case 2:
                        item = new CupOfSugar();
                        break;

                    case 3:
                        item = new IceCube();
                        break;

                    case 4:
                        item = new Cup();
                        break;

                    case 5:
                        // check inventory
                        break;

                    case 6:
                        // check wallet
                        break;

                    case 7:
                        isShopping = false;
                        break;

                    default:
                        break;
                }
                GetAmountToBuy();
                GetTotalCost();
                CheckSufficientFunds(player);
            }
        }
    }
}
