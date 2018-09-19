using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game_Master_2018
{


    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int p = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            string f1 = "";
            string f2 = "";
            string f3 = "";
            string f4 = "";



            Console.WriteLine("Welcome to Ludo");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            Console.WriteLine("How many players? (min 2 max 4)  ");

            p = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            // Creating player 1 

            Console.WriteLine("Player 1 choose your color");
            Console.WriteLine("1 = Green");
            Console.WriteLine("2 = Red");
            Console.WriteLine("3 = Blue");
            Console.WriteLine("4 = Yellow");

            p1 = Convert.ToInt32(Console.ReadLine());

            // f1 
            if (p1 == 1)
            {
                f1 = "Green";
            }
            else if (p1 == 2)
            {
                f1 = "Red";
            }
            else if (p1 == 3)
            {
                f1 = "Blue";
            }
            else if (p1 == 4)
            {
                f1 = "yellow";
            }

            Player player1_1 = new Player(f1, 1);
            Player player1_2 = new Player(f1, 1);
            Player player1_3 = new Player(f1, 1);
            Player player1_4 = new Player(f1, 1);

            Console.Clear();

            // Done creating player 1

            // Creating player 2
            
            Console.WriteLine("Player 2 choose your color");
            Console.WriteLine("1 = Green");
            Console.WriteLine("2 = Red");
            Console.WriteLine("3 = Blue");
            Console.WriteLine("4 = Yellow");

            while (n == 0)
            {
                p2 = Convert.ToInt32(Console.ReadLine());
                if (p2 != p1)
                {
                    n = 1;
                }
                if (n == 0)
                {
                    Console.WriteLine("try again");
                }
            }
            n = 0;


            // f2 
            if (p2 == 1)
            {
                f2 = "Green";
            }
            else if (p2 == 2)
            {
                f2 = "Red";
            }
            else if (p2 == 3)
            {
                f2 = "Blue";
            }
            else if (p2 == 4)
            {
                f2 = "yellow";
            }

            Player player2_1 = new Player(f2, 2);
            Player player2_2 = new Player(f2, 2);
            Player player2_3 = new Player(f2, 2);
            Player player2_4 = new Player(f2, 2);


            Console.Clear();

            // Done creating player 2

            // Creating player 3

            if (p >= 3)
            {

                Console.WriteLine("Player 3 choose your color");
                Console.WriteLine("1 = Green");
                Console.WriteLine("2 = Red");
                Console.WriteLine("3 = Blue");
                Console.WriteLine("4 = Yellow");

                while (n == 0)
                {
                    p3 = Convert.ToInt32(Console.ReadLine());
                    if (p3 != p1 && p3 != p2)
                    {
                        n = 1;
                    }
                    if (n == 0)
                    {
                        Console.WriteLine("try again");
                    }
                }
                n = 0;

            
                // f3 
                if (p3 == 1)
                {
                    f3 = "Green";
                }
                else if (p3 == 2)
                {
                    f3 = "Red";
                }
                else if (p3 == 3)
                {
                    f3 = "Blue";
                }
                else if (p3 == 4)
                {
                    f3 = "yellow";
                }

                Player player3_1 = new Player(f3, 3);
                Player player3_2 = new Player(f3, 3);
                Player player3_3 = new Player(f3, 3);
                Player player3_4 = new Player(f3, 3);


                Console.Clear();
            }
            // Done creating player 3

            // Creating player 4

            if (p >= 4)
            {

                Console.WriteLine("Player 4 choose your color");
                Console.WriteLine("1 = Green");
                Console.WriteLine("2 = Red");
                Console.WriteLine("3 = Blue");
                Console.WriteLine("4 = Yellow");

                while (n == 0)
                {
                    p4 = Convert.ToInt32(Console.ReadLine());
                    if (p4 != p1 && p4 != p2 && p4 != p3)
                    {
                        n = 1;
                    }
                    if (n == 0)
                    {
                        Console.WriteLine("try again");
                    }


                    // f4 
                    if (p4 == 1)
                    {
                        f4 = "Green";
                    }
                    else if (p4 == 2)
                    {
                        f4 = "Red";
                    }
                    else if (p4 == 3)
                    {
                        f4 = "Blue";
                    }
                    else if (p4 == 4)
                    {
                        f4 = "yellow";
                    }

                    Player player4_1 = new Player(f4, 4);
                    Player player4_2 = new Player(f4, 4);
                    Player player4_3 = new Player(f4, 4);
                    Player player4_4 = new Player(f4, 4);


                    Console.Clear();
                }
                n = 0;

                // Done creating player 4
            }


            Console.WriteLine("Player 1 as " + f1);
            Console.WriteLine("Player 2 as " + f2);

            if (p >= 3)
            {
                Console.WriteLine("Player 3 as " + f3);
            }

            if (p >= 4)
            {
                Console.WriteLine("Player 4 as " + f4);
            }

            // THE GAME 

            Console.WriteLine("Press any key to Confirm ");
            Console.ReadKey();
            Console.Clear();



            Bord.Draw();

           
        }
    }
}
