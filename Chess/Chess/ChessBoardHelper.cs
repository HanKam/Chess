using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class ChessBoardHelper
    {
        static public bool IsEmpty(ChessBoard gb, int x, int y)
        {
            return gb.GetField(x, y) == null;
        }
        static public bool IsThereEnemy(ChessBoard gb, int x, int y, Colour colour)
        {
            IPiece piece = gb.GetField(x, y);
            if (piece == null) return false;
            return piece.GetColour() != colour;
        }
        static public bool IsThereMyPiece(ChessBoard gb, int x, int y, Colour colour)
        {
            IPiece piece = gb.GetField(x, y);
            if (piece == null) return false;
            return piece.GetColour() == colour;
        }
        static public bool IsEmptyOrIsThereEnemy(ChessBoard gb, int x, int y, Colour colour)
        {
            return IsEmpty(gb, x, y) || IsThereEnemy(gb, x, y, colour);        
        }

        static public bool IsThereInsufficientMaterial(ChessBoard gb, Colour colour)
        {
            string[] majorPieceOrPawn = new string[] {
                new Queen(Colour.White).ToString(),
                new Rook(Colour.White).ToString(),
                new Pawn(Colour.White).ToString()
            };

            string knight = new Knight(Colour.White).ToString();
            string bishop = new Bishop(Colour.White).ToString();

            int knightNum = 0;
            int bishopNum = 0;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (gb.GetField(x, y) == null || gb.GetField(x, y).GetColour() != colour)
                    {
                        continue;
                    }

                    string pieceStr = gb.GetField(x, y).ToString();

                    // if player has at least 1 major piece or pawn it's not insufficient material
                    if (majorPieceOrPawn.Contains(pieceStr))
                    {
                        return false;
                    }

                    if (pieceStr == knight)
                    {
                        knightNum++;
                    }

                    if (pieceStr ==  bishop)
                    {
                        bishopNum++;
                    }

                    if (bishopNum > 1 || knightNum > 2 || (bishopNum > 0 && knightNum > 0))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
