using ApiFakezap.Models;
using ApiFakezap.Repositories;

namespace ApiFakezap.Subscription
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class ChatSubscription
    {
        private readonly IChatRepository _repo;
        public ChatSubscription(IChatRepository repo)
        {
            _repo = repo;
        }

        //[Subscribe]
        //public Message ListenChat([EventMessage] Message message) => message;

        [Subscribe]
        public Message ListenChat([Topic] string idChat,[EventMessage] Message message) => message;
    }
}
