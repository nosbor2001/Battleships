using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    static class Globals
    {
        //Boards
        public static int[,] player1Cords = new int[10, 10];
        public static int[,] player2Cords = new int[10, 10];
        public static int player;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //https://en.wikipedia.org/wiki/Battleship_(game)#Description
            //https://boardgames.lovetoknow.com/Battleship_Board_Game
            //List for types of Boats (string(name), int(size))
            //Mark (white x) missiles and hits (red x)
            //Two 2D arrays for both player (10x10)
            //Two Lists for ship location on array
            //Some method of ship detection

            //Type        Pegs      Abbreviation
            //Carrier     5         Carri
            //Battleship  4         Batt
            //Cruiser     3         Cru
            //Submarine   3         Sub
            //Destroyer   2         Dt

            //Boat Locations
            Dictionary<int, int> player1Dict = new Dictionary<int, int>();
            Dictionary<int, int> player2Dict = new Dictionary<int, int>();

            arraySetup(Globals.player1Cords, Globals.player2Cords);
            placingBoard();
            Console.ReadLine();
            placeShips(player1Dict, player2Dict);

            Console.ReadLine();
        }

        static void arraySetup(int[,] player1Cords, int[,] player2Cords)
        {
            player1Cords.Initialize();
            player2Cords.Initialize();
            
        }

        static void placeShips(Dictionary<int, int> player1Dict, Dictionary<int, int> player2Dict)
        {
            bool allPlaced = false;

            Console.WriteLine("Place ships in the 10x10 grid, used coords from 0,0 to 9,9");
            Console.WriteLine("Specify direction by: u, d, l or r corresopnding to each direction");
            Console.WriteLine("You will only have one of each type of boat");

            Console.Clear();
            int choice;
            int placement;
            string orientation;
            Globals.player = 1;

            while (allPlaced == false)
            {
                if (Globals.player == 1)
                    Console.WriteLine("Player 1 will now place their ships, look away player 2");
                else if (Globals.player == 2)
                    Console.WriteLine("Player 2 will now place their ships, look away player 1");
                else
                    Console.WriteLine("Player Error");

                Console.ReadLine();
                placingBoard();
                Console.WriteLine("Choose where to place your: \n(1)Carrier \n(2)Battleship \n(3)Cruiser \n(4)Submarine \n(5)Destroyer");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Carrier selected, 5 pegs");
                        Console.Write("Position (enter like 12 for 1,2): " );
                        placement = int.Parse(Console.ReadLine());
                        Console.Write("Orientation (u, d, l, r): ");
                        orientation = Console.ReadLine();
                        placeShips(choice, placement, orientation, Globals.player1Cords, Globals.player2Cords);
                        break;

                    case 2:
                        Console.WriteLine("Battleship selected, 4 pegs");
                        Console.Write("Position (enter like 12 for 1,2): ");
                        placement = int.Parse(Console.ReadLine());
                        Console.Write("Orientation (u, d, l, r): ");
                        orientation = Console.ReadLine();
                        placeShips(choice, placement, orientation, Globals.player1Cords, Globals.player2Cords);
                        break;

                    case 3:
                        Console.WriteLine("Cruiser selected, 3 pegs");
                        Console.Write("Position (enter like 12 for 1,2): ");
                        placement = int.Parse(Console.ReadLine());
                        Console.Write("Orientation (u, d, l, r): ");
                        orientation = Console.ReadLine();
                        placeShips(choice, placement, orientation, Globals.player1Cords, Globals.player2Cords);
                        break;

                    case 4:
                        Console.WriteLine("Submarine selected, 3 pegs");
                        Console.Write("Position (enter like 12 for 1,2): ");
                        placement = int.Parse(Console.ReadLine());
                        Console.Write("Orientation (u, d, l, r): ");
                        orientation = Console.ReadLine();
                        placeShips(choice, placement, orientation, Globals.player1Cords, Globals.player2Cords);
                        break;

                    case 5:
                        Console.WriteLine("Destroyer selected, 2 pegs");
                        Console.Write("Position (enter like 12 for 1,2): ");
                        placement = int.Parse(Console.ReadLine());
                        Console.Write("Orientation (u, d, l, r): ");
                        orientation = Console.ReadLine();
                        placeShips(choice, placement, orientation, Globals.player1Cords, Globals.player2Cords);
                        break;
                }
            }

        }

        static void drawPly1()
        {
            //Draw board of hits against ply 2
        }

        static void drawPly2()
        {
            //Draw board of hits against ply 1
        }

        static void placingBoard()
        {
            //Draws board
            Console.Write("  ");
            for (int i = 0; i < 10; i++)
                Console.Write(" " + i + " ");
            Console.WriteLine(" ");
            for (int x = 0; x <= 9; x++)
            {
                Console.Write(x + " ");
                for (int y = 0; y <= 9; y++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

        static void placeShips(int c, int p, string o, int[,] player1Cords, int[,] player2Cords)
        {
            switch (c)
            {
                case 1:
                    if(o == "u")
                    {

                    }
                    if (o == "d")
                    {

                    }
                    if (o == "l")
                    {

                    }
                    if (o == "r")
                    {

                    }
                    break;
            }

            Globals.player = 2;
        }
    }
}
