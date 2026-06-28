# What is the new DocumentDB?

DocumentDB is an open-source document database engine built on PostgreSQL. It is designed for teams that want the developer experience of a document database while keeping the control, governance, and operational maturity of the PostgreSQL ecosystem.

At a high level, DocumentDB brings MongoDB-compatible document workloads to PostgreSQL. It introduces native BSON-oriented capabilities, document CRUD APIs, rich indexing, and a gateway layer that can translate MongoDB-style operations into PostgreSQL-backed execution.

## Why this matters for enterprises

Large organizations rarely evaluate a database only by developer ergonomics. They also ask whether the platform can be governed, secured, backed up, observed, deployed consistently, and operated by existing platform teams. DocumentDB is interesting because it aligns document flexibility with a database foundation that many enterprises already trust.

<div class="promise-grid">
  <div class="promise-card">
    <h3>Open foundation</h3>
    <p>DocumentDB is open source and MIT licensed, reducing strategic vendor lock-in for document workloads.</p>
  </div>
  <div class="promise-card">
    <h3>PostgreSQL confidence</h3>
    <p>It builds on PostgreSQL's mature storage, indexing, security, backup, and operations ecosystem.</p>
  </div>
  <div class="promise-card">
    <h3>Document model</h3>
    <p>It targets document-oriented workloads with BSON support and MongoDB-compatible direction.</p>
  </div>
</div>

## Core building blocks

The upstream DocumentDB project describes three cooperating components:

- **`pg_documentdb_core`** — a PostgreSQL extension that introduces BSON data type support and operations inside PostgreSQL.
- **`pg_documentdb`** — the public API surface that provides document CRUD functionality.
- **`pg_documentdb_gw`** — a gateway/protocol translation layer that converts MongoDB API calls into PostgreSQL queries.

This combination is what makes DocumentDB different from simply storing JSON in a normal PostgreSQL table. PostgreSQL JSON/JSONB is powerful, but DocumentDB aims to provide a more complete document database engine and compatibility story on top of that foundation.

## What Fluent.DocumentDb adds

Fluent.DocumentDb is the .NET developer layer over this direction. Its goal is to make the DocumentDB/PostgreSQL model feel natural in enterprise .NET systems:

- use dependency injection instead of scattered connection setup,
- expose small interfaces that are easy to mock in tests,
- keep document operations async-first,
- keep serialization predictable with .NET types,
- leave room for event-store and projection patterns as the library matures.

> Fluent.DocumentDb is in early development. The documentation describes the intended enterprise direction and public surface, while implementation details continue to evolve.

## Learn more

- [DocumentDB project website](https://documentdb.io/)
- [DocumentDB GitHub repository](https://github.com/documentdb/documentdb)
- [PostgreSQL JSON types](https://www.postgresql.org/docs/current/datatype-json.html)
