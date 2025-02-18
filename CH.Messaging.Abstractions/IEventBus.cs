using System.Threading;
using System.Threading.Tasks;

namespace CH.Messaging.Abstractions
{
    public interface IEventBus
    {
        Task PublishAsync(IRequest request, CancellationToken cancellationToken = default);
    }
}
