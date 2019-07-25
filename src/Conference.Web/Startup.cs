using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Web.Models;
using Conference.Web.Schema;
using Conference.Web.Schema.Mutations;
using Conference.Web.Schema.Queries;
using Conference.Web.Schema.Types;
using GraphQL;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Conference.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            
            services.AddSingleton<IChat, Chat>();
            
            services.AddSingleton<ChatQuery>();
            services.AddSingleton<ConferenceQuery>();
            services.AddSingleton<RootQuery>();
            
            services.AddSingleton<ChatMutation>();
            services.AddSingleton<RegistrationMutation>();
            services.AddSingleton<RootMutation>();
            
            services.AddSingleton<MessageType>();
            services.AddSingleton<MessageFromType>();
            services.AddSingleton<MessageInputType>();
            services.AddSingleton<ConferenceType>();
            services.AddSingleton<OrderType>();
            services.AddSingleton<OrderItemType>();
            
            services.AddSingleton<ISchema, MainSchema>();
            
            // Adds GraphQL with HTTP transport
            services.AddGraphQLHttp();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseGraphQLHttp<ISchema>(new GraphQLHttpOptions());
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = "/ui/playground"
            });
        }
    }
}
