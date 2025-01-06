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
        PlayerColour _playerColour;

        public enum PlayerColour
        {
            White, Black, Both
        }

        public Game(PlayerColour playerColour)
        {
            NewGame(playerColour);
        }
        public void NewGame(PlayerColour playerColour)
        {
            _chessBoard = new ChessBoard();
            _chessBoard.Initializer();

            _history = new MovesHistory();
            _playerOnMove = Colour.White;
            _playerColour = playerColour;

            Console.WriteLine("Game " + _playerColour.ToString() + _playerOnMove.ToString());
        }

        public PlayerColour getPlayerColour()
        {
            return _playerColour;
        }

        internal bool TryToMovePieceNetwork(int x1, int y1, int x2, int y2, IPiece piece)
        {
            if (PlayerCompatible())
                return false;
            
            bool success = TryToMovePiece(x1, y1, x2, y2);
            
            if (!success)
                return false;

            _chessBoard.SetField(x2, y2, piece);
            return true;
        }
        internal bool TryToMovePieceGUI(int x1, int y1, int x2, int y2)
        {
            if (!PlayerCompatible())
                return false;
            return TryToMovePiece(x1,y1,x2,y2);
        }

        private bool TryToMovePiece(int x1, int y1, int x2, int y2)
        {
            if (_playerOnMove != _chessBoard.GetField(x1, y1).GetColour())
                return false;
            if (!IsMovePossible(x1, y1, x2, y2))
                return false;

            _history.AddMove(new HistoryRecord(_chessBoard.GetField(x1, y1).ToString()[0],
                                                       new Point(x1, y1),
                                                       new Point(x2, y2)));
            _chessBoard.MovePiece(x1, y1, x2, y2);
            _playerOnMove = _playerOnMove == Colour.Black ? Colour.White : Colour.Black;
            return true;
        }

        internal bool IsMovePossible(int x1, int y1, int x2, int y2)
        {
           return _chessBoard.IsMovePossible(x1, y1, x2, y2, _history);           
        }

        internal bool TryToPromotePawnGUI(int x1, int y1, int x2, int y2, IPiece piece)
        {
            if (!PlayerCompatible())
                return false;
            bool success = TryToMovePiece(x1, y1, x2, y2);
            if (success)
            {
                _chessBoard.SetField(x2, y2, piece);
            }
            return success;
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

        internal bool PlayerCompatible() 
        { 
            if(_playerColour == PlayerColour.Both) 
                return true;
            if(_playerColour == PlayerColour.White)
                return _playerOnMove == Colour.White;
            return _playerOnMove == Colour.Black;
        }
        internal Colour GetColourOnMove()
        {
            return _playerOnMove;
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
