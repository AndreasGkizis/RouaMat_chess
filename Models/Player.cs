using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_2.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> IHavePlayedWith { get; set; }
        public int numOfGamesPlayed { get; set; }
        public int MovesMade { get; set; }
        public int Points { get; set; }
        public Player(int id)
        {
            Id = id;
            IHavePlayedWith= new List<Player>();
        }

        public override string ToString() { 
            return $"Id is : {Id} numberofgamesplayed {numOfGamesPlayed}";
        }
    }
}
