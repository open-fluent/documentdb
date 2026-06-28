# JSONB in PostgreSQL

PostgreSQL supports two native JSON storage types: `json` and `jsonb`. Understanding the difference is important before designing a document workload on PostgreSQL or adopting a DocumentDB-based architecture.

## `json` vs `jsonb`

Both types accept JSON input, but they store it differently:

- **`json`** stores an exact copy of the input text. It preserves whitespace, key order, and duplicate keys. Processing functions need to parse the text again when they run.
- **`jsonb`** stores data in a decomposed binary format. It is slightly slower to write because PostgreSQL must convert the input, but it is significantly faster to process and supports indexing.

The PostgreSQL documentation recommends that most applications prefer `jsonb` unless they have specialized requirements around preserving the exact textual representation of JSON.

## What JSONB gives you

JSONB is useful because it lets relational and document-shaped data coexist in one PostgreSQL database.

Typical capabilities include:

- validating that stored values are valid JSON,
- querying nested properties,
- testing containment with operators such as `@>`,
- checking for key existence,
- updating specific paths with functions such as `jsonb_set`,
- indexing JSONB columns for better query performance,
- combining SQL joins and filters with document fields.

Example JSONB value:

```sql
select '{
  "customerId": "C-1000",
  "status": "Active",
  "risk": { "tier": "Low", "score": 12 },
  "tags": ["enterprise", "regulated"]
}'::jsonb;
```

Example containment query:

```sql
select '{"status":"Active","region":"EU"}'::jsonb @> '{"status":"Active"}'::jsonb;
```

## Enterprise strengths

JSONB is attractive in enterprise systems when teams need controlled flexibility:

- product teams can evolve document shape faster than a fully normalized relational model,
- platform teams still operate PostgreSQL with familiar governance,
- analytics and reporting can combine relational columns with document fields,
- security, backup, monitoring, and deployment practices stay close to the PostgreSQL platform.

## Enterprise trade-offs

JSONB is powerful, but it does not remove data-modeling responsibilities.

Important trade-offs:

- `jsonb` does not preserve object key order or duplicate keys;
- document updates still participate in PostgreSQL row-level locking;
- large documents can increase write contention;
- unindexed JSONB queries can become expensive;
- flexible structure can become difficult to govern without naming conventions and validation rules.

For large organizations, the right question is not “relational or document?”. The better question is: which parts of the domain need relational consistency, and which parts benefit from document flexibility?

## How this relates to DocumentDB

JSONB is a PostgreSQL-native capability. DocumentDB builds a broader document database experience on PostgreSQL, including BSON support and MongoDB-compatible direction.

Fluent.DocumentDb is intended to give .NET teams a small, testable integration surface over that broader DocumentDB/PostgreSQL model.

## Sources

- [PostgreSQL JSON types](https://www.postgresql.org/docs/current/datatype-json.html)
- [PostgreSQL JSON functions and operators](https://www.postgresql.org/docs/current/functions-json.html)
