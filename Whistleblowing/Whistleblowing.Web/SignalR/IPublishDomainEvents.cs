using System.Threading.Tasks;

namespace Whistleblowing.Web.SignalR
{
    public interface IPublishDomainEvents
    {
        Task Publish(object evnt);
    }
}
