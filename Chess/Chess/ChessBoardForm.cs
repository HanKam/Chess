﻿using Chess.Pieces;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using static Chess.Game;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Timer = System.Windows.Forms.Timer;

namespace Chess
{
    public partial class ChessBoardForm : Form
    {

        private Panel[,] _chessBoardPanels;
        private const int _tileSize = 50;
        private Point? _lastClickedTile;
        private Point? _promoteTo;
        private Game _game;
        private MoveNetworkManager _moveNetworkManager;
        private WaitForConnectionForm _parentForm;
        private ConnectionType _connectionType;
        private Timer _showPlayersTime;

        public enum ConnectionType
        {
            Host, Client
        }

        public ChessBoardForm(ConnectionType connectionType, Colour colour, int timeMove, int timeAdd, string roomName, WaitForConnectionForm parentForm = null, IPAddress ipAddress = null)
        {
            InitializeComponent();

            _moveNetworkManager = new MoveNetworkManager(6942, ReceiveData);
            _connectionType = connectionType;

            roomNameLabel.Text = roomName;

            if (_connectionType == ConnectionType.Host)
            {
                _parentForm = parentForm;
                _game = new Game(timeMove, timeAdd, colour == Colour.White ? Game.PlayerColour.White : Game.PlayerColour.Black);
                _moveNetworkManager.WaitForConnection();
            }
            else
            {
                _game = new Game(timeMove, timeAdd, colour == Colour.White ? Game.PlayerColour.White : Game.PlayerColour.Black);
                _moveNetworkManager.Connect(ipAddress.ToString(), 6942);
            }

            _showPlayersTime = new Timer();
            _showPlayersTime.Tick += new EventHandler(OnTimerTick);
            _showPlayersTime.Interval = 10;

            _showPlayersTime.Start();
        }

        public ChessBoardForm(int timeMove, int timeAdd)
        {
            InitializeComponent();

            roomNameLabel.Text = "Gra lokalna";

            _game = new Game(timeMove, timeAdd, Game.PlayerColour.Both);
            btnDraw.Visible = false;
            btnGiveUp.Text = "Przerwij grę";

            _showPlayersTime = new Timer();
            _showPlayersTime.Tick += new EventHandler(OnTimerTick);
            _showPlayersTime.Interval = 10;

            _showPlayersTime.Start();
        }

        private void ChessBoardForm_Load(object sender, EventArgs e)
        {
            _chessBoardPanels = new Panel[8, 8];
            _lastClickedTile = null;

            this.DrawBoard();
            this.DrawPromotionPanel();
        }

        private void DrawBoard()
        {
            Color colour1 = Color.SaddleBrown;
            Color colour2 = Color.SandyBrown;

            int offsetX = (this.boardPanel.Width - _tileSize * 8) / 2;
            int offsetY = (this.boardPanel.Height - _tileSize * 8) / 2;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    int visibleY = (_game.GetPlayerColour() == Game.PlayerColour.Black) ? y : 7 - y;

                    // creating tiles 
                    Panel boardTile = new Panel
                    {
                        Size = new Size(_tileSize, _tileSize),
                        Location = new Point(_tileSize * x + offsetX, _tileSize * visibleY + offsetY),
                        BorderStyle = BorderStyle.FixedSingle,
                        Anchor = AnchorStyles.None

                    };

                    // creating lambda function to call TileClick with specific x, y 
                    int xCopy = x;
                    int yCopy = y;
                    boardTile.Click += (sender, eventArgs) => TileClick(sender, eventArgs, xCopy, yCopy);
                    boardPanel.Controls.Add(boardTile);
                    _chessBoardPanels[x, y] = boardTile;
                }
            }

            Controls.Add(boardPanel);
            boardPanel.BringToFront();

            UpdateBoard();
        }
        private void UpdateBoard()
        {
            Color colour1 = Color.SaddleBrown;
            Color colour2 = Color.SandyBrown;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Panel currentPanel = _chessBoardPanels[x, y];

                    // drawing pieces
                    IPiece piece = _game.GetField(x, y);
                    if (piece != null)
                    {
                        currentPanel.BackgroundImage = TextureHandler.GetPieceTexture(piece.ToString(), piece.GetColour());
                    }
                    else
                    {
                        currentPanel.BackgroundImage = null;
                    }

                    // colouring
                    if ((x + y) % 2 == 0)
                        currentPanel.BackColor = colour1;
                    else currentPanel.BackColor = colour2;
                }
            }

            UpdateHistoryLabel();
            UpdatePlayerOnMoveLabel();
            ColourPossibleMoves();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            int playerTime = _game.GetPlayerRemainingTime();
            TimeSpan time = TimeSpan.FromSeconds(playerTime);
            timerPlLabel.Text = time.ToString(@"mm\:ss");

            int opponentTime = _game.GetOpponentRemainingTime();
            time = TimeSpan.FromSeconds(opponentTime);
            timerOpLabel.Text = time.ToString(@"mm\:ss");

            EndGameMaybe();
        }

        private void UpdateHistoryLabel()
        {
            MovesHistory movesHistory = _game.GetMovesHistory();
            string history = movesHistory.ToString();

            string[] splitHistory = history.Split("\n"); 

            historyText.Items.Clear();

            foreach (string part in splitHistory)
            {                
                historyText.Items.Add(part);  
            }
        }

        private void UpdatePlayerOnMoveLabel()
        {
            Colour playerOnMove = _game.GetPlayerOnMoveColour();
            if (playerOnMove == Colour.White)
            {
                whoMoveLabel.Text = "Ruch białych";
            }
            else
            {
                whoMoveLabel.Text = "Ruch czarnych";
            }
        }

        private void ColourPossibleMoves()
        {
            if (_lastClickedTile == null)
                return;

            // colouring possible moves for clicked piece
            int lastX = _lastClickedTile.Value.X;
            int lastY = _lastClickedTile.Value.Y;
            List<Point> possibleMoves = _game.GetPossibleMoves(lastX, lastY);

            if (possibleMoves.Count > 0)
            {
                foreach (Point move in possibleMoves)
                {
                    _chessBoardPanels[move.X, move.Y].BackColor = Color.LimeGreen;
                }
            }
            return;
        }

        private void DrawPromotionPanel()
        {
            Button btnQueen = new Button()
            {
                BackgroundImage = new Bitmap(TextureHandler.GetPieceTexture(new Queen(_game.GetColourOnMove()).ToString(), _game.GetColourOnMove()), new Size(_tileSize, _tileSize)),
                Location = new Point(0, 0),
                Width = _tileSize,
                Height = _tileSize
            };
            Button btnRook = new Button()
            {
                BackgroundImage = new Bitmap(TextureHandler.GetPieceTexture(new Rook(_game.GetColourOnMove()).ToString(), _game.GetColourOnMove()), new Size(_tileSize, _tileSize)),
                Location = new Point(_tileSize, 0),
                Width = _tileSize,
                Height = _tileSize
            };
            Button btnBishop = new Button()
            {
                BackgroundImage = new Bitmap(TextureHandler.GetPieceTexture(new Bishop(_game.GetColourOnMove()).ToString(), _game.GetColourOnMove()), new Size(_tileSize, _tileSize)),
                Location = new Point(_tileSize * 2, 0),
                Width = _tileSize,
                Height = _tileSize
            };
            Button btnKnight = new Button()
            {
                BackgroundImage = new Bitmap(TextureHandler.GetPieceTexture(new Knight(_game.GetColourOnMove()).ToString(), _game.GetColourOnMove()), new Size(_tileSize, _tileSize)),
                Location = new Point(_tileSize * 3, 0),
                Width = _tileSize,
                Height = _tileSize
            };
            Button btnCancel = new Button()
            {
                Text = "Cofnij",
                Location = new Point(_tileSize * 4, 0),
                Width = _tileSize,
                Height = _tileSize
            };


            promotionPanel.Controls.Add(btnQueen);
            promotionPanel.Controls.Add(btnRook);
            promotionPanel.Controls.Add(btnBishop);
            promotionPanel.Controls.Add(btnKnight);
            promotionPanel.Controls.Add(btnCancel);

            // Przypisujemy zdarzenia do przycisków
            btnQueen.Click += (sender, e) => PromotePawn(new Queen(_game.GetColourOnMove()));
            btnRook.Click += (sender, e) => PromotePawn(new Rook(_game.GetColourOnMove()));
            btnBishop.Click += (sender, e) => PromotePawn(new Bishop(_game.GetColourOnMove()));
            btnKnight.Click += (sender, e) => PromotePawn(new Knight(_game.GetColourOnMove()));
            btnCancel.Click += (sender, e) => ResetPromotionPanel();

            promotionPanel.Visible = false;
            promotionPanel.BringToFront();
        }

        private void PromotePawn(IPiece piece)
        {
            bool success = _game.TryToPromotePawnGUI(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, _promoteTo.Value.X, _promoteTo.Value.Y, piece);
            if (success && _game.GetPlayerColour() != Game.PlayerColour.Both)
            {
                _moveNetworkManager.SendData(new MoveMessage(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, _promoteTo.Value.X, _promoteTo.Value.Y, piece.ToString()).Serialize());
            }

            _lastClickedTile = null;

            ResetPromotionPanel();
        }


        private void ResetPromotionPanel()
        {
            promotionPanel.Visible = false;

            UpdateBoard();
            EndGameMaybe();
        }

        void TileClick(object sender, EventArgs e, int x, int y)
        {
            Panel clickedPanel = sender as Panel;
            promotionPanel.Visible = false;

            if (_lastClickedTile != null && _game.IsMovePossible(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y))
            {
                btnDraw.BackColor = Color.DarkKhaki;
                btnDraw.Text = "Zaproponuj remis";

                if (isPromotion(_lastClickedTile, y))
                {
                    promotionPanel.Visible = true;
                    _promoteTo = new Point(x, y);
                    return;
                }

                bool success = _game.TryToMovePieceGUI(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y);

                if (success && _game.GetPlayerColour() != Game.PlayerColour.Both)
                {
                    _moveNetworkManager.SendData(new MoveMessage(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y,
                                            _game.GetField(x, y).ToString()).Serialize());
                }


                _lastClickedTile = null;
            }
            else
            {
                if (_game.GetField(x, y) != null)
                {
                    _lastClickedTile = new Point(x, y);

                }
                else
                {
                    _lastClickedTile = null;
                }
            }
            UpdateBoard();
            EndGameMaybe();
        }

        private bool isPromotion(Point? _lastClickedTile, int y2)
        {
            if (_game.GetField(_lastClickedTile.Value.X, _lastClickedTile.Value.Y).ToString() == "P")
            {
                if (y2 == 0 || y2 == 7)
                    return true;
            }
            return false;
        }

        void ReceiveData(MoveMessage message)
        {
            if (InvokeRequired)
            {
                // Queueing in main thread 
                Invoke(new Action<MoveMessage>(ReceiveData), message);
            }
            else
            {
                if (message.IsResignation())
                {
                    EndGame(Game.GameResult.Win, "Przeciwnik(czka) się poddał(a).");
                    return;
                }
                if (message.IsDrawProposal())
                {
                    btnDraw.BackColor = Color.DeepSkyBlue;
                    btnDraw.Text = "Przyjmuję remis";
                    return;
                }
                if (message.IsDrawAccepted())
                {
                    EndGame(Game.GameResult.Draw, "Remis za porozumieniem stron.");
                    return;
                }
                if (message.IsGameEnded())
                {
                    Game.GameResult result = GameResult.Win;
                    switch (message.gameResult)
                    {
                        case "Win":
                            result = Game.GameResult.Win;
                            break;
                        case "Lost":
                            result = Game.GameResult.Lost;
                            break;
                        case "Draw":
                            result = Game.GameResult.Draw;
                            break;
                    }
                    EndGame(result, message.gameResultReason);
                    return;
                }

                // In main thread
                IPiece piece;
                Colour colour = _game.GetField(message.oldX, message.oldY).GetColour();

                switch (message.piece)
                {
                    case "P":
                        piece = new Pawn(colour); break;
                    case "R":
                        piece = new Rook(colour); break;
                    case "B":
                        piece = new Bishop(colour); break;
                    case "N":
                        piece = new Knight(colour); break;
                    case "Q":
                        piece = new Queen(colour); break;
                    case "K":
                        piece = new King(colour); break;
                    default:
                        piece = new Pawn(colour); break;
                }


                _game.TryToMovePieceNetwork(message.oldX, message.oldY, message.newX, message.newY, piece);

                _lastClickedTile = null;

                UpdateBoard();
                EndGameMaybe();
            }
        }

        private void EndGameMaybe()
        {
            // check if game ended only if it's online game and you are host
            if (_connectionType == ConnectionType.Client)
            {
                return;
            }

            KeyValuePair<GameResult, string> result = _game.IsEndGame();

            if (result.Key != GameResult.None)
            {
                if (_game.GetPlayerColour() != Game.PlayerColour.Both)
                {
                    SendGameResultToClient(result);
                }
                EndGame(result.Key, result.Value);
            }
        }

        private void SendGameResultToClient(KeyValuePair<GameResult, string> result)
        {
            string resultStr = "";
            switch (result.Key)
            {
                case GameResult.Win:
                    resultStr = "Lost";
                    break;
                case GameResult.Lost:
                    resultStr = "Win";
                    break;
                case GameResult.Draw:
                    resultStr = "Draw";
                    break;
            }

            _moveNetworkManager.SendData(new MoveMessage(resultStr, result.Value).Serialize());
        }

        private void EndGame(Game.GameResult gameResult, string reason)
        {
            string result = "";
            switch (gameResult)
            {
                case Game.GameResult.Lost: result = "Przegrana!"; break;
                case Game.GameResult.Win: result = "Wygrana!"; break;
                case Game.GameResult.Draw: result = "Remis!"; break;
            }

            _showPlayersTime.Stop();

            MessageBox.Show(reason, "Koniec gry! " + result, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            if (_parentForm != null)
            {
                _parentForm.Close();
            }

            if (_moveNetworkManager != null)
            {
                _moveNetworkManager.Close();
            }

        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (_game.GetPlayerColour() != Game.PlayerColour.Both)
            {
                _moveNetworkManager.SendData(MoveMessage.RESIGNATION.Serialize());
                EndGame(Game.GameResult.Lost, "Poddałeś się. Twój przeciwnik wygrał!");
            }
            EndGame(Game.GameResult.Draw, "Przerwano grę!");

        }


        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (btnDraw.BackColor == Color.DeepSkyBlue)
            {
                _moveNetworkManager.SendData(MoveMessage.DRAWACCEPTED.Serialize());
                EndGame(Game.GameResult.Draw, "Remis za porozumieniem stron.");
                return;
            }

            MessageBox.Show("Do Twojego przeciwnika została wysłana wiadomość o propozycji remisu.", "PROPOZYCJA REMISU", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (_game.GetPlayerColour() != Game.PlayerColour.Both)
            {
                _moveNetworkManager.SendData(MoveMessage.DRAWPROPOSAL.Serialize());
            }
        }

    }
}
