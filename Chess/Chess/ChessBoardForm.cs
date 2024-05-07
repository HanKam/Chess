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

        public ChessBoardForm()
        {
            InitializeComponent();
            _chessBoard = new ChessBoard();
            _chessBoard.Initializer();
        }

        private void ChessBoardForm_Load(object sender, EventArgs e)
        {
            _chessBoardPanels = new Panel[8, 8];
            _lastClickedTile = null;
            this.DrawBoard();
        }
        private void DrawBoard()
        {
            Color colour1 = Color.SaddleBrown;
            Color colour2 = Color.SandyBrown;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    // creating tiles
                    Panel newPanel = new Panel
                    {
                        Size = new Size(_tileSize, _tileSize),
                        Location = new Point(_tileSize * x, _tileSize * y)
                    };

                    newPanel.Click += TileClick;
                    Controls.Add(newPanel);
                    _chessBoardPanels[x, y] = newPanel;


                }
            }
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
                        currentPanel.BackgroundImage = new Bitmap(TextureHandler.GetPieceTexture(piece.ToString(), piece.getColour()), new Size(_tileSize, _tileSize));
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

            if (_lastClickedTile == null)
                return;

            // colouring possible moves for clicked piece
            int lastX = _lastClickedTile.Value.X;
            int lastY = _lastClickedTile.Value.Y;
            List<Point> possibleMoves = _chessBoard.GetField(lastX, lastY).getPossibleMoves(_chessBoard, lastX, lastY);
                
            if (possibleMoves.Count > 0)
            {
                foreach (Point move in possibleMoves)
                {
                    _chessBoardPanels[move.X, move.Y].BackColor = Color.GreenYellow;
                    Console.WriteLine(_chessBoardPanels[move.X, move.Y].BackColor.ToString());
                }
            }
                  
            
        }
        
        void TileClick(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            int x = clickedPanel.Location.X/ _tileSize;
            int y = clickedPanel.Location.Y/ _tileSize;

            Console.WriteLine("Klikniêto pole: ({0}, {1})", x, 7-y);

            
            if (_lastClickedTile != null && _chessBoard.isMovePossible(_lastClickedTile.Value.X, _lastClickedTile.Value.Y, x, y))
            {
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
