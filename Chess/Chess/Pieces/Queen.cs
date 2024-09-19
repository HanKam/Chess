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
        public Colour GetColour()
        {
            return _colour;
        }

        public override string ToString()
        {
            return _name.ToString();
        }

        public List<Point> GetPossibleMoves(ChessBoard gb, int currentPositionX, int currentPositionY, MovesHistory history)
        {
            List<Point> tempPossibleMoves = new Rook(this._colour).GetPossibleMoves(gb, currentPositionX, currentPositionY, history);
            tempPossibleMoves.AddRange(new Bishop(this._colour).GetPossibleMoves(gb, currentPositionX, currentPositionY, history));

            

            return tempPossibleMoves;
        }
    }
}
