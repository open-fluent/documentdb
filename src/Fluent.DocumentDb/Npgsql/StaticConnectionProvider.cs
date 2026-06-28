// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

namespace Fluent.DocumentDb.Npgsql;

internal class StaticConnectionProvider(global::Npgsql.NpgsqlConnection connection) : IConnectionProvider
{
    public Task<global::Npgsql.NpgsqlConnection> GetConnectionAsync()
    {
        return Task.FromResult(connection);
    }
}
