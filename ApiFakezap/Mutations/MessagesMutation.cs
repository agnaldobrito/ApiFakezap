using ApiFakezap.Models;
using ApiFakezap.Repositories;
using ApiFakezap.Subscription;
using HotChocolate.Subscriptions;

namespace ApiFakezap.Mutations
{
    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class MessagesMutation
    {
        private readonly IMessageReposiroty _repo;
        private ITopicEventSender _eventSender;

        public MessagesMutation(IMessageReposiroty repo, ITopicEventSender eventsender)
        {
            _repo = repo;
            _eventSender = eventsender;
        }

        [GraphQLDescription("Envia mensagens")]
        public bool SendMessage(string text, string sender, string? idChat)
        {
            Message message = new(text, sender, DateTime.Now);
            bool result = _repo.AddMessage(message);
            if (result == true)
            {
                _eventSender.SendAsync(nameof(ChatSubscription.ListenChat), message).ConfigureAwait(false);
            }

            return result;
        }
    }
}
