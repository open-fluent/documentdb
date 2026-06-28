# Fluent.DocumentDb

<div class="hero hero-graphic">
  <div class="hero-layout">
    <div class="hero-copy">
      <p class="hero-kicker">Enterprise document workloads on PostgreSQL</p>
      <h1 class="display-2 fw-bold">Document flexibility. PostgreSQL confidence.</h1>
      <p class="lead">
        Fluent.DocumentDb is the .NET layer for organizations that want modern document workloads
        without surrendering security, governance, scale, or operational control.
      </p>
      <p class="hero-cta">
        <a class="btn btn-primary btn-lg me-2" href="articles/getting-started.md">Get Started</a>
        <a class="btn btn-outline-primary btn-lg me-2" href="articles/enterprise-readiness.md">Enterprise Readiness</a>
        <a class="btn btn-outline-primary btn-lg" href="api/index.md">API Reference</a>
      </p>
      <div class="trust-row" aria-label="Enterprise capability highlights">
        <span>PostgreSQL-backed</span>
        <span>MongoDB-compatible direction</span>
        <span>JSONB/BSON-aware</span>
        <span>Cloud & on-premises</span>
      </div>
    </div><div class="hero-visual" aria-label="Fluent.DocumentDb architecture overview">
      <img class="hero-visual-image" src="images/home-architecture.svg" alt="Architecture diagram: .NET application, Fluent.DocumentDb, DocumentDB gateway, and PostgreSQL foundation">
    </div>
  </div>
</div>

<div class="proof-strip" aria-label="DocumentDB-inspired positioning">
  <div>
    <strong>Document + SQL</strong>
    <span>document model over PostgreSQL foundations</span>
  </div>
  <div>
    <strong>Native .NET integration</strong>
    <span>DI, async APIs, typed contracts</span>
  </div>
  <div>
    <strong>Enterprise control</strong>
    <span>security, governance, operations</span>
  </div>
</div>

## Built for serious .NET systems

<div class="row feature-row">
  <div class="col-12 col-md-4">
    <div class="feature-card">
      <h3>Trusted data foundation</h3>
      <p>Use PostgreSQL's proven operational model, security ecosystem, indexing, backup, observability, and compliance posture as the base for document workloads.</p>
    </div>
  </div>
  <div class="col-12 col-md-4">
    <div class="feature-card">
      <h3>Enterprise .NET surface</h3>
      <p>Keep application code clean with strongly typed documents, async APIs, dependency injection, testable contracts, and configuration that fits modern ASP.NET Core services.</p>
    </div>
  </div>
  <div class="col-12 col-md-4">
    <div class="feature-card">
      <h3>No lock-in architecture</h3>
      <p>Build on open-source DocumentDB and PostgreSQL instead of coupling strategic workloads to a single closed database platform or one cloud vendor.</p>
    </div>
  </div>
</div>

<div class="section-heading">
  <p class="section-kicker">Capabilities</p>
  <h2>Core building blocks for document workloads</h2>
  <p>Inspired by the DocumentDB platform story: document flexibility, PostgreSQL operations, and enterprise deployment paths — exposed through a focused .NET surface.</p>
</div>

<div class="capability-grid">
  <a class="capability-card" href="articles/what-is-documentdb.md">
    <span class="capability-icon">◆</span>
    <h3>Document + SQL</h3>
    <p>Use document-shaped persistence while keeping PostgreSQL as the trusted data foundation.</p>
  </a>
  <a class="capability-card" href="articles/jsonb-in-postgresql.md">
    <span class="capability-icon">⬡</span>
    <h3>JSONB/BSON aware</h3>
    <p>Understand how JSONB, BSON, indexing, and document storage relate in PostgreSQL-backed systems.</p>
  </a>
  <a class="capability-card" href="articles/document-store.md">
    <span class="capability-icon">λ</span>
    <h3>Typed .NET APIs</h3>
    <p>Work with small, async-first abstractions that fit ASP.NET Core and worker services.</p>
  </a>
  <a class="capability-card" href="articles/enterprise-readiness.md">
    <span class="capability-icon">◈</span>
    <h3>Security posture</h3>
    <p>Keep secrets, roles, transport security, and payload logging visible in the architecture.</p>
  </a>
  <a class="capability-card" href="articles/postgresql-foundation.md">
    <span class="capability-icon">⬢</span>
    <h3>Operations model</h3>
    <p>Align document workloads with PostgreSQL monitoring, backup, restore, and capacity practices.</p>
  </a>
  <a class="capability-card" href="articles/event-store.md">
    <span class="capability-icon">↗</span>
    <h3>Event-ready path</h3>
    <p>Shape future event-store and projection scenarios on a consistent document foundation.</p>
  </a>
</div>

<div class="enterprise-panel">
  <div>
    <p class="section-kicker">Enterprise promise</p>
    <h2>Document flexibility without giving up governance</h2>
    <p>
      Fluent.DocumentDb is shaped for teams that need schema flexibility, fast product iteration,
      and a database foundation that enterprise platform teams can operate, monitor, secure, and scale.
    </p>
  </div>
  <div class="enterprise-list">
    <span>Security-first configuration</span>
    <span>Cloud-native hosting path</span>
    <span>PostgreSQL operations model</span>
    <span>Testable application contracts</span>
  </div>
</div>

<div class="deployment-panel">
  <div class="section-heading section-heading-left">
    <p class="section-kicker">Deployment path</p>
    <h2>From local evaluation to governed enterprise platforms</h2>
    <p>DocumentDB highlights local Docker, Kubernetes operator, hybrid, and multi-cloud directions. Fluent.DocumentDb keeps the .NET integration explicit so teams can adopt that platform path deliberately.</p>
  </div>
  <div class="deployment-steps">
    <div class="deployment-step">
      <span>01</span>
      <h3>Local proof of concept</h3>
      <p>Evaluate the API surface, document model, and integration boundaries in a developer environment.</p>
    </div>
    <div class="deployment-step">
      <span>02</span>
      <h3>Platform validation</h3>
      <p>Review secrets, TLS, roles, network isolation, backup, restore, and observability with platform teams.</p>
    </div>
    <div class="deployment-step">
      <span>03</span>
      <h3>Scaled operations</h3>
      <p>Model indexes, partitions, retention, capacity, and failure modes before production workloads.</p>
    </div>
  </div>
</div>

## Core concepts

<div class="row concept-row">
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/getting-started.md">
      <h3>Getting Started</h3>
      <p>Install the packages and wire Fluent.DocumentDb into a .NET application.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/why-documentdb.md">
      <h3>Why DocumentDB</h3>
      <p>Understand the PostgreSQL-backed document database promise.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/what-is-documentdb.md">
      <h3>What is DocumentDB?</h3>
      <p>Learn what the new open-source DocumentDB engine adds to PostgreSQL.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/postgresql-foundation.md">
      <h3>How it works on PostgreSQL</h3>
      <p>See how extensions, BSON, indexing, and the gateway fit together.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/jsonb-in-postgresql.md">
      <h3>JSONB in PostgreSQL</h3>
      <p>Understand PostgreSQL JSON and JSONB before choosing a document strategy.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/enterprise-readiness.md">
      <h3>Enterprise Readiness</h3>
      <p>Security, scalability, operations, and governance concerns for large teams.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/packages.md">
      <h3>Packages</h3>
      <p>Choose the core library or dependency injection extensions.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/document-store.md">
      <h3>Document Store</h3>
      <p>Work with typed documents through a small persistence contract.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/event-store.md">
      <h3>Event Store</h3>
      <p>Append and read stream events for event-sourced features.</p>
    </a>
  </div>
  <div class="col-12 col-md-6 col-lg-4">
    <a class="concept-card" href="articles/configuration.md">
      <h3>Configuration</h3>
      <p>Connection strings, partition keys, DI registration, and runtime shape.</p>
    </a>
  </div>
</div>

## About

<p class="about-line">
  Fluent.DocumentDb is created in Poland by <a href="https://lepo.co/">Leszek Pomianowski</a>
  and the open-source community. MIT licensed and hosted at
  <a href="https://github.com/open-fluent/documentdb">open-fluent/documentdb</a>.
</p>
