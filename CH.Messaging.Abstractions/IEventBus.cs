using System.Threading;
using System.Threading.Tasks;

namespace CH.Messaging.Abstractions
{
    public interface IEventBus
    {
        Task SendAsync(IRequest request, CancellationToken cancellationToken = default);
    }
}
