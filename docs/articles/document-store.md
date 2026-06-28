# Document Store

`IDocumentStore` is the small contract for typed document persistence.

```csharp
public interface IDocumentStore
{
    Task<T?> GetAsync<T>(string id, PartitionKey? partitionKey = default, CancellationToken cancellationToken = default)
        where T : class;

    Task UpsertAsync<T>(string id, T document, PartitionKey? partitionKey = default, CancellationToken cancellationToken = default)
        where T : class;

    Task DeleteAsync<T>(string id, PartitionKey? partitionKey = default, CancellationToken cancellationToken = default)
        where T : class;

    Task PatchAsync<T>(string id, IReadOnlyList<PatchOperation> patchOperations, PartitionKey? partitionKey = default, CancellationToken cancellationToken = default)
        where T : class;
}
```

## Design goals

- **Typed documents** — your application works with C# records/classes, not loose dictionaries.
- **Async by default** — every operation accepts a `CancellationToken` for server and worker workloads.
- **Partition aware** — `PartitionKey` is part of the API surface without making simple cases noisy.
- **Testable** — application services can mock or fake `IDocumentStore` directly.

## Example usage

```csharp
public sealed record OrderDocument(string Id, string CustomerId, decimal Total);

public sealed class OrderDocuments(IDocumentStore documents)
{
    public Task SaveAsync(OrderDocument order, CancellationToken cancellationToken) =>
        documents.UpsertAsync(
            order.Id,
            order,
            new PartitionKey(order.CustomerId),
            cancellationToken);

    public Task<OrderDocument?> FindAsync(string orderId, string customerId, CancellationToken cancellationToken) =>
        documents.GetAsync<OrderDocument>(
            orderId,
            new PartitionKey(customerId),
            cancellationToken);
}
```

The concrete Npgsql-backed implementation is being developed around this contract.
