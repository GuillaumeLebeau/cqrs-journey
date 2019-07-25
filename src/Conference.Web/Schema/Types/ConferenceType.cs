using GraphQL.Types;

namespace Conference.Web.Schema.Types
{
    public class ConferenceType : ObjectGraphType<Models.Conference>
    {
        public ConferenceType()
        {
            Field(o => o.Code);
            Field(o => o.Name);
            Field(o => o.Description);
        }
    }
}