using ApiFakezap.Models;

namespace ApiFakezap.Subscription
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class ChatSubscription
    {
        [Subscribe]
        public Message ListenChat([EventMessage] Message message) => message;
    }
}
