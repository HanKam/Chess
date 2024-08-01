using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class Bishop : IPiece
    {
        private Colour _colour;
        private char _name = 'B';
        public Bishop(Colour colour)
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
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX + i, currentPositionY + i)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX + i, currentPositionY + i, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX + i, currentPositionY + i, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX + i, currentPositionY + i));
                    break;
                }
                tempPossibleMoves.Add(new Point(currentPositionX + i, currentPositionY + i));
            }
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX + i, currentPositionY - i)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX + i, currentPositionY - i, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX + i, currentPositionY - i, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX + i, currentPositionY - i));
                    break;
                }

                tempPossibleMoves.Add(new Point(currentPositionX + i, currentPositionY - i));
            }
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX - i, currentPositionY + i)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX - i, currentPositionY + i, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX - i, currentPositionY + i, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX - i, currentPositionY + i));
                    break;
                }

                tempPossibleMoves.Add(new Point(currentPositionX - i, currentPositionY + i));
            }
            for (int i = 1; i < 8; i++)
            {
                if (ChessBoard.IsOutOfBounds(currentPositionX - i, currentPositionY - i)) break;
                if (ChessBoardHelper.IsThereMyPiece(gb, currentPositionX - i, currentPositionY - i, this._colour)) break;
                if (ChessBoardHelper.IsThereEnemy(gb, currentPositionX - i, currentPositionY - i, this._colour))
                {
                    tempPossibleMoves.Add(new Point(currentPositionX - i, currentPositionY - i));
                    break;
                }

                tempPossibleMoves.Add(new Point(currentPositionX - i, currentPositionY - i));
            }

            

            return tempPossibleMoves;
        }

    }
}
