// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

namespace Fluent.DocumentDb.Npgsql;

public class NpgsqlDocumentSession(IConnectionProvider connectionProvider) : IDocumentSession
{
    private readonly NpgsqlDocumentStore documents = new(connectionProvider);

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await documents.CommitAsync().ConfigureAwait(false);
    }

    public IDocumentStore Documents => documents;
}
