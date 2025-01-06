using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class TextureHandler
    {
        private const int _tileSize = 50;

        static public int GetBitmapId(string pieceName, Colour pieceColour)
        {
            switch (pieceName)
            {
                case "P":
                    if (pieceColour == Colour.White)
                        return 0;
                    else
                        return 1;
                case "N":
                    if (pieceColour == Colour.White)
                        return 2;
                    else
                        return 3;
                case "B":
                    if (pieceColour == Colour.White)
                        return 4;
                    else
                        return 5;
                case "R":
                    if (pieceColour == Colour.White)
                        return 6;
                    else
                        return 7;
                case "Q":
                    if (pieceColour == Colour.White)
                        return 8;
                    else
                        return 9;
                case "K":
                    if (pieceColour == Colour.White)
                        return 10;
                    else
                        return 11;
                default:
                    throw new Exception("No image.");
            }
        }
        static public Bitmap GetPieceTexture(string pieceName, Colour pieceColour)
        {
            if (_bitmapCache == null)
            {
                _bitmapCache = new Bitmap[]{
                    new Bitmap(Properties.Resources.PawnWhite, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.PawnBlack, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.KnightWhite, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.KnightBlack, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.BishopWhite, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.BishopBlack, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.RookWhite, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.RookBlack, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.QueenWhite, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.QueenBlack, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.KingWhite, new Size(_tileSize, _tileSize)),
                    new Bitmap(Properties.Resources.KingBlack, new Size(_tileSize, _tileSize)),
                };
            }

            return _bitmapCache[GetBitmapId(pieceName, pieceColour)];
        }

        static private Bitmap[] _bitmapCache = null;
    }
}
