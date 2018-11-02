using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class TicTacToeBoard
    {
        private const int _boardSize = 3;  //Den er konstant i runtime, man kan ikke ændre den mens programmet kører
        private char[,] _board = new char[_boardSize, _boardSize];   // Vi skal lave const fordi ellers "eksistere" den ikke inden programmet kører?
        private char[] _pieces = {'X', 'O'};

        public char[,] Board
        {
            get { return _board; }
        }

        public Boolean SetPiece(char c, int row, int col)
        {
            if (ValidInput(c, row, col))
            {
                _board[row, col] = c;
                return true;
            }
            else return false;
        }

        private Boolean ValidInput(char c, int row, int col)
        {
            //if (c == _pieces[0] && c == _pieces[1])
            if (_pieces.Contains(c))
            {
                if (row <= _boardSize - 1 && row >= 0)
                {
                    if (col <= _boardSize - 1 && col >= 0) return true;
                }
            }
            return false;
        }
    }
}
