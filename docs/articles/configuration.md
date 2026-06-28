# Configuration

The dependency injection package exposes `AddDocumentDbEventStore` for application startup.

```csharp
builder.Services.AddDocumentDbEventStore(options =>
{
    options.ConnectionString = builder.Configuration.GetConnectionString("DocumentDb");
    options.EventsPartitionKey = "streamId";
    options.StreamsPartitionKey = "streamId";
});
```

## Options

| Option | Purpose |
| --- | --- |
| `ConnectionString` | PostgreSQL/DocumentDB connection string used by the runtime implementation. |
| `EventsPartitionKey` | Partition key used for event documents. |
| `StreamsPartitionKey` | Partition key used for stream metadata documents. |

## Configuration source

Keep secrets in normal .NET configuration providers rather than hardcoding them:

```json
{
  "ConnectionStrings": {
    "DocumentDb": "Host=localhost;Port=5432;Database=app;Username=app;Password=change-me"
  }
}
```

For production, prefer environment variables, user secrets during local development, or a secret store supported by your hosting platform.

## Testing posture

Application services should depend on `IDocumentStore` or `IEventStore`, not directly on Npgsql-specific classes. That keeps tests lightweight and makes the implementation replaceable as the library evolves.
