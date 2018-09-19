using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game_Master_2018
{
    class Player
    {
        //public String Name { get; set; }
        public String Color { get; set; }
        public int Playernr { get; set; }
        public Player(string color, int playernr)
        {
            //  Name = name;
            Color = color;
            Playernr = playernr;

        }

    }
}
