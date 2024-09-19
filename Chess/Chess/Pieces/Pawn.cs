using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class Pawn : IPiece
    {
        private Colour _colour;
        private char _name = 'P';

        public Pawn(Colour colour)
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
            int step = 0;
            int initialY = 0;

            if(this._colour == Colour.White)
            {
                step = 1;
                initialY = 1;
            }
            else
            {
                step = -1;
                initialY = 6;
            }

            // 1 step forward
            if (gb.GetField(currentPositionX, currentPositionY + step) == null) 
            {
                tempPossibleMoves.Add(new Point(currentPositionX, currentPositionY + step));
            }
            if (currentPositionX + 1 < 8 && 
                ChessBoardHelper.IsThereEnemy(gb, currentPositionX + 1, currentPositionY + step, this._colour))
            {
                tempPossibleMoves.Add(new Point(currentPositionX + 1, currentPositionY + step));
            }
            if (currentPositionX - 1 >= 0 && 
                ChessBoardHelper.IsThereEnemy(gb, currentPositionX - 1, currentPositionY + step, this._colour))
            {
                tempPossibleMoves.Add(new Point(currentPositionX - 1, currentPositionY + step));
            }

            // 2 steps forward
            if (currentPositionY == initialY &&
                ChessBoardHelper.IsEmpty(gb, currentPositionX, currentPositionY + step) &&
                ChessBoardHelper.IsEmpty(gb, currentPositionX, currentPositionY + step * 2))
            {
                tempPossibleMoves.Add(new Point(currentPositionX, currentPositionY + step * 2));
            }

            if (history.IsEmpty())
                return tempPossibleMoves;

            // en passant
            HistoryRecord record = history.GetLastMove();
            if (record != null && record.piece == _name && 
                record.from.Y == currentPositionY + step * 2 && record.to.Y == currentPositionY)
            {
                if (record.from.X == currentPositionX + 1)
                {
                    tempPossibleMoves.Add(new Point(currentPositionX + 1, currentPositionY + step));
                }
                if (record.from.X == currentPositionX - 1)
                {
                    tempPossibleMoves.Add(new Point(currentPositionX - 1, currentPositionY + step));
                }
            }

            // promotion TODO


            


            return tempPossibleMoves;
        }
    }
}
