using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game_Master_2018
{
    class Bord
    {

        public static void Draw()
        {


            string[][] Bord =
                {
                //           0      1     2     3    4      5    6     7     8      9   10    11    12    13    14
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " },//0
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "R0", "  ", "  ", "  ", "  ", "  ", "  " },//1
            new string[]  { "  ", "  ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "  ", "  " },//2
            new string[]  { "  ", "  ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "  ", "  " },//3
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " },//4
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " },//5
            new string[]  { "0 ", "G0", "0 ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 " },//6
            new string[]  { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "0 ", "0 ", "0 " },//7
            new string[]  { "0 ", "0 ", "0 ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "0 ", "B0", "0 " },//8
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " },//9
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " },//10
            new string[]  { "  ", "  ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "  ", "  " },//11
            new string[]  { "  ", "  ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "0 ", "0 ", "  ", "  " },//12
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "Y0", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " },//13
            new string[]  { "  ", "  ", "  ", "  ", "  ", "  ", "0 ", "0 ", "0 ", "  ", "  ", "  ", "  ", "  ", "  " } //14
                 //          0     1     2     3     4     5     6     7     8     9    10    11    12    13    14
        };
            //    Console.WriteLine(moveRED[8]); 

            for (int i = 0; i < Bord.Length; i++)
            {
                for (int j = 0; j < 15; j++)
                {


                    Console.Write(Bord[i][j]);
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Red;


            Console.ForegroundColor = ConsoleColor.Gray;
            // flyt røde brikker             
            string[] moveRED = { Bord[1][8], Bord[2][8], Bord[3][8], Bord[4][8], Bord[5][8], Bord[6][9], Bord[6][10], Bord[6][11], Bord[6][12], Bord[6][13], Bord[6][14], Bord[7][14], Bord[8][14], Bord[8][13], Bord[8][12], Bord[8][11], Bord[8][10], Bord[8][9], Bord[9][8], Bord[10][8], Bord[11][8], Bord[12][8], Bord[13][8], Bord[14][8], Bord[14][7], Bord[14][6], Bord[13][6], Bord[12][6], Bord[11][6], Bord[10][6], Bord[9][6], Bord[8][5], Bord[8][4], Bord[8][3], Bord[8][2], Bord[8][1], Bord[8][0], Bord[7][0], Bord[6][0], Bord[6][1], Bord[6][2], Bord[6][3], Bord[6][4], Bord[6][5], Bord[5][6], Bord[4][6], Bord[3][6], Bord[2][6], Bord[1][6], Bord[0][6], Bord[0][7], Bord[1][7], Bord[2][7], Bord[3][7], Bord[4][7], Bord[5][7] };







        }


    }
}
