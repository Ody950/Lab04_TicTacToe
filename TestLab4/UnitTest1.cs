using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]

        public void test_for_winners()
        {

            Player p1 = new Player();
            p1.Name = "Odai";
            p1.Marker = "X";
            Player p2 = new Player();
            p2.Name = "Ali";
            p2.Marker = "O";

            Game TestGame = new Game(p1, p2);

            TestGame.Board.GameBoard[0, 0] = p1.Marker;
            TestGame.Board.GameBoard[0, 1] = p1.Marker;
            TestGame.Board.GameBoard[0, 2] = p1.Marker;

            bool TheWinner = TestGame.CheckForWinner(TestGame.Board);

            Assert.True(TheWinner);
        }


        [Fact]
        public void switch_players()
        {
            Player p1_a = new Player();
            p1_a.Name = "Odai";
            p1_a.Marker = "X";
            p1_a.IsTurn = true;
            Player p2_a = new Player();
            p2_a.Name = "Ali";
            p2_a.Marker = "O";
            p2_a.IsTurn = false;

            Game TestGame2 = new Game(p1_a, p2_a);

            TestGame2.SwitchPlayer();

            Assert.True(p2_a.IsTurn);
        }


        [Fact]
        public void correct_index() 
        {

            Player p1_b = new Player();
            p1_b.Name = "Odai";
            p1_b.Marker = "X";
          
            Player p2_b = new Player();
            p2_b.Name = "Ali";
            p2_b.Marker = "O";

            Game TestGame3 = new Game(p1_b, p2_b);

            int x = 1;
            Position position = Player.PositionForNumber(x);

            Assert.True(position.Row == 0 && position.Column == 0);


        }


        [Fact]

        public void TestNextPlayer()
        {
            Player p1_c = new Player();
            p1_c.Name = "Odai";
            p1_c.Marker = "X";
            p1_c.IsTurn = true;
            Player p2_c = new Player();
            p2_c.Name = "Ali";
            p2_c.Marker = "O";
            p2_c.IsTurn = false;

            Game TestGame4 = new Game(p1_c, p2_c);

            Player theNext = TestGame4.NextPlayer();
            Assert.Equal(theNext.IsTurn, p1_c.IsTurn);


        }








    }
}
