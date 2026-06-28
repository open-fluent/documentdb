# Fluent.DocumentDb

[Created in Poland by Leszek Pomianowski](https://lepo.co/) and the open-source community.

Fluent.DocumentDb is a .NET library for building applications on top of [DocumentDB](https://github.com/documentdb/documentdb), an open-source document database built on PostgreSQL.

DocumentDB started at Microsoft as a PostgreSQL extension for document workloads and is now hosted by the Linux Foundation. It brings document database capabilities to the PostgreSQL ecosystem, with a focus on MongoDB API compatibility, portability, performance, and open governance.

The goal of Fluent.DocumentDb is to make DocumentDB feel natural in .NET applications: simple to configure, easy to test, and ready for modern cloud-native services.

## Why DocumentDB

DocumentDB is designed for teams that want a document database without giving up PostgreSQL.

- Built on PostgreSQL and its mature storage, indexing, query planning, and operational ecosystem
- Uses the document database model familiar from MongoDB and Azure Cosmos DB
- Targets compatibility with MongoDB drivers and tools
- Avoids vendor lock-in through an open-source, MIT-licensed engine
- Gives developers a practical path from NoSQL workloads to a PostgreSQL-backed platform
- Backed by a growing ecosystem that includes Microsoft, AWS, and the Linux Foundation community

PostgreSQL already has strong support for JSON and JSONB. DocumentDB builds on that foundation and turns PostgreSQL into a dedicated document database engine for modern applications.

## Packages

| Package | Description | NuGet |
|---------|-------------|-------|
| [Fluent.DocumentDb](src/Fluent.DocumentDb) | Core .NET library for working with PostgreSQL-backed DocumentDB | [![NuGet](https://img.shields.io/nuget/v/Fluent.DocumentDb.svg)](https://www.nuget.org/packages/Fluent.DocumentDb) |
| [Fluent.DocumentDb.DependencyInjection](src/Fluent.DocumentDb.DependencyInjection) | Dependency injection extensions for ASP.NET Core and worker services | [![NuGet](https://img.shields.io/nuget/v/Fluent.DocumentDb.DependencyInjection.svg)](https://www.nuget.org/packages/Fluent.DocumentDb.DependencyInjection) |

## Getting started

```powershell
dotnet add package Fluent.DocumentDb
```

For applications using `Microsoft.Extensions.DependencyInjection`:

```powershell
dotnet add package Fluent.DocumentDb.DependencyInjection
```

This project is in early development. The public API is being designed around compatibility, performance, and a small developer-friendly surface area.

## Learn more about DocumentDB

- [DocumentDB GitHub repository](https://github.com/documentdb/documentdb)
- [DocumentDB project website](https://documentdb.io/)
- [Linux Foundation welcomes DocumentDB](https://www.linuxfoundation.org/press/linux-foundation-welcomes-documentdb-to-advance-open-developer-first-nosql-innovation)
- [Microsoft: DocumentDB joins the Linux Foundation](https://opensource.microsoft.com/blog/2025/08/25/documentdb-joins-the-linux-foundation/)
- [AWS joins the DocumentDB project](https://aws.amazon.com/blogs/opensource/aws-joins-the-documentdb-project-to-build-interoperable-open-source-document-database-technology/)

## Building from source

Requires [.NET 10 SDK](https://dotnet.microsoft.com/download) or later.

```powershell
git clone https://github.com/open-fluent/documentdb.git
cd documentdb
dotnet build
dotnet test
```

## License

Fluent.DocumentDb is free and open source software licensed under the **MIT License**. You can use it in private and commercial projects.
