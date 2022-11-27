using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_2.Models
{
    internal class Tournament
    {
        private Random _random = new Random();
        public List<Player> Players { get; set; }
        public Player MyProperty { get; set; }
        public List<Player> Winners { get; set; }

        public Tournament(List<Player> list)
        {
            if (list.Count < 4)
            {
                Console.WriteLine("Not enough");
            }
            else
            {
                bool run = true;
                while (run)
                {
                    Player player1 = list[_random.Next(0, list.Count)];
                    Player player2 = list[_random.Next(0, list.Count)];
                    if (player1.numOfGamesPlayed < 3 && player2.numOfGamesPlayed < 3)
                    {
                        if (player1.IHavePlayedWith.Count == 0 || player2.IHavePlayedWith.Count == 0)
                        {
                            Console.WriteLine(  "mphkan parthenoi");
                            Game newGame = new Game(player1, player2);
                            Console.WriteLine(player2);
                            Console.WriteLine(player1);
                            Winners.Add(newGame.Winner);

                        }
                        else if (!player1.IHavePlayedWith.Contains(player2) && player1 != player2)
                            {
                            Console.WriteLine("mphkan oxi parthenoi");
                            Game newGame = new Game(player1, player2);
                            Console.WriteLine(player2);
                            Console.WriteLine(player1);
                            Winners.Add(newGame.Winner);

                        }

                        //if (!player1.IHavePlayedWith.Contains(player2) && player1!=player2)
                        //{
                        //    Game newGame = new Game(player1, player2);
                        //        Console.WriteLine(player2);
                        //        Console.WriteLine(player1);
                        //}
                    }

                }
                
                //while (i < list.Count)
                //{
                //    Console.WriteLine(i);
                //    player1 = list[i];
                //    player2 = list[i + 1];
                //    while (!player1.IHavePlayedWith.Contains(player2) && player1.numOfGamesPlayed <3 && player2.numOfGamesPlayed<3)
                //    {
                //        Game newGame = new Game(player1, player2);
                //    }
                //    i += 2;
                //}
                //Console.WriteLine(player1);
                //Console.WriteLine(player2);

            }
            // kati kanw
        }
    }
}
