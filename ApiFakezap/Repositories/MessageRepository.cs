using ApiFakezap.Models;

namespace ApiFakezap.Repositories
{
    public class MessageRepository : IMessageReposiroty
    {
        public IList<Message> Messages = new List<Message>
        {
            new Message("Olar", "Anonimo1",DateTime.Now.AddMinutes(-10)),
            new Message("Olar", "Anonimo2",DateTime.Now.AddMinutes(-8)),
            new Message("Como vai vc?", "Anonimo1",DateTime.Now.AddMinutes(-5)),
        };
        public bool AddMessage(Message msg)
        {
            Messages.Add(msg);
            return true;
        }

        public IEnumerable<Message> GetMessages()
        {
            return Messages;
        }
    }
}
