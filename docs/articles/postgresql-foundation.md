# How DocumentDB works on PostgreSQL

DocumentDB is not a separate closed database engine that happens to look like PostgreSQL. Its value proposition is that document database capabilities are built on PostgreSQL through extensions, BSON-aware storage, indexing, and a gateway layer.

For enterprise teams, that architecture matters. It means document workloads can be evaluated through familiar PostgreSQL concerns: security controls, operational tooling, backup strategies, monitoring, deployment topology, capacity planning, and compliance boundaries.

## Architecture in plain English

Think about the stack as four layers:

1. **PostgreSQL** provides the durable database foundation: storage, transactions, indexing primitives, query execution, authentication, roles, backup and recovery, replication patterns, and operational maturity.
2. **DocumentDB core extension** adds BSON support and document-oriented operations inside PostgreSQL.
3. **DocumentDB API layer** exposes document CRUD capabilities on that foundation.
4. **Gateway layer** translates MongoDB-compatible protocol/API interactions into PostgreSQL-backed operations.

Fluent.DocumentDb then sits on the application side as the .NET integration layer.

```text
.NET application
   |
   |  Fluent.DocumentDb abstractions
   v
DocumentDB API / gateway
   |
   |  document operations, BSON, indexes
   v
PostgreSQL extension layer
   |
   |  storage, transactions, security, observability
   v
PostgreSQL cluster
```

## Why PostgreSQL is a strong enterprise base

PostgreSQL is widely used for mission-critical workloads because it combines relational integrity, extensibility, indexing, mature operations, and a strong open-source ecosystem. DocumentDB uses that extensibility to bring document database behavior closer to the database platform enterprises already know how to run.

Key implications:

- **Security posture** — platform teams can reason about authentication, network boundaries, secrets, TLS, roles, and database access policies in a PostgreSQL-centered model.
- **Operational maturity** — backups, monitoring, migrations, disaster recovery, and capacity management can follow established database operations practices.
- **Scalability planning** — document workloads still require indexing, partitioning, query discipline, and capacity planning; PostgreSQL gives teams a known place to apply those practices.
- **Hybrid deployment** — DocumentDB can be evaluated for local, cloud, Kubernetes, and on-premises patterns instead of forcing one hosting model.

## JSONB and BSON are related but not the same

PostgreSQL has `json` and `jsonb` types. They are excellent for many application needs and are part of the PostgreSQL engine itself. DocumentDB goes further by introducing BSON-oriented capabilities and MongoDB-compatible document database behavior.

Use this mental model:

- **JSON/JSONB** — PostgreSQL-native data types for storing and querying JSON documents.
- **BSON** — binary document representation used by MongoDB-style document databases.
- **DocumentDB** — a document database engine built on PostgreSQL that adds BSON support, document APIs, indexing behavior, and gateway compatibility.
- **Fluent.DocumentDb** — a .NET library that makes the application integration easier and more idiomatic.

## Enterprise design guidance

For large systems, treat the document database as part of the architecture, not just a persistence detail:

- model document boundaries intentionally,
- keep documents reasonably sized to avoid excessive write contention,
- index fields that are used in filters and lookups,
- isolate secrets and connection strings through managed configuration,
- monitor latency, storage growth, index usage, and error rates,
- test migrations and backup/restore procedures before production rollout.

The result is not “schemaless chaos”. The enterprise sweet spot is controlled flexibility: document-shaped data where it helps product speed, with governance where the platform requires it.

## Sources

- [DocumentDB GitHub repository](https://github.com/documentdb/documentdb)
- [DocumentDB project website](https://documentdb.io/)
- [PostgreSQL JSON types](https://www.postgresql.org/docs/current/datatype-json.html)
