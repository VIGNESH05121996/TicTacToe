using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic Tac Toe");
            TicTactoeGameClass game = new TicTactoeGameClass();
            game.NewBoard();
            game.ChooseLetter();
        }
    }
}
