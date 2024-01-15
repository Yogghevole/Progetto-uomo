using Microsoft.Extensions.DependencyInjection;
using Whistleblowing.Services.Shared;
using Whistleblowing.Web.SignalR;

namespace Whistleblowing.Web
{
    public class Container
    {
        public static void RegisterTypes(IServiceCollection container)
        {
            // Registration of all the database services you have
            container.AddScoped<SharedService>();

            // Registration of SignalR events
            container.AddScoped<IPublishDomainEvents, SignalrPublishDomainEvents>();
        }
    }
}
