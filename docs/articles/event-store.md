# Event Store

`IEventStore` is the stream-oriented API surface for appending and reading events.

```csharp
public interface IEventStore
{
    Task AppendEventAsync<TEvent>(
        string streamId,
        TEvent @event,
        CancellationToken cancellationToken = default)
        where TEvent : class;

    Task<IEnumerable<IEvent>> ReadStreamAsync(
        string streamId,
        CancellationToken cancellationToken = default);
}
```

## What it is for

Use the event-store abstraction when a feature benefits from a stream of changes rather than only the latest document snapshot:

- append domain events to a stream,
- rebuild read models and projections,
- keep document state and event history close to PostgreSQL-backed infrastructure,
- test application logic against a small event-store contract.

## Example event

```csharp
public sealed record CustomerRegistered(
    string CustomerId,
    string Email,
    DateTimeOffset RegisteredAt);
```

## Example append

```csharp
public sealed class RegisterCustomerHandler(IEventStore events)
{
    public Task HandleAsync(string customerId, string email, CancellationToken cancellationToken)
    {
        var registered = new CustomerRegistered(customerId, email, DateTimeOffset.UtcNow);

        return events.AppendEventAsync(
            streamId: $"customer-{customerId}",
            @event: registered,
            cancellationToken);
    }
}
```

The event-store implementation is still evolving. The contract documents the intended shape: fluent enough for application code, explicit enough for operational behavior.
