# Getting Started

## Installation

Install the core package:

```powershell
dotnet add package Fluent.DocumentDb
```

For ASP.NET Core applications and worker services using `Microsoft.Extensions.DependencyInjection`, also install the DI package:

```powershell
dotnet add package Fluent.DocumentDb.DependencyInjection
```

## Configure services

Register Fluent.DocumentDb during application startup:

```csharp
using Fluent.DocumentDb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDocumentDbEventStore(options =>
{
    options.ConnectionString = builder.Configuration.GetConnectionString("DocumentDb");
    options.EventsPartitionKey = "streamId";
    options.StreamsPartitionKey = "streamId";
});
```

The API is intentionally small: configuration should be readable, explicit, and easy to override in tests.

## Model a document

Documents can be ordinary C# records or classes:

```csharp
public sealed record CustomerDocument(
    string Id,
    string Name,
    string Email,
    DateTimeOffset CreatedAt);
```

## Depend on contracts

Application code should depend on abstractions instead of a concrete PostgreSQL/Npgsql implementation:

```csharp
using Fluent.DocumentDb;

public sealed class CustomerProfileService(IDocumentStore documents)
{
    public Task<CustomerDocument?> FindAsync(string id, CancellationToken cancellationToken) =>
        documents.GetAsync<CustomerDocument>(id, cancellationToken: cancellationToken);
}
```

This keeps the calling code small and makes unit tests straightforward.

## Next steps

- [Why DocumentDB](why-documentdb.md)
- [Document Store](document-store.md)
- [Event Store](event-store.md)
- [Configuration](configuration.md)

> The library is currently under active development. Treat the examples as the intended public surface and follow the API reference for the exact package version you install.
