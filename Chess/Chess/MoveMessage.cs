using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chess
{
    public class MoveMessage : IMessage
    {
        public static readonly MoveMessage RESIGNATION = new MoveMessage(oldX: -1, oldY: -1, newX: -1, newY: -1, "");
        public static readonly MoveMessage DRAWPROPOSAL = new MoveMessage(oldX: 8, oldY: 8, newX: 8, newY: 8, "");
        public static readonly MoveMessage DRAWACCEPTED = new MoveMessage(oldX: 9, oldY: 9, newX: 9, newY: 9, "");


        public int oldX { get; set; }
        public int oldY { get; set; }
        public int newX { get; set; }
        public int newY { get; set; }
        public string piece { get; set; }



        public MoveMessage() 
        { 
            piece = ""; 
        }

        public MoveMessage(int oldX, int oldY, int newX, int newY, string piece)
        {
            this.oldX = oldX;
            this.oldY = oldY;
            this.newX = newX;
            this.newY = newY;
            this.piece = piece;
        }

        public string Serialize()
        {
            return $"{oldX},{oldY},{newX},{newY},{piece}";
        }

        public void Deserialize(string data)
        {
            var parts = data.Split(',');
            this.oldX = Int32.Parse(parts[0]);
            this.oldY = Int32.Parse(parts[1]);
            this.newX = Int32.Parse(parts[2]);
            this.newY = Int32.Parse(parts[3]);
            this.piece = parts[4];
        }

        public bool IsResignation()
        {

            return this.Serialize() == RESIGNATION.Serialize();
        }

        public bool IsDrawProposal()
        {

            return this.Serialize() == DRAWPROPOSAL.Serialize();
        }
        public bool IsDrawAccepted()
        {

            return this.Serialize() == DRAWACCEPTED.Serialize();
        }
    }
}
