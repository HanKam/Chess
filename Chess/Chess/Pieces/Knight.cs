using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class Knight : IPiece
    {
        private Colour _colour;
        private char _name = 'N';

        public Knight(Colour colour)
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
            List<Point> tempPossibleMoves = new List<Point>();
            List<Point> possibleJumps = new() { new Point(2, 1), new Point(2, -1), 
                                                new Point(1, 2), new Point(-1, 2),
                                                new Point(-2, 1), new Point(-2,-1),
                                                new Point(1, -2), new Point(-1, -2)};

            foreach (Point jump in possibleJumps)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX + jump.X, currentPositionY + jump.Y)) continue;
                if (ChessBoardHelper.IsEmptyOrIsThereEnemy(gb, currentPositionX + jump.X, currentPositionY + jump.Y, this._colour))
                    tempPossibleMoves.Add(new Point(currentPositionX + jump.X, currentPositionY + jump.Y));
            }

           

            return tempPossibleMoves;
        }
    }
}
                                                                                        