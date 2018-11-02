using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class Program
    {
        private static TicTacToeGame game;
        static void Main(string[] args)
        {
            game = new TicTacToeGame();
            Console.WriteLine("Welcome to TicTacToe \nPlease enter your names:");
            game.Setup(Console.ReadLine(),Console.ReadLine());

            while (true)
            {
                Console.Clear();
                ShowBoard();
                Console.WriteLine("Play for helvede " + game.CurrentPlayer.Name + "!");
                Console.Write("Row:");
                int row = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                row--;
                Console.Write("Col:");
                int col = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                col--;
                game.PlayPiece(game.CurrentPlayer.Piece, row, col);
                game.SwitchPlayer();
            }
        }

        public static void ShowBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(game.GetBoard()[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private static void TestBoard()
        {
            TicTacToeBoard board = new TicTacToeBoard();
            board.SetPiece('X', 0, 0);
            board.SetPiece('O', 2, 2);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(board.Board[i, j]);
                    Console.WriteLine(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
