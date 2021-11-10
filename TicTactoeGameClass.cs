using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTactoeGameClass
    {
        public char[] NewBoard()
        {
            char[] board = new char[10];
            for(int i=1;i<board.Length;i++)
            {
                board[i] = ' ';
            }
            return board;
        }

        public void ChooseLetter()
        {
            Console.WriteLine("\nPlayer: Enter The letter");
            char playerLetter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nPlayer Letter is" + playerLetter);

            char computerLetter='O';
            Console.WriteLine("\nComputer Letter is" + computerLetter);
           

        }
    }
}
