using Chess.Pieces;
using System;
using System.Drawing;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace Chess
{
    public partial class ChessBoardForm : Form
    {

        private Panel[,] _chessBoardPanels;
        private Panel _promotionPanel;
        private const int _tileSize = 50;
        private Point? _lastClickedTile;
        private Point? _promoteTo;
        private Game _game;
        private MoveNetworkManager _moveNetworkManager;

        
        public enum ConnectionType
        {
            Host,
            Client
        }

        public ChessBoardForm(ConnectionType connectionType, Colour colour, IPAddress ipAddress = null)
        {
            InitializeComponent();
            
            _moveNetworkManager = new MoveNetworkManager(6942, ReceiveData);

            if (connectionType == ConnectionType.Host)
            {
                _game = new Game(colour == Colour.White ? Game.PlayerColour.White : Game.PlayerColour.Black);
                _moveNetworkManager.WaitForConnection();
            }
            else
            {
                _game = new Game(colour == Colour.White ? Game.PlayerColour.White : Game.PlayerColour.Black);
                _moveNetworkManager.Connect(ipAddress.ToString(), 6942);
            }
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

            GroupBox board = new GroupBox()
            {
                Size = new Size(_tileSize * 8, _tileSize * 8),                
                Anchor = AnchorStyles.None,
                Dock = DockStyle.Fill
            };

            _promotionPanel = new Panel()
            {
                Width = _tileSize * 5 + 1,
                Height = _tileSize + 5,
                Location = new Point((_tileSize * 8 - _tileSize * 5 - 1)/2, -_tileSize - 8),
                Visible = false,
                Anchor = AnchorStyles.None,
            };
            board.Controls.Add(_promotionPanel);

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    int visibleY = (_game.getPlayerColour() == Game.PlayerColour.Black) ? y : 7 - y;
                    // creating tiles
                    Panel boardTile = new Panel
                    {
                        Size = new Size(_tileSize, _tileSize),
                        Location = new Point(_tileSize * x, _tileSize * visibleY),
                        BorderStyle = BorderStyle.FixedSingle,
                        Anchor = AnchorStyles.None
                    };

                    // creating lambda function to call TileClick with specific x, y 
                    int xCopy = x;
                    int yCopy = y;
                    boardTile.Click += (sender, eventArgs) => TileClick(sender, eventArgs, xCopy, yCopy);
                    board.Controls.Add(boardTile);
                    _chessBoardPanels[x, y] = boardTile;
                }
            }
            Controls.Add(board);
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
            ColourPossibleMoves();                            
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
                Text = "Cancel",
                Location = new Point(_tileSize * 4, 0),
                Width = _tileSize,
                Height = _tileSize
            };


            _promotionPanel.Controls.Add(btnQueen);
            _promotionPanel.Controls.Add(btnRook);
            _promotionPanel.Controls.Add(btnBishop);
            _promotionPanel.Controls.Add(btnKnight);
            _promotionPanel.Controls.Add(btnCancel);

            // Przypisujemy zdarzenia do przycisków
            btnQueen.Click += (sender, e) => PromotePawn(new Queen(_game.GetColourOnMove()));
            btnRook.Click += (sender, e) => PromotePawn(new Rook(_game.GetColourOnMove()));
            btnBishop.Click += (sender, e) => PromotePawn(new Bishop(_game.GetColourOnMove()));
            btnKnight.Click += (sender, e) => PromotePawn(new Knight(_game.GetColourOnMove()));
            btnCancel.Click += (sender, e) => ResetPromotionPanel();

            _promotionPanel.BringToFront();
        }

        private void PromotePawn(IPiece piece)
        {
            bool success = _game.TryToPromotePawnGUI(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, _promoteTo.Value.X, _promoteTo.Value.Y, piece);
            if (success)
            {
                _moveNetworkManager.SendData(new MoveMessage(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, _promoteTo.Value.X, _promoteTo.Value.Y, piece.ToString()).Serialize());
            }
            _lastClickedTile = null;

            ResetPromotionPanel();
        }

        private void ResetPromotionPanel()
        {
            _promotionPanel.Visible = false;

            UpdateBoard();
        }

        void TileClick(object sender, EventArgs e, int x, int y)
        {
            Panel clickedPanel = sender as Panel;
            _promotionPanel.Visible = false;

            if (_lastClickedTile != null && _game.IsMovePossible(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y))
            {
                if (isPromotion(_lastClickedTile, y))
                {
                    _promotionPanel.Visible = true;
                    _promoteTo = new Point(x, y);
                    return;
                }

                bool success = _game.TryToMovePieceGUI(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y);                

                if (success)
                {
                    _moveNetworkManager.SendData(new MoveMessage(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y,
                                            _game.GetField(x, y).ToString()).Serialize());
                }
                _lastClickedTile = null;
            }
            else
            {
                if (_game.GetField(x,y) != null)
                {
                    _lastClickedTile = new Point(x, y);
                    
                }
                else
                {
                    _lastClickedTile = null;
                }
            }                     
            UpdateBoard();            
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

                
                Console.Out.WriteLine(message.Serialize());
                
                _game.TryToMovePieceNetwork(message.oldX, message.oldY, message.newX, message.newY, piece);
                _lastClickedTile = null;    
                UpdateBoard();
            }
        }
    }
}
