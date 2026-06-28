# Documentation

Fluent.DocumentDb is a .NET library for building applications on top of [DocumentDB](https://github.com/documentdb/documentdb), an open-source document database built on PostgreSQL.

The promise is enterprise-focused: keep the operational strengths of PostgreSQL, use a document model familiar from MongoDB and Azure Cosmos DB, and expose it through a small .NET API that is simple to configure, easy to test, and ready for secure cloud-native or on-premises systems.

<div class="promise-grid">
  <div class="promise-card">
    <h3>Secure by design</h3>
    <p>Keep connection strings, partition keys, and database access explicit so platform teams can apply governance and least privilege.</p>
  </div>
  <div class="promise-card">
    <h3>Scalable by architecture</h3>
    <p>Build around intentional document boundaries, indexing strategies, async APIs, and PostgreSQL-backed operational discipline.</p>
  </div>
  <div class="promise-card">
    <h3>Enterprise .NET ready</h3>
    <p>Code against small interfaces such as <code>IDocumentStore</code> and <code>IEventStore</code>, with dependency injection and testable abstractions.</p>
  </div>
</div>

## Start here

- [Getting Started](getting-started.md) — install the packages and wire up the first service.
- [Why DocumentDB](why-documentdb.md) — understand why PostgreSQL-backed documents are compelling.
- [What is DocumentDB?](what-is-documentdb.md) — learn what the new open-source engine provides.
- [How DocumentDB works on PostgreSQL](postgresql-foundation.md) — understand the PostgreSQL extension and gateway model.
- [JSONB in PostgreSQL](jsonb-in-postgresql.md) — learn the core JSON/JSONB storage concepts.
- [Enterprise readiness](enterprise-readiness.md) — security, scalability, operations, and governance guidance.
- [Document Store](document-store.md) — the typed document persistence contract.
- [Event Store](event-store.md) — the stream/event abstraction being shaped by the library.
- [Configuration](configuration.md) — connection strings, partition keys, and DI registration.

> Fluent.DocumentDb is in early development. The public API is being designed around compatibility, performance, and a small developer-friendly surface area.
