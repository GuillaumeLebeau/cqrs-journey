using Conference.Web.Models;
using Conference.Web.Schema.Types;
using GraphQL.Types;

namespace Conference.Web.Schema.Mutations
{
    public class ChatMutation : ObjectGraphType<object>
    {
        public ChatMutation(IChat chat)
        {
            Field<MessageType>("addMessage",
                arguments: new QueryArguments(
                    new QueryArgument<MessageInputType> {Name = "message"}
                ),
                resolve: context =>
                {
                    var receivedMessage = context.GetArgument<ReceivedMessage>("message");
                    var message = chat.AddMessage(receivedMessage);
                    return message;
                });
        }
    }
    
    public class MessageInputType : InputObjectGraphType
    {
        public MessageInputType()
        {
            Field<StringGraphType>("fromId");
            Field<StringGraphType>("content");
            Field<DateGraphType>("sentAt");
        }
    }
}
