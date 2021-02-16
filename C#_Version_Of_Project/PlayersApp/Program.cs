
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersApp
{

    class Program
    {
        private static List<Player> players = new List<Player>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("The Player Management Program");
                Console.WriteLine("What would you like to do?\n- Create a Player(1)\n- Edit a Player(2)\n- Remove a Player(3)\n- View Players(4)");
                string userInput = Console.ReadLine();
                if (userInput.Equals("1"))
                {
                    Player.CreatePlayer(players);
                    
                }
                if (userInput.Equals("2"))
                {
                    Player.EditPlayer(players);
                }
                if (userInput.Equals("3"))
                {
                    Player.RemovePlayer(players);
                }
                if (userInput.Equals("4"))
                {
                    Player.ViewPlayers(players);
                }
            }
        }
    }
}
