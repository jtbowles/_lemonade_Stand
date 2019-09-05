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

        public void StartCheckOut(Player player)
        {
            GetAmountToBuy();
            GetTotalCost();
            CheckSufficientFunds(player);
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
                else
                {
                    UI.DisplayDidNotPurchase();
                    Console.ReadLine();
                }
            }
            else if (!sufficientFunds)
            {
                UI.DisplayInsufficientFunds();
                Console.ReadLine();
                UI.DisplayDidNotPurchase();
                Console.ReadLine();
            }
        }

        public void CheckOutAtRegister(Player player)
        {
            player.wallet.DecrementMoney(totalCostOfPurchase);
            UI.DisplayTotalMoney(player.wallet);
            Console.ReadLine();
            player.inventory.IncrementInventory(item, amountToPurchase);
            UI.DisplayInventoryContents(player.inventory);
            Console.ReadLine();
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
                        StartCheckOut(player);
                        break;

                    case 2:
                        item = new CupOfSugar();
                        StartCheckOut(player);
                        break;

                    case 3:
                        item = new IceCube();
                        StartCheckOut(player);
                        break;

                    case 4:
                        item = new Cup();
                        StartCheckOut(player);
                        break;

                    case 5:
                        UI.DisplayInventoryContents(player.inventory);
                        Console.ReadLine();
                        break;

                    case 6:
                        UI.DisplayTotalMoney(player.wallet);
                        Console.ReadLine();
                        break;

                    case 7:
                        isShopping = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
