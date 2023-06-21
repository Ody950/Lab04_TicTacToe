using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            // need a name, marker and whos turn it is to start the game, same for player one and two
            //Intantiating a new GAme to be played 
            Console.WriteLine("Hello World!");
            Player player1 = new Player();
            player1.Name = "Regan";
            player1.Marker = "O";
            player1.IsTurn = true;

            Player player2 = new Player();
            player2.Name = "Lawurence";
            player2.Marker = "X";
            player2.IsTurn = false;

            Game newGame = new Game(player1,player2);
            newGame.Play();
            

            Console.ReadKey();
        
        
        }
    }
}
