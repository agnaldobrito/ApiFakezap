using ApiFakezap.Models;

namespace ApiFakezap.Repositories
{
    public interface IMessageReposiroty
    {
        bool AddMessage(Message msg);
        IEnumerable<Message> GetMessages();
    }
}
