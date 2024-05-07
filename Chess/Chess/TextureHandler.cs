using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class TextureHandler
    {
        static public Bitmap GetPieceTexture(string pieceName, Colour pieceColour)
        {
            switch(pieceName)
            {
                case "P" :
                    if (pieceColour == Colour.White)
                        return Properties.Resources.PawnWhite;
                    else 
                        return Properties.Resources.PawnBlack;
                case "N" :
                    if (pieceColour == Colour.White)
                        return Properties.Resources.KnightWhite;
                    else
                        return Properties.Resources.KnightBlack;
                case "B" :
                    if (pieceColour == Colour.White)
                        return Properties.Resources.BishopWhite;
                    else
                        return Properties.Resources.BishopBlack;
                case "R" :
                    if (pieceColour == Colour.White)
                        return Properties.Resources.RookWhite;
                    else
                        return Properties.Resources.RookBlack;
                case "Q" :
                    if (pieceColour == Colour.White)
                        return Properties.Resources.QueenWhite;
                    else
                        return Properties.Resources.QueenBlack;
                case "K" :
                    if (pieceColour == Colour.White)
                        return Properties.Resources.KingWhite;
                    else
                        return Properties.Resources.KingBlack;
                default:
                    throw new Exception("No image.");
            }
        }
    }
}
