// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using Fluent.DocumentDb.DocumentStore;

// ReSharper disable once CheckNamespace
namespace Fluent.DocumentDb;

public interface IDocumentStore
{
    Task<T?> GetAsync<T>(
        string id,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;

    Task UpsertAsync<T>(
        string id,
        T document,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;

    Task DeleteAsync<T>(
        string id,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;

    Task PatchAsync<T>(
        string id,
        IReadOnlyList<PatchOperation> patchOperations,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;
}
