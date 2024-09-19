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
        public Char piece;
        public Point from;
        public Point to;

        public HistoryRecord(char piece, Point from, Point to)
        {
            this.piece = piece;
            this.from = from;
            this.to = to;
        }
        public override string ToString()
        {
            return piece.ToString() + from.ToString() + to.ToString();
        }
    }
    internal class MovesHistory
    {
        private List<HistoryRecord> history;

        public MovesHistory()
        {
            history = new List<HistoryRecord>();
        }
        public void AddMove(HistoryRecord record)
        {
            history.Add(record);
        }

        public HistoryRecord GetLastMove() 
        {
            return history.Last();
        }
        public bool IsEmpty()
        { 
            return history.Count == 0; 
        }

        public bool DidPieceMoved(int x, int y)
        {
            foreach (HistoryRecord record in history)
            {
                if(record.to.X == x && record.to.Y == y)
                    return true;
            }

            return false;
        }
    }
}
