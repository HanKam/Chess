using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class RoomMessage : IMessage
    {
        public string roomName { get; set; }
        public Colour playerColour { get; set; }

        public RoomMessage() { }
        public RoomMessage(string roomName, Colour playerColour)
        {
            this.roomName = roomName;
            this.playerColour = playerColour;
        }
        public RoomMessage(string data)
        {
            this.Deserialize(data);
        }
        

        public string Serialize()
        {
            string colour = playerColour == Colour.White ? "W" : "B";
            return $"{roomName},{colour}";
        }

        public void Deserialize(string data)
        {
            var parts = data.Split(',');
            this.roomName = parts[0];
            this.playerColour = parts[1] == "W" ? Colour.White : Colour.Black;
        }
    }
}
