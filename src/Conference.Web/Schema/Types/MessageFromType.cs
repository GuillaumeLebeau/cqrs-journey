using Conference.Web.Models;
using GraphQL.Types;

namespace Conference.Web.Schema.Types
{
    public class MessageFromType: ObjectGraphType<MessageFrom>
    {
        public MessageFromType()
        {
            Field(o => o.Id);
            Field(o => o.DisplayName);
        }
    }
}
