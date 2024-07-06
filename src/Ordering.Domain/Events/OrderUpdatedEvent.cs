
namespace Ordering.Domain.Events;
public record BasketCheckoutEvent(Order order) : IDomainEvent;
