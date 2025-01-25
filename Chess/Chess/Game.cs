using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using static Chess.HistoryRecord;

namespace Chess
{
    internal class Game
    {
        private ChessBoard _chessBoard;
        private MovesHistory _history;
        private Colour _playerOnMove;
        private PlayerColour _playerColour;
        private Stopwatch _playerTimer;
        private Stopwatch _opponentTimer;
        private int _basePlayerTimeMove;
        private int _baseOpponentTimeMove;
        private int _timeAdd;
        private Dictionary<string, int> _positions;

        public enum PlayerColour
        {
            White, Black, Both
        }

        public enum GameResult
        {
            Draw, Win, Lost, None
        }

        public Game(int timeMove, int timeAdd, PlayerColour playerColour)
        {
            _basePlayerTimeMove = timeMove;
            _baseOpponentTimeMove = timeMove;
            _timeAdd = timeAdd;
            NewGame(playerColour);
        }
        public void NewGame(PlayerColour playerColour)
        {
            _chessBoard = new ChessBoard();
            _chessBoard.Initializer();

            _history = new MovesHistory();
            _playerOnMove = Colour.White;
            _playerColour = playerColour;
            
            _playerTimer = new Stopwatch();
            _opponentTimer = new Stopwatch();

            _positions = new Dictionary<string, int>();
            _positions.TryAdd(_chessBoard.ToString(), 1);
            if (playerColour == PlayerColour.White || playerColour == PlayerColour.Both)
            {
                _playerTimer.Start();
            }
            else
            {
                _opponentTimer.Start();
            }
        }

        public PlayerColour GetPlayerColour()
        {
            return _playerColour;
        }
        public MovesHistory GetMovesHistory()
        {
            return _history;
        }

        public Colour GetPlayerOnMoveColour()
        {
            return _playerOnMove;
        }

        public int GetPlayerRemainingTime()
        {
            return int.Max(_basePlayerTimeMove - (int)_playerTimer.Elapsed.TotalSeconds, 0);
        }

        public int GetOpponentRemainingTime()
        {
            return int.Max(_baseOpponentTimeMove - (int)_opponentTimer.Elapsed.TotalSeconds, 0);
        }

        internal bool TryToMovePieceNetwork(int x1, int y1, int x2, int y2, IPiece piece)
        {
            if (PlayerCompatible())
                return false;
            
            bool success = TryToMovePiece(x1, y1, x2, y2);
            
            if (!success)
                return false;

            string currentPiece = _chessBoard.GetField(x2, y2).ToString();
            if (currentPiece != piece.ToString())
            {
                _history.GetLastMove().MarkPromotion(piece.ToString()[0]);
                _chessBoard.SetField(x2, y2, piece);
            }

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

            bool capture = _chessBoard.GetField(x2, y2) != null;

            _chessBoard.MovePiece(x1, y1, x2, y2);
            SwitchPlayer();

            char piece = _chessBoard.GetField(x2, y2).ToString()[0];
            bool check = _chessBoard.IsCheck(_playerOnMove, _history);
            bool mate = this.IsCheckmate();

            MoveType moveType = MoveType.Normal;
            if (mate)
            {
                moveType = MoveType.Mate;
            }
            else if (check)
            {
                moveType = MoveType.Check;
            }

            _history.AddMove(new HistoryRecord(piece, new Point(x1, y1), new Point(x2, y2), moveType, capture));
            UpdatePositions();
            return true;
        }

        private void UpdatePositions()
        {
            string currentPosStr = _chessBoard.ToString();

            if (_positions.ContainsKey(currentPosStr))
            {
                _positions[currentPosStr]++;
            }
            else
            {
                _positions.TryAdd(currentPosStr, 1);
            }
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
                _history.GetLastMove().MarkPromotion(piece.ToString()[0]);
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

        internal void SwitchPlayer()
        {
            _playerOnMove = _playerOnMove == Colour.Black ? Colour.White : Colour.Black;

            // White player's timer is at the bottom
            if (_playerColour == PlayerColour.Both)
            {
                if (_playerOnMove == Colour.White)
                {
                    SwitchToPlayerTimer();
                }
                else
                {
                    SwitchToOpponentTimer();
                }

                return;
            }
            if (PlayerCompatible())
            {
                SwitchToPlayerTimer();
            }
            else
            {
                SwitchToOpponentTimer();
            }
        }

        internal void SwitchToPlayerTimer()
        {
            _opponentTimer.Stop();
            _playerTimer.Start();

            if (_opponentTimer.Elapsed.TotalMilliseconds < _baseOpponentTimeMove * 1000)
            {
                _baseOpponentTimeMove += _timeAdd;
            }
        }

        internal void SwitchToOpponentTimer()
        {
            _playerTimer.Stop();
            _opponentTimer.Start();

            if (_playerTimer.Elapsed.TotalMilliseconds < _basePlayerTimeMove * 1000)
            {
                _basePlayerTimeMove += _timeAdd;
            }
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
        internal KeyValuePair<GameResult, string> IsEndGame()
        {
            bool whiteUnsufficientMaterial = ChessBoardHelper.IsThereInsufficientMaterial(_chessBoard, Colour.White);
            bool blackUnsufficientMaterial = ChessBoardHelper.IsThereInsufficientMaterial(_chessBoard, Colour.Black);

            if (GetPlayerRemainingTime() <= 0)
            {
                // player - white
                if (_playerColour == PlayerColour.White || _playerColour == PlayerColour.Both)
                {
                    if (blackUnsufficientMaterial)
                    {
                        return new KeyValuePair<GameResult, string>(GameResult.Draw, "Białym skończył się czas, a czarne mają niewystarczającą ilość materiału - mamy remis.");
                    }

                    return new KeyValuePair<GameResult, string>(GameResult.Lost, "Białym skończył się czas - wygrały czarne.");
                }
                // player - black
                else
                {
                    if (whiteUnsufficientMaterial)
                    {
                        return new KeyValuePair<GameResult, string>(GameResult.Draw, "Czarnym skończył się czas, a białe mają niewystarczającą ilość materiału - mamy remis.");
                    }

                    return new KeyValuePair<GameResult, string>(GameResult.Lost, "Czarnym skończył się czas - wygrały białe.");
                }
            }

            if (GetOpponentRemainingTime() <= 0)
            {
                // player - white
                if (_playerColour == PlayerColour.White || _playerColour == PlayerColour.Both)
                {
                    if (whiteUnsufficientMaterial)
                    {
                        return new KeyValuePair<GameResult, string>(GameResult.Draw, "Czarnym skończył się czas, a białe mają niewystarczającą ilość materiału - mamy remis.");
                    }

                    return new KeyValuePair<GameResult, string>(GameResult.Win, "Czarnym skończył się czas - wygrały białe.");
                }
                // player - black
                else
                {
                    if (blackUnsufficientMaterial)
                    {
                        return new KeyValuePair<GameResult, string>(GameResult.Draw, "Białym skończył się czas, a czarne mają niewystarczającą ilość materiału - mamy remis.");
                    }

                    return new KeyValuePair<GameResult, string>(GameResult.Win, "Białym skończył się czas - wygrały czarne.");
                }
            }

            if (IsCheckmate())
            {
                //Singleplayer
                if(_playerColour == PlayerColour.Both)
                    return new KeyValuePair<GameResult, string>(GameResult.Win, "Szach-mat - wygrały " + (_playerOnMove == Colour.White ? "czarne." : "białe."));
                if(_playerColour == PlayerColour.White)
                {
                    if(_playerOnMove == Colour.White)
                        return new KeyValuePair<GameResult, string>(GameResult.Lost, "Szach-mat - wygrały czarne.");
                    return new KeyValuePair<GameResult, string>(GameResult.Win, "Szach-mat - wygrały białe.");
                }
                if(_playerOnMove == Colour.White)
                    return new KeyValuePair<GameResult, string>(GameResult.Win, "Szach-mat - wygrały czarne.");
                return new KeyValuePair<GameResult, string>(GameResult.Lost, "Szach-mat - wygrały białe.");
            }

            if (IsStalemate())
            {
                return new KeyValuePair<GameResult, string>(GameResult.Draw, "Pat - mamy remis.");
            }

            if (whiteUnsufficientMaterial && blackUnsufficientMaterial)
            {
                return new KeyValuePair<GameResult, string>(GameResult.Draw, "Niewystarczająca ilość materiału - mamy remis.");
            }

            if (_history.Is50MovesRule())
            {
                return new KeyValuePair<GameResult, string>(GameResult.Draw, "Wykonano pięćdziesiąt ruchów bez ruchu piona i zbicia - mamy remis.");
            }

            foreach (var position in _positions)
            {
                if (position.Value >= 3)
                {
                    return new KeyValuePair<GameResult, string>(GameResult.Draw, "Ta sama pozycja powtórzyła się trzy razy - mamy remis.");
                }
            }

            return new KeyValuePair<GameResult, string>(GameResult.None, string.Empty);
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
