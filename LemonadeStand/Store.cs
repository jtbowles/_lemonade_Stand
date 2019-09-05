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
        public Item item;
        public int amountToPurchase;

        public Store()
        {
            isShopping = false;
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
                        UI.GetAmountToBuy(item);
                        amountToPurchase = Convert.ToInt32(Console.ReadLine());
                        UI.CheckAmountToBuy(item, amountToPurchase);
                        player.inventory.IncrementInventory(item, amountToPurchase);
                        // purchase lemons
                        break;

                    case 2:
                        // purchase sugar
                        break;

                    case 3:
                        // purchase ice
                        break;

                    case 4:
                        // purchase cups
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
            }
        }
    }
}
