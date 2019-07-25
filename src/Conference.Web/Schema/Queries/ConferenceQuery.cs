using System;
using Conference.Web.Schema.Types;
using GraphQL.Types;

namespace Conference.Web.Schema.Queries
{
    public class ConferenceQuery : ObjectGraphType
    {
        public ConferenceQuery()
        {
            Field<ConferenceType>(
                "conference",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> {Name = "code"}),
                resolve:
                context =>
                {
                    var code = context.GetArgument<string>("code");

//                    var repo = this.repositoryFactory();
//                    using (repo as IDisposable)
//                    {
//                        var conference = repo.Query<Conference>()
//                            .First(c => c.Code == code);
//
//                        var conferenceModel = new Models.Conference
//                        {
//                            Code = conference.Code,
//                            Name = conference.Name,
//                            Description = conference.Description
//                        };
//
//                        return conferenceModel;
//                    }                    
                    
                    return new Models.Conference
                    {
                        Code = code,
                        Name = "Name" + code,
                        Description = "Description" + code
                    };
                }
            );
        }
    }
}
