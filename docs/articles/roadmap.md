# Roadmap

Fluent.DocumentDb is in early development. The public API is being shaped around a small set of promises from the README:

- make DocumentDB feel natural in .NET applications,
- keep configuration simple,
- keep application code easy to test,
- support modern cloud-native services,
- preserve DocumentDB's portability and PostgreSQL foundation.

## Near-term focus

- Complete the Npgsql-backed `IDocumentStore` implementation.
- Finalize dependency injection registration and option validation.
- Expand event-store behavior around streams, metadata, and projections.
- Add practical samples for ASP.NET Core and worker services.
- Keep generated API documentation aligned with .NET 10 builds.

## Non-goals

- Hiding DocumentDB behind a large ORM-style abstraction.
- Locking applications to a vendor-specific cloud database.
- Adding framework-heavy patterns before the core persistence contracts are stable.

Follow development on [GitHub](https://github.com/open-fluent/documentdb).
