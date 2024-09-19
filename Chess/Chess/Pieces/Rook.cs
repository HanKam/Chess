using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class Rook : IPiece
    {
        private Colour _colour;
        private char _name = 'R';
        public Rook(Colour colour)
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
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX, currentPositionY + i)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX, currentPositionY + i, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX, currentPositionY + i, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX, currentPositionY + i));
                    break;
                }
                tempPossibleMoves.Add(new Point(currentPositionX, currentPositionY + i));
            }
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX, currentPositionY - i)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX, currentPositionY - i, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX, currentPositionY - i, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX, currentPositionY - i));
                    break;
                }

                tempPossibleMoves.Add(new Point(currentPositionX, currentPositionY - i));
            }
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX + i, currentPositionY)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX + i, currentPositionY, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX + i, currentPositionY, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX + i, currentPositionY));
                    break;
                }

                tempPossibleMoves.Add(new Point(currentPositionX + i, currentPositionY));
            }
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX - i, currentPositionY)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX - i, currentPositionY, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX - i, currentPositionY, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX - i, currentPositionY));
                    break;
                }

                tempPossibleMoves.Add(new Point(currentPositionX - i, currentPositionY));
            }

            

            return tempPossibleMoves;
        }
    }
}
