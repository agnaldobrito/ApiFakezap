using ApiFakezap.Models;
using ApiFakezap.Repositories;

namespace ApiFakezap.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class ChatQuery
    {
        private readonly IChatRepository _repo;
        public ChatQuery(IChatRepository repo)
        {
            _repo = repo;
        }
        [GraphQLDescription("Retorna o chat")]
        public IEnumerable<Message> GetChat(string idChat)
        {
            IEnumerable<Message> messages = _repo.GetMessages(idChat);
            return messages;
        }
    }
}
