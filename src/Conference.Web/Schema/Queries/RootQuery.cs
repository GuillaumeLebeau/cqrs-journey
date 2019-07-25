using GraphQL.Types;

namespace Conference.Web.Schema.Queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Name = "Query";
            Field<ChatQuery>("chats", resolve: ctx => new {});
            Field<ConferenceQuery>("conferences", resolve: ctx => new {});
        }
    }
}
