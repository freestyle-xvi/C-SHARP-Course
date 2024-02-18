using System;
using System.Collections.Generic;

namespace project_xli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Phoenix"));
            players.Add(new Player("Freestyle"));
            players.Add(new Player("Takumi-Fujiwara"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }



            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
