using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    enum Colour
    {
        Black, White
    }
    internal interface IPiece 
    {
        Colour getColour();
        List<Point> getPossibleMoves(ChessBoard gb, int currentPositionX, int currentPositionY);

    }
}
