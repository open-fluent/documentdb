# Why DocumentDB

DocumentDB is designed for teams that want a document database without giving up PostgreSQL.

It started at Microsoft as a PostgreSQL extension for document workloads and is now hosted by the Linux Foundation. The project brings document database capabilities to the PostgreSQL ecosystem with a focus on MongoDB API compatibility, portability, performance, and open governance.

For enterprise teams, the strategic point is simple: document flexibility becomes easier to adopt when it sits on a database foundation that security, platform, and operations teams already understand.

## Why it matters

- **PostgreSQL ecosystem** — reuse mature storage, indexing, query planning, backups, observability, and operations knowledge.
- **Document model** — work with document-shaped data familiar from MongoDB and Azure Cosmos DB.
- **Open governance** — avoid vendor lock-in through an open-source, MIT-licensed engine.
- **Migration path** — give NoSQL workloads a practical route to a PostgreSQL-backed platform.
- **Growing ecosystem** — DocumentDB is backed by a community that includes Microsoft, AWS, and the Linux Foundation.
- **Enterprise control** — keep deployment, security, compliance, and data residency decisions closer to your own infrastructure strategy.

PostgreSQL already has strong JSON and JSONB support. DocumentDB builds on that foundation and turns PostgreSQL into a dedicated document database engine for modern applications.

## What changes for large organizations

DocumentDB is not only a developer convenience. It gives enterprise architecture teams a way to discuss document workloads using familiar platform language:

- where data is hosted,
- how access is controlled,
- how backups and disaster recovery work,
- how query performance is monitored,
- how indexing and capacity are governed,
- how the database fits cloud, hybrid, and on-premises strategies.

That is the gap Fluent.DocumentDb wants to close on the .NET side: document-oriented developer productivity with an integration surface that still feels accountable, explicit, and testable.

## Where Fluent.DocumentDb fits

Fluent.DocumentDb is the .NET layer over that promise. Its goal is not to hide DocumentDB, but to make it feel idiomatic in .NET applications:

- simple registration with dependency injection,
- strongly typed document access,
- async-first APIs,
- small contracts for testing,
- room for event-store and projection patterns as the library grows.

## Learn more

- [DocumentDB GitHub repository](https://github.com/documentdb/documentdb)
- [DocumentDB project website](https://documentdb.io/)
- [Linux Foundation welcomes DocumentDB](https://www.linuxfoundation.org/press/linux-foundation-welcomes-documentdb-to-advance-open-developer-first-nosql-innovation)
- [Microsoft: DocumentDB joins the Linux Foundation](https://opensource.microsoft.com/blog/2025/08/25/documentdb-joins-the-linux-foundation/)
- [AWS joins the DocumentDB project](https://aws.amazon.com/blogs/opensource/aws-joins-the-documentdb-project-to-build-interoperable-open-source-document-database-technology/)
