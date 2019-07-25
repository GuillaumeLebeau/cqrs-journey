using GraphQL.Types;

namespace Conference.Web.Schema.Mutations
{
    public class RootMutation : ObjectGraphType<object>
    {
        public RootMutation()
        {
            Field<ChatMutation>("chat", resolve: ctx => new { });
            Field<RegistrationMutation>("registration", resolve: ctx => new { });
        }
    }
}
