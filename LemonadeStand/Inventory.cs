using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<CupOfSugar> cupsOfSugar;
        public List<IceCube> iceCubes;

        public Inventory()
        {
            lemons = new List<Lemon>();
            cups = new List<Cup>();
            cupsOfSugar = new List<CupOfSugar>();
            iceCubes = new List<IceCube>();
        }

        public bool InventoryCheck()
        {
            if (lemons.Count > 0 && cups.Count > 0 && cupsOfSugar.Count > 0 && iceCubes.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool CheckPitcherRequirements(Pitcher pitcher)
        {
            if (lemons.Count >= pitcher.lemonsRequired && cupsOfSugar.Count >= pitcher.cupsOfSugarRequired && iceCubes.Count >= pitcher.iceCubesRequired && cups.Count >= pitcher.cupsPerPitcher)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DecrementInventory(Item itemUsedInRecipe, int amountToDecrement)
        {
            string itemName = itemUsedInRecipe.name;

            switch (itemName)
            {
                case "lemon":
                    for (int i = 0; i < amountToDecrement; i++)
                    {
                        Lemon lemon = new Lemon();
                        lemons.Remove(lemon);
                    }
                    break;

                case "cup of sugar":
                    for (int i = 0; i < amountToDecrement; i++)
                    {
                        CupOfSugar sugar = new CupOfSugar();
                        cupsOfSugar.Remove(sugar);
                    }
                    break;

                case "pack of ice cubes":
                    for (int i = 0; i < amountToDecrement; i++)
                    {
                        IceCube ice = new IceCube();
                        iceCubes.Remove(ice);
                    }
                    break;

                case "cup":
                    for (int i = 0; i < amountToDecrement; i++)
                    {
                        Cup cup = new Cup();
                        cups.Remove(cup);
                    }
                    break;

                default:
                    break;
            }

        }

        public void IncrementInventory(Item purchaseItem, int amountToIncrement)
        {
            string itemName = purchaseItem.name;

            switch (itemName)
            {
                case "lemon":
                    for (int i = 0; i < amountToIncrement; i++)
                    {
                        Lemon lemon = new Lemon();
                        lemons.Add(lemon);
                    }
                    break;

                case "cup of sugar":
                    for (int i = 0; i < amountToIncrement; i++)
                    {
                        CupOfSugar sugar = new CupOfSugar();
                        cupsOfSugar.Add(sugar);
                    }
                    break;

                case "pack of ice cubes":
                    for (int i = 0; i < amountToIncrement; i++)
                    {
                        IceCube ice = new IceCube();
                        iceCubes.Add(ice);
                    }
                    break;

                case "cup":
                    for (int i = 0; i < amountToIncrement; i++)
                    {
                        Cup cup = new Cup();
                        cups.Add(cup);
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
