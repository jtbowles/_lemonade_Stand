using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (game.isOn)
            {
                UI.DisplayPlayerMenu();
                int userInput = Convert.ToInt32(Console.ReadLine());

                game.RunGame(userInput);
            }
        }
    }
}
