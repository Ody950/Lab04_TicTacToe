using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using System.Numerics;

namespace ticTacToeTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestToAddAword()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[1, 0] = "O";
            game.Board.GameBoard[2, 0] = "O";

            //assert
            Assert.True(game.CheckForWinner(game.Board));


        }
        [Fact]
        public void TestToSwitchPlayer()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            //assert
            game.SwitchPlayer();
            Assert.True(game.PlayerOne.IsTurn);
            game.SwitchPlayer();
            Assert.True(game.PlayerTwo.IsTurn);

        }
        [Fact]
        public void TestForDraw()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Marker = "O";

            //act
            Game game = new Game(playerOne, playerTwo);

            //assert


        }
    }
}