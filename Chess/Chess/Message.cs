public class Message
{
    public int oldX {get; set;}
    public int oldY { get; set;}
    public int newX { get; set;}
    public int newY { get; set;}
    public string piece { get; set; }

    public Message(int oldX, int oldY, int newX, int newY, string piece)
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

    public static Message Deserialize(string data)
    {
        var parts = data.Split(',');
        return new Message ( Int32.Parse(parts[0]), Int32.Parse(parts[1]), 
                              Int32.Parse(parts[2]),  Int32.Parse(parts[3]),
                              parts[4]);
    }
}
