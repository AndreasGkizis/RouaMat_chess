using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_2.Models
{
    internal class Game
    {
        public Random _random = new Random();
        public bool win { get; set; }
        public Player Winner { get; set; }
        //public int MyProperty { get; set; }

            //if(!exoun paiksei?)

        public Game(Player player1, Player player2)
        {
            player1.numOfGamesPlayed += 1;
            player2.numOfGamesPlayed += 1;

            player1.IHavePlayedWith.Add(player2);
            player2.IHavePlayedWith.Add(player1);

            for (int minutes=0; minutes < 3; minutes++)
            {
                player1.MovesMade+= 1;
                player2.MovesMade+= 1;
                
                //Console.WriteLine(minutes);
            }
            int xazo = _random.Next(0,2);
            if (xazo == 0)
            {
                Winner = player1;
            }else
            {
                Winner= player2;
            }
            
        }

        
    }

}
