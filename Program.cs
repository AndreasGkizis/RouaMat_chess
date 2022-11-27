using Recap_3_2.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we need to create a chess tu=ournament 
            // this chess tournament has the following ruls 
            // 1. we dont know how many players will apply 
            // 2. each player needs to play 3 games
            // 3. the games last for 3 minutes
            // the application need to randomly create games for each player with a deferent oponnent 
            //every time! each player plays a move .
            // when 3 minutes expire, the game must declare a winner ( randomly )
            //when all games finish we need to show winners 
            //foreach winner gets 3 points for each win 

            // create a chilndres tourney lke above expect the games they need to play is oonly one per.

            // classes 
            // tournament(num of players, kids?)
            //      method = check if they are enough 

            // Players |
            //      props ->  int numberofgames , int numofwins, int points, int id
            //      methods = win/lose 
            // Game |-> props 
            //      
            // 
            List<Player> PlayerList = new List<Player>();
            for (int i=0 ; i<6; i++)
            {
                PlayerList.Add(new Player(i));
            }
            PlayerList.ForEach(Console.WriteLine);
            Tournament newTour = new Tournament(PlayerList);
            Console.WriteLine("skata");
            Console.WriteLine(PlayerList[0].numOfGamesPlayed);
            //foreach (Player player in PlayerList)
            //{
            //    Console.WriteLine("result");
            //    Console.WriteLine(player.numOfGamesPlayed); 
            //}
        }
    }
}
