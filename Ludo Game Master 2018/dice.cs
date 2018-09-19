using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game_Master_2018
{
    public class Dice
    {

        public static int tal = 0;


        public static void Roll()
        {


            Random dice = new Random();
            tal = dice.Next(1, 7);


        }








    }
}
