using System.Linq;
using Conference.Web.Models;
using Conference.Web.Schema.Types;
using GraphQL.Types;

namespace Conference.Web.Schema.Queries
{
    public class ChatQuery: ObjectGraphType
    {
        public ChatQuery(IChat chat)
        {
            Field<ListGraphType<MessageType>>("messages", resolve: context => chat.AllMessages.Take(100));
        }
    }
}
