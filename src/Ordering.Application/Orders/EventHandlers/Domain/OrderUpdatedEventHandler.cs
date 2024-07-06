using Ecart.Core.Services;

namespace Ordering.Application.Orders.EventHandlers.Domain;
public class OrderUpdatedEventHandler(IEventPublisher<OrderDto> eventPublisher,ILogger<OrderUpdatedEventHandler> logger)
    : INotificationHandler<BasketCheckoutEvent>
{
    public Task Handle(BasketCheckoutEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);
        return Task.CompletedTask;
    }
}
