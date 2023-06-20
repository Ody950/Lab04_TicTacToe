using Lab04_TicTacToe.Classes;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Transactions;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 


            /// <summary>
            /// To lite the players enter their name and select marke for them
            /// </summary>
            /// 
            Console.WriteLine("Enter the first player name");
            Player p1 = new Player();
            p1.Name = Console.ReadLine();
            p1.Marker = "X";

            Console.WriteLine("Enter the second player name");
            Player p2 = new Player();
            p2.Name = Console.ReadLine();
            p2.Marker = "O";


            /// <summary>
            /// To show the wener or draw at the end
            /// </summary>
            /// 

            Game match = new Game(p1, p2);

           Player winner = match.Play();

            if (winner != null)
            {
                    Console.WriteLine($"{winner.Name} wins");
            }
            else
             {
                    Console.WriteLine("There is no winner");
             }
            


        }
           

    }
}
