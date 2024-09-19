using Chess.Pieces;
using System.Drawing;

namespace Chess
{
    public partial class ChessBoardForm : Form
    {

        private Panel[,] _chessBoardPanels;
        private const int _tileSize = 50;
        private ChessBoard _chessBoard;
        private Point? _lastClickedTile;
        private MovesHistory _history;

        public ChessBoardForm()
        {
            InitializeComponent();
            _chessBoard = new ChessBoard();
            _chessBoard.Initializer();

            _history = new MovesHistory();
        }

        private void ChessBoardForm_Load(object sender, EventArgs e)
        {
            _chessBoardPanels = new Panel[8, 8];
            _lastClickedTile = null;

            BackColor = Color.LightSlateGray;
            this.DrawBoard();
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

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    // creating tiles
                    Panel boardTile = new Panel
                    {
                        Size = new Size(_tileSize, _tileSize),
                        Location = new Point(_tileSize * x, _tileSize * y ),
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
                    IPiece piece = _chessBoard.GetField(x, y);
                    if (piece != null)
                    {
                        currentPanel.BackgroundImage = new Bitmap(TextureHandler.GetPieceTexture(
                                                                                piece.ToString(), 
                                                                                piece.GetColour()), 
                                                                  new Size(_tileSize, _tileSize));
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
            List<Point> possibleMoves = _chessBoard.GetPossibleMoves(lastX, lastY, _history);

            if (possibleMoves.Count > 0)
            {
                foreach (Point move in possibleMoves)
                {
                    _chessBoardPanels[move.X, move.Y].BackColor = Color.LimeGreen;
                }
            }
            return;
        }

        void TileClick(object sender, EventArgs e, int x, int y)
        {
            Panel clickedPanel = sender as Panel;
                         
            if (_lastClickedTile != null && _chessBoard.IsMovePossible(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y, _history))
            {
                _history.AddMove(new HistoryRecord(_chessBoard.GetField(_lastClickedTile.Value.X, _lastClickedTile.Value.Y).ToString()[0],
                                                        new Point(_lastClickedTile.Value.X, _lastClickedTile.Value.Y),
                                                        new Point(x, y)));
                _chessBoard.MovePiece(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y);
                
                _lastClickedTile = null;
            }
            else
            {
                if (_chessBoard.GetField(x, y) != null)
                {
                    _lastClickedTile = new Point(x, y);
                    
                }
                else
                {
                    _lastClickedTile = null;
                }
            }

            UpdateBoard();
            this.Refresh();
            
        }
    }
}
