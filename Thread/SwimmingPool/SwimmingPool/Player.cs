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
        public bool HasPlayed { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
