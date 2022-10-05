using ApiFakezap.Models;
using ApiFakezap.Repositories;
using ApiFakezap.Subscription;
using HotChocolate.Subscriptions;

namespace ApiFakezap.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class MessagesMutation
    {
        private readonly IChatRepository _repo;
        private ITopicEventSender _eventSender;

        public MessagesMutation(IChatRepository repo, ITopicEventSender eventsender)
        {
            _repo = repo;
            _eventSender = eventsender;
        }

        [GraphQLDescription("Envia mensagens")]
        public bool SendMessage(string text, string sender, string idChat)
        {
            Message message = new(text, sender, DateTime.Now);
            bool result = _repo.AddMessage(idChat, message);
            if (result == true)
            {
                //_eventSender.SendAsync(nameof(ChatSubscription.ListenChat), message).ConfigureAwait(false);
                _eventSender.SendAsync(idChat, message).ConfigureAwait(false);
            }

            return result;
        }
    }
}
