using ApiFakezap.Models;

namespace ApiFakezap.Repositories
{
    public class ChatRepository : IChatRepository
    {
        public IList<Chat> Chats = new List<Chat>
        {
            new Chat("1", new List<Message>()),
            new Chat("2", new List<Message>()),
            new Chat("3", new List<Message>()),

        };
        
        public bool AddMessage(string idChat, Message msg)
        {
            Chat? chat = Chats.FirstOrDefault(c => c.Id == idChat);

            if (chat == null) return false;

            chat.messageList.Add(msg);

            return true;
        }

        public IEnumerable<Message> GetMessages(string idChat)
        {
            Chat? chat = Chats.FirstOrDefault(c => c.Id == idChat);

            if (chat == null) return new List<Message>();

            return chat.messageList ;

        }
    }
}
