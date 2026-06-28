# Fluent.DocumentDb.DependencyInjection

Fluent.DocumentDb.DependencyInjection adds dependency injection integration for Fluent.DocumentDb applications.

Use this package when you want to wire DocumentDB access into ASP.NET Core, worker services, or any application built on `Microsoft.Extensions.DependencyInjection`.

## Why this package

- Keep DocumentDB configuration in the standard .NET dependency injection container
- Use a PostgreSQL-backed document database in cloud-native .NET services
- Build toward MongoDB-compatible workloads without giving up PostgreSQL operations
- Keep application startup and configuration simple

## Install

```powershell
dotnet add package Fluent.DocumentDb.DependencyInjection
```

You will also typically reference the core package:

```powershell
dotnet add package Fluent.DocumentDb
```

## Status

This package is in early development. It will provide the registration layer for applications using Fluent.DocumentDb with the standard .NET hosting and dependency injection model.

## Learn more

- [DocumentDB](https://github.com/documentdb/documentdb)
- [DocumentDB project website](https://documentdb.io/)
- [Linux Foundation welcomes DocumentDB](https://www.linuxfoundation.org/press/linux-foundation-welcomes-documentdb-to-advance-open-developer-first-nosql-innovation)
- [Microsoft: DocumentDB joins the Linux Foundation](https://opensource.microsoft.com/blog/2025/08/25/documentdb-joins-the-linux-foundation/)
- [AWS joins the DocumentDB project](https://aws.amazon.com/blogs/opensource/aws-joins-the-documentdb-project-to-build-interoperable-open-source-document-database-technology/)

## License

Fluent.DocumentDb.DependencyInjection is free and open source software licensed under the **MIT License**.
