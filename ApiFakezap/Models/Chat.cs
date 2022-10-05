namespace ApiFakezap.Models
{
    public class Chat
    {
        public string Id { get; set; }
        public IList<Message> messageList { get; set; }

        public Chat(string idChat, IList<Message> messages)
        {
                Id= idChat;
                messageList = messages;
        }
    }
}
