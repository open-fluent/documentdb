# CQRS and Event Sourcing

Fluent.DocumentDb is being shaped for systems where document persistence, event history, and read models can work together without leaking database details into application code.

## Event Sourcing path

Event Sourcing stores important business changes as immutable facts. Instead of only saving the latest state, an application can append events such as `OrderSubmitted`, `CustomerVerified`, or `PolicyChanged` and rebuild state from that history.

For enterprise teams this is useful when auditability, traceability, and process reconstruction matter. The `IEventStore` abstraction is the starting point for this direction: append events to a stream, read them back, and keep the application boundary testable.

## CQRS read models

CQRS separates write models from read models. Commands protect business rules and consistency. Queries can use dedicated projections optimized for screens, reports, search, or integration workloads.

Document databases are a natural fit for read models because projections often evolve faster than core transactional rules. PostgreSQL-backed document storage gives teams flexibility while still keeping operational governance, indexing, backup, monitoring, and deployment discipline.

## Practical guidance

- Keep command-side invariants explicit in application code.
- Treat events as durable business facts, not technical log entries.
- Design read models around real queries and access patterns.
- Rebuild projections as a planned operational capability.
- Keep event schemas versioned and review them like public contracts.
- Do not introduce Event Sourcing or CQRS just for architecture fashion; use them where auditability, workflow complexity, or query separation justify the cost.

> Fluent.DocumentDb is still early-stage. CQRS and Event Sourcing support should be treated as a design direction and integration surface, not yet as a production guarantee.
