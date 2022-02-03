using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingPool
{
    class Player
    {
        public string Name { get; set; }
        //0
        public bool IsEliminated { get; set; }
        //1
        public bool HasPlayed { get; set; }
        //2
        public bool HasWonBattey { get; set; }


        public Player(string name)
        {
            this.Name = name;
            this.HasPlayed = false;
        }
    }
}
