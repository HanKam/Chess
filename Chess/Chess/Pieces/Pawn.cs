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
            if (currentPositionX - 1 > 0 && 
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

            // en passant - serach in history if last oponent's move was 2 step pawn TODO


            // verification if check after the move TODO


            return tempPossibleMoves;
        }
    }
}
