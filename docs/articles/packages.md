# Packages

Fluent.DocumentDb is split into focused packages so applications can reference only what they need.

| Package | Description | NuGet |
| --- | --- | --- |
| `Fluent.DocumentDb` | Core .NET abstractions and implementation surface for working with PostgreSQL-backed DocumentDB. | [NuGet](https://www.nuget.org/packages/Fluent.DocumentDb) |
| `Fluent.DocumentDb.DependencyInjection` | Dependency injection extensions for ASP.NET Core and worker services. | [NuGet](https://www.nuget.org/packages/Fluent.DocumentDb.DependencyInjection) |

## Recommended install

For application projects, install both packages:

```powershell
dotnet add package Fluent.DocumentDb
dotnet add package Fluent.DocumentDb.DependencyInjection
```

For library projects that only expose contracts or extension points, the core package is usually enough:

```powershell
dotnet add package Fluent.DocumentDb
```

## Version support

The repository targets modern .NET while keeping compatibility paths where useful:

- `Fluent.DocumentDb`: `net10.0`, `net8.0`, `netstandard2.0`
- `Fluent.DocumentDb.DependencyInjection`: `net10.0`, `net8.0`, `net481`, `netstandard2.0`

Use the API reference generated for your installed version when relying on exact signatures.
