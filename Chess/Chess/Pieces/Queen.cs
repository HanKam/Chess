using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class Queen : IPiece
    {
        private Colour _colour;
        private char _name = 'Q';

        public Queen(Colour colour)
        {
            _colour = colour;
        }
        public Colour getColour()
        {
            return _colour;
        }

        public override string ToString()
        {
            return _name.ToString();
        }

        public List<Point> getPossibleMoves(ChessBoard gb, int currentPositionX, int currentPositionY)
        {
            List<Point> tempPossibleMoves = new Rook(this._colour).getPossibleMoves(gb, currentPositionX, currentPositionY);
            tempPossibleMoves.AddRange(new Bishop(this._colour).getPossibleMoves(gb, currentPositionX, currentPositionY));

            return tempPossibleMoves;
        }
    }
}
