using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    internal class HistoryRecord
    {
        public char piece;
        public Point from;
        public Point to;

        //Chess Notation
        public enum MoveType
        {
            Normal,
            Check,
            Mate
        }

        public MoveType moveType;
        public bool capture;
        public char? pieceTo;

        public HistoryRecord(char piece, Point from, Point to, MoveType moveType, bool capture)
        {
            this.piece = piece;
            this.from = from;
            this.to = to;
            this.moveType = moveType;
            this.capture = capture;
            this.pieceTo = null;
        }

        public void MarkPromotion(char pieceTo)
        {
            this.pieceTo = pieceTo;
        }

        public override string ToString()
        {
            string move = "";
            string separator = "-";

            if(this.capture)
                separator = "x";

            if(this.piece == 'P')
                move = ((char)(this.from.X + 'a')).ToString() + this.from.Y.ToString() + separator 
                    + ((char)(this.to.X + 'a')).ToString() + this.to.Y.ToString();
            else
                move = piece.ToString() + ((char)(this.from.X + 'a')).ToString() + this.from.Y.ToString() + separator 
                    + ((char)(this.to.X + 'a')).ToString() + this.to.Y.ToString();

            if (this.piece == 'K' && this.to.X == 6)
                move = "O-O";
            if (this.piece == 'K' && this.to.X == 2)
                move = "O-O-O";

            if (this.pieceTo != null)
            {
                move = move + "=" + this.pieceTo.ToString();
            }
            if(moveType == MoveType.Check) 
            {
                move += "+";
            }
            if(moveType == MoveType.Mate)
            {   
                move += "#";
            }

            return move;
        }
    }
    internal class MovesHistory
    {
        private List<HistoryRecord> _history;

        public MovesHistory()
        {
            _history = new List<HistoryRecord>();
        }
        public void AddMove(HistoryRecord record)
        {
            _history.Add(record);
        }

        public HistoryRecord GetLastMove() 
        {
            return _history.Last();
        }
        public bool IsEmpty()
        { 
            return _history.Count == 0; 
        }

        public bool DidPieceMoved(int x, int y)
        {
            foreach (HistoryRecord record in _history)
            {
                if(record.to.X == x && record.to.Y == y)
                    return true;
            }

            return false;
        }

        public override string ToString()
        {
            string stringHistory = "";
            bool blackMove = false;

            foreach (HistoryRecord record in _history)
            {
                stringHistory += record.ToString();


                if (blackMove)
                {
                    stringHistory += "\n";
                    blackMove = false;                    
                }
                else
                {
                    for (int i = record.ToString().Length; i < 12; i++)
                        stringHistory += " ";
                    blackMove = true;
                }
            }

            return stringHistory;
        }
    }
}
