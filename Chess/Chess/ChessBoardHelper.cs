using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class ChessBoardHelper
    {
        static public bool IsEmpty(ChessBoard gb, int x, int y)
        {
            return gb.GetField(x, y) == null;
        }
        static public bool IsThereEnemy(ChessBoard gb, int x, int y, Colour colour)
        {
            IPiece piece = gb.GetField(x, y);
            if (piece == null) return false;
            return piece.getColour() != colour;
        }
        static public bool IsThereMyPiece(ChessBoard gb, int x, int y, Colour colour)
        {
            IPiece piece = gb.GetField(x, y);
            if (piece == null) return false;
            return piece.getColour() == colour;
        }
        static public bool IsEmptyOrIsThereEnemy(ChessBoard gb, int x, int y, Colour colour)
        {
            return IsEmpty(gb, x, y) || IsThereEnemy(gb, x, y, colour);        
        }
    }
}
