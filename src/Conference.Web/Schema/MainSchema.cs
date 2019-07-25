using Conference.Web.Models;
using Conference.Web.Schema.Mutations;
using Conference.Web.Schema.Queries;
using GraphQL;

namespace Conference.Web.Schema
{
    public class MainSchema : GraphQL.Types.Schema
    {
        public MainSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<RootQuery>();
            Mutation = resolver.Resolve<RootMutation>();
        }
    }
}