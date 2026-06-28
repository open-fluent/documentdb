// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using Fluent.DocumentDb.DocumentStore;

namespace Fluent.DocumentDb.Npgsql;

public class NpgsqlDocumentStore(IConnectionProvider connectionProvider) : IDocumentStore
{
    public virtual Task<T?> GetAsync<T>(
        string id,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class
    {
        throw new NotImplementedException();
    }

    public virtual Task UpsertAsync<T>(
        string id,
        T document,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class
    {
        throw new NotImplementedException();
    }

    public virtual Task DeleteAsync<T>(
        string id,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class
    {
        throw new NotImplementedException();
    }

    public virtual Task PatchAsync<T>(
        string id,
        IReadOnlyList<PatchOperation> patchOperations,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class
    {
        throw new NotImplementedException();
    }

    public virtual Task CommitAsync()
    {
        throw new NotImplementedException();
    }
}
