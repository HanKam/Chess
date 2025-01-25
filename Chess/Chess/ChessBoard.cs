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
        public void SetField(int x, int y, IPiece piece)
        {
            this.board[x, y] = piece;
        }
    
        public void MovePiece(int oldX, int oldY, int newX, int newY)
        {
            //if en passant
            if(this.board[oldX, oldY].ToString() == "P" && oldX != newX && this.board[newX, newY] == null)
            {
                this.board[newX, oldY] = null;
            }

            //if castling
            if (this.board[oldX,oldY].ToString() == "K")
            { 
                if (oldX - newX > 1) 
                {
                    this.board[newX + 1, newY] = this.board[0, newY];
                    this.board[0, newY] = null;
                }
                if (oldX - newX < -1)
                {
                    this.board[newX - 1, newY] = this.board[7, newY];
                    this.board[7, newY] = null;
                }
            }

            this.board[newX, newY] = this.board[oldX, oldY];
            this.board[oldX, oldY] = null;
        }
        public static bool IsOutOfBounds(int x, int y)
        {
            return x < 0 || x > 7 || y < 0 || y > 7;
        }

        public bool IsMovePossible(int oldX, int oldY, int newX, int newY, MovesHistory history)
        {
            return GetPossibleMoves(oldX, oldY, history).Contains(new Point(newX, newY));
        }

        public bool IsCheck(Colour colour, MovesHistory history)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (this.board[i, j] != null && this.board[i, j].GetColour() != colour)
                    {
                        List<Point> possibleMoves = this.board[i, j].GetPossibleMoves(this, i, j, history);
                        foreach(Point move in possibleMoves)
                        {
                            if (this.board[move.X, move.Y] != null && this.board[move.X, move.Y].ToString() == "K")
                                return true;
                        }
                    }
                }
            }


            return false;
        }

        public List<Point> RemoveMovesLeadingToCheck(int currentPositionX, int currentPositionY, List<Point> possibleMoves, Colour colour, MovesHistory history)
        {
            List<Point> tempPossibleMoves = possibleMoves.ToList();
            foreach (Point move in possibleMoves)
            {
                IPiece[,] clone = (IPiece[,]) this.board.Clone();
                ChessBoard clonedBoard = new ChessBoard(clone);

                clonedBoard.MovePiece(currentPositionX, currentPositionY, move.X, move.Y);
                if(clonedBoard.IsCheck(colour, history))
                {
                    tempPossibleMoves.Remove(move);                    
                }
            }

            return tempPossibleMoves;
        }

        public List<Point> GetPossibleMoves(int x, int y, MovesHistory history)
        {
            List<Point> tempPossibleMoves = this.board[x, y].GetPossibleMoves(this, x, y, history);
            return RemoveMovesLeadingToCheck(x, y, tempPossibleMoves, this.board[x, y].GetColour(), history);
            
        }
        
        public override string ToString()
        {
            string str = "";
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (board[y, x] != null)
                    {
                        str += board[y, x].ToString();
                    }
                    else
                    {
                        str += ".";
                    }
                }
            }

            return str; 
        }
    }
}
