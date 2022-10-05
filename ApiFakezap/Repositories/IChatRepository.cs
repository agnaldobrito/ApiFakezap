using ApiFakezap.Models;

namespace ApiFakezap.Repositories
{
    public interface IChatRepository
    {
        bool AddMessage(string idChat, Message msg);
        IEnumerable<Message> GetMessages(string idChat);
    }
}
