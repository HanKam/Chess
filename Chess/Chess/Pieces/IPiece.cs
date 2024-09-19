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
        Colour GetColour();
        List<Point> GetPossibleMoves(ChessBoard gb, int currentPositionX, int currentPositionY, MovesHistory history);

    }
}
