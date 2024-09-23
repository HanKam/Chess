using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chess
{
    internal class Game
    {
        ChessBoard _chessBoard;
        MovesHistory _history;
        Colour _playerOnMove;

        public Game()
        {
            NewGame();
        }
        public void NewGame()
        {
            _chessBoard = new ChessBoard();
            _chessBoard.Initializer();

            _history = new MovesHistory();
            _playerOnMove = Colour.White;
        }

        internal void TryToMovePiece(int x1, int y1, int x2, int y2)
        {
            if (_playerOnMove != _chessBoard.GetField(x1, y1).GetColour())
                return;
            if (!IsMovePossible(x1, y1, x2, y2))
                return;

            _history.AddMove(new HistoryRecord(_chessBoard.GetField(x1, y1).ToString()[0],
                                                       new Point(x1, y1),
                                                       new Point(x2, y2)));
            _chessBoard.MovePiece(x1, y1, x2, y2);
            _playerOnMove = _playerOnMove == Colour.Black ? Colour.White : Colour.Black;
        }

        internal bool IsMovePossible(int x1, int y1, int x2, int y2)
        {
           return _chessBoard.IsMovePossible(x1, y1, x2, y2, _history);           
        }

        internal IPiece GetField(int x, int y)
        {
            return _chessBoard.GetField(x, y);
        }

        internal List<Point> GetPossibleMoves(int lastX, int lastY)
        {
            return _chessBoard.GetPossibleMoves(lastX, lastY, _history);
        }
        internal bool IsCheckmate()
        {
            if(!_chessBoard.IsCheck(_playerOnMove, _history)) 
                return false;
            
            return isNoMovePossible();
        }
        internal bool IsStalemate()
        {
            if (_chessBoard.IsCheck(_playerOnMove, _history))
                return false;

            return isNoMovePossible();
        }

        private bool isNoMovePossible()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (_chessBoard.GetField(i, j) == null || _chessBoard.GetField(i, j).GetColour() != _playerOnMove)
                        continue;

                    if (_chessBoard.GetPossibleMoves(i, j, _history).Count() != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
