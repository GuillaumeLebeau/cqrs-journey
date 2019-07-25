using Conference.Web.Models;
using GraphQL.Types;

namespace Conference.Web.Schema.Types
{
    public class OrderType : InputObjectGraphType<Order>
    {
        public OrderType()
        {
            Field(_ => _.Id, type: typeof(IdGraphType)).Name("id");
            Field(_ => _.ConferenceId, type: typeof(IdGraphType)).Name("conferenceId");
            Field(_ => _.ConferenceCode).Name("conferenceCode");
            Field(_ => _.ConferenceName).Name("conferenceName");
            Field(_ => _.Items, type: typeof(ListGraphType<OrderItemType>)).Name("items");
            Field(_ => _.Total).Name("total");
        }
    }

    public class OrderItemType : InputObjectGraphType<OrderItem>
    {
        public OrderItemType()
        {
            Field(_ => _.SeatTypeId, type: typeof(IdGraphType)).Name("seatTypeId");
            Field(_ => _.SeatTypeDescription).Name("seatTypeDescription");
            Field(_ => _.Price).Name("price");
            Field(_ => _.Quantity).Name("quantity");
        }
    }
}