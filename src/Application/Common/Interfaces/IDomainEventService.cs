using APIService.Domain.Common;
using System.Threading.Tasks;

namespace APIService.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
