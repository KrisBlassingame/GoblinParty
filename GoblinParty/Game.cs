using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoblinParty
{
    class Game
    {
        Player player = new Player();


        public void StartGame()
        {
            Console.WriteLine("Welcome. Press enter to continue.");
            enterPrompt();
            Console.Write("Please enter your name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine(player.Name + " is your name. Is that correct? (y/n)");
            Console.ReadLine();
            Console.WriteLine("Well, " + player.Name + ", looks like you have " + player.HP + "HP, and " + player.VP + "VP.");
            Console.ReadLine();
        }

        public void enterPrompt()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

        }
    }
}
