using ApiFakezap.Models;
using ApiFakezap.Repositories;

namespace ApiFakezap.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class ChatQuery
    {
        private readonly IMessageReposiroty _repo;
        public ChatQuery(IMessageReposiroty repo)
        {
            _repo = repo;
        }
        [GraphQLDescription("Retorna o chat")]
        public IEnumerable<Message> GetChat()
        {
            IEnumerable<Message> messages = _repo.GetMessages();
            return messages;
        }
    }
}
