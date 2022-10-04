namespace ApiFakezap.Models
{
    public class Message
    {
        public string Text { get; }
        public string Sender { get; }
        public DateTime Timestamp { get; }
        public bool ReadedMsg { get; }

        public Message(string text, string sender, DateTime timestamp, bool readedMsg = false)
        {
            Text = text;
            Sender = sender;
            Timestamp = timestamp;
            ReadedMsg = readedMsg;
        }
    }
}
