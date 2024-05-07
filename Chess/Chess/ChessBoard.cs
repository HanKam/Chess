using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Chess.Pieces;

namespace Chess
{
    internal class ChessBoard
    {
        // [column, row]
        private IPiece[,] board { get; set; }


        public ChessBoard()
        {
            this.board = new IPiece[8, 8];
        }
        public ChessBoard(IPiece[,] board)
        {
            this.board = board;
        }
        public void Initializer()
        {
            // initialize pawns
            for (int x = 0; x < 8; x++)
            {
                this.board[x, 1] = new Pawn(Colour.White);
                this.board[x, 6] = new Pawn(Colour.Black);
            }
            // initialize knights
            this.board[1, 0] = new Knight(Colour.White);
            this.board[6, 0] = new Knight(Colour.White);
            this.board[1, 7] = new Knight(Colour.Black);
            this.board[6, 7] = new Knight(Colour.Black);
            // initialize bishops
            this.board[2, 0] = new Bishop(Colour.White);
            this.board[5, 0] = new Bishop(Colour.White);
            this.board[2, 7] = new Bishop(Colour.Black);
            this.board[5, 7] = new Bishop(Colour.Black);
            // initialize rooks          
            this.board[0, 0] = new Rook(Colour.White);
            this.board[7, 0] = new Rook(Colour.White);
            this.board[0, 7] = new Rook(Colour.Black);
            this.board[7, 7] = new Rook(Colour.Black);
            // initialize queens
            this.board[3, 0] = new Queen(Colour.White);
            this.board[3, 7] = new Queen(Colour.Black);
            // initialize kings
            this.board[4, 0] = new King(Colour.White);
            this.board[4, 7] = new King(Colour.Black);
        }

        public IPiece GetField(int x, int y)
        {
            return this.board[x, y];
        }
        public void MovePiece(int oldX, int oldY, int newX, int newY)
        {
            this.board[newX, newY] = this.board[oldX, oldY];
            this.board[oldX, oldY] = null;
        }
        public static bool IsOutOfBounds(int x, int y)
        {
            return x < 0 || x > 7 || y < 0 || y > 7;
        }
        public bool isMovePossible(int oldX, int oldY, int newX, int newY)
        {
            IPiece oldPiece = this.board[oldX, oldY];
            return oldPiece.getPossibleMoves(this, oldX, oldY).Contains(new Point(newX, newY));
        }
        public void PrintBoard()
        {
            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (this.board[x, y] != null)
                    {
                        Console.Write(this.board[x, y].ToString());
                        Console.Write(' ');
                    }
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}
