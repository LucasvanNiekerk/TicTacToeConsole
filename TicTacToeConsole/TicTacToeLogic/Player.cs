using System;

namespace TicTacToeConsole
{
    public class Player
    {
        private string _name;
        private int _gameWon;
        private char _piece;

        public Player(string name)
        {
            Name = name;
        }
        public Player()
        {

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int GameWon
        {
            get { return _gameWon; }
            set { _gameWon = value; }
        }
        public char Piece
        {
            get { return _piece; }
            set { _piece = value; }
        }
    }
}