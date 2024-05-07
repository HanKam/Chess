using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class King : IPiece
    {
        private Colour _colour;
        private char _name = 'K';

        public King(Colour colour)
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
            List<Point> tempPossibleMoves = new List<Point>();
            int[] steps = { -1, 0, 1 };

            foreach (int y in steps)
            {
                foreach (int x in steps)
                {
                    if (y == 0 && x == 0) continue;
                    if (!ChessBoard.IsOutOfBounds(currentPositionX + x, currentPositionY + y) &&
                        ChessBoardHelper.IsEmptyOrIsThereEnemy(gb, currentPositionX + x, currentPositionY + y, this._colour))
                    {
                        tempPossibleMoves.Add(new Point(currentPositionX + x, currentPositionY + y));
                    }
                }
            }

            // castling - search in history for moves king, rooks and check space TODO

            // verification if check after move TODO

            return tempPossibleMoves;
        }
    }
}
