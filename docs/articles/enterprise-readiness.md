# Enterprise readiness

Fluent.DocumentDb is shaped for organizations that evaluate libraries through more than syntax. Enterprise adoption depends on security, scalability, operational fit, governance, and clear integration boundaries.

The library is still early, so this page describes the intended enterprise posture and the architectural principles behind it.

## Security by design

Document workloads often carry customer data, workflow state, or integration payloads. Treat the database integration as a security boundary.

Recommended practices:

- keep connection strings in secret stores, not source control;
- use TLS and network restrictions appropriate to the hosting model;
- apply least-privilege database roles;
- avoid logging document payloads unless explicitly sanitized;
- keep partition keys and identifiers free from sensitive raw values;
- review serialization behavior for PII and regulated fields.

Fluent.DocumentDb keeps configuration explicit so security choices stay visible in application composition rather than hidden in static helpers.

## Scalability and performance

Document databases scale when the document model, indexes, and access patterns are designed together.

For enterprise systems:

- keep document boundaries aligned with transactional use cases;
- avoid unbounded reads and unindexed filters;
- design partition keys intentionally;
- monitor query latency and storage growth;
- treat JSONB/BSON indexes as part of the application contract;
- test representative data volumes before production rollout.

The goal is not to pretend that document storage removes database design. The goal is to provide a clean .NET surface over a database foundation that can be engineered properly.

## Operations and governance

PostgreSQL-backed document workloads are attractive because they fit existing platform concerns:

- backup and restore procedures,
- database observability,
- patching and runtime lifecycle,
- deployment pipelines,
- disaster recovery planning,
- audit and compliance reviews,
- cloud, Kubernetes, hybrid, and on-premises options.

Fluent.DocumentDb should sit cleanly inside that operating model: dependency injection, explicit options, small interfaces, and testable boundaries.

## Application architecture fit

Use Fluent.DocumentDb where document-shaped persistence improves the domain model:

- aggregate snapshots,
- workflow state,
- integration envelopes,
- read models,
- event metadata,
- flexible customer or tenant configuration,
- records that evolve faster than relational schema changes.

Avoid using a document store as a dumping ground. Enterprise systems need consistent naming, validation, lifecycle ownership, retention rules, and migration plans.

## Adoption checklist

Before a production rollout, verify:

- [ ] the DocumentDB/PostgreSQL hosting model is approved by platform/security teams;
- [ ] connection strings are managed through a secret store;
- [ ] TLS and network boundaries are documented;
- [ ] backup and restore have been tested;
- [ ] indexes match known query patterns;
- [ ] document size and retention expectations are understood;
- [ ] logging avoids leaking document payloads;
- [ ] load tests cover realistic data volume;
- [ ] failure modes are represented in application tests;
- [ ] ownership of schema/document evolution is clear.

## Honest status

Fluent.DocumentDb is an early-stage library. The enterprise story is the design direction: a small, idiomatic .NET API over an open PostgreSQL-backed document database platform. Treat current versions as a foundation for evaluation and contribution, not as a blanket production guarantee.
