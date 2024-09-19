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

            // castling 
            if (history.DidPieceMoved(currentPositionX, currentPositionY))
                return tempPossibleMoves;

            if (gb.GetField(currentPositionX + 3, currentPositionY) != null && !history.DidPieceMoved(currentPositionX + 3, currentPositionY))
            {
                bool isEmpty =  (gb.GetField(currentPositionX + 1, currentPositionY) == null) &&
                                (gb.GetField(currentPositionX + 2, currentPositionY) == null);

                if(isEmpty)
                {
                    tempPossibleMoves.Add(new Point(currentPositionX + 2, currentPositionY));
                }

            }
            if (gb.GetField(currentPositionX - 4, currentPositionY) != null && !history.DidPieceMoved(currentPositionX - 4, currentPositionY))
            {
                bool isEmpty =  (gb.GetField(currentPositionX - 1, currentPositionY) == null) &&
                                (gb.GetField(currentPositionX - 2, currentPositionY) == null) &&
                                (gb.GetField(currentPositionX - 3, currentPositionY) == null);

                if (isEmpty)
                {
                    tempPossibleMoves.Add(new Point(currentPositionX - 2, currentPositionY));
                }
            }


            return tempPossibleMoves;
        }
    }
}
