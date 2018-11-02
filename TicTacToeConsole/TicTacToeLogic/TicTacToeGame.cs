using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    class TicTacToeGame
    {
        private TicTacToeBoard _board = new TicTacToeBoard();
        private Player _player1 = new Player();
        private Player _player2 = new Player();

        private Random _random = new Random();
        private Player _currentPlayer;

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
        }

        public void Setup(string player1name, string player2name)
        {
            SetPlayerName(player1name, player2name);
            RandomBeginner();
        }

        public Boolean PlayPiece(char c, int row, int col)
        {
            return _board.SetPiece(c, row, col);
        }

        public char[,] GetBoard()
        {
            return _board.Board;
        }

        public void SwitchPlayer()
        {
            if (CurrentPlayer.Equals(_player1)) _currentPlayer = _player2;
            else _currentPlayer = _player1;
        }

        private void RandomBeginner()
        {
            if (_random.NextDouble() < 0.5)
            {
                _currentPlayer = _player1;
                _player1.Piece = _board.Pieces[0];
                _player2.Piece = _board.Pieces[1];
            }
            else
            {
                _currentPlayer = _player2;
                _player2.Piece = _board.Pieces[0];
                _player1.Piece = _board.Pieces[1];
            }
        }
        private void SetPlayerName(string playerName1, string playerName2)
        {
            _player1.Name = playerName1;
            _player2.Name = playerName2;
        }
    }
}
