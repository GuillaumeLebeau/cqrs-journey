using System.Collections.Concurrent;
using System.Collections.Generic;
using Conference.Web.Models;
using Conference.Web.Schema.Types;
using GraphQL.Types;

namespace Conference.Web.Schema.Mutations
{
    public class RegistrationMutation : ObjectGraphType<object>
    {
        private static readonly IDictionary<string, Order> _orders = new ConcurrentDictionary<string, Order>();
        
        public RegistrationMutation()
        {
            Field<BooleanGraphType>("startRegistration",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> {Name="conferenceCode"},
                    new QueryArgument<OrderType> {Name = "content"}
                ),
                resolve: context =>
                {
                    var conferenceCode = context.GetArgument<string>("conferenceCode");
                    var content = context.GetArgument<Order>("content");
                    
                    if (!_orders.TryAdd(conferenceCode, content))
                        _orders[conferenceCode] = content;

                    return true;
                });
        }
    }
}
