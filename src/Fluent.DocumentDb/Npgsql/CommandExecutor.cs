// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using Npgsql;

namespace Fluent.DocumentDb.Npgsql;

/// <summary>
/// Executes commands against DocumentDB using Npgsql.
/// </summary>
public sealed class CommandExecutor(NpgsqlConnection connection)
{
    /// <summary>
    /// Executes a query and returns the results as a list of JSON strings.
    /// </summary>
    /// <param name="sql">The SQL query to execute.</param>
    /// <param name="parameters">Optional query parameters.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A list of JSON strings representing the query results.</returns>
    public async Task<IReadOnlyList<string>> ExecuteQueryAsync(
        string sql,
        IEnumerable<NpgsqlParameter>? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrWhiteSpace(sql))
        {
            throw new ArgumentException("SQL query cannot be null or empty.", nameof(sql));
        }

        using var command = new NpgsqlCommand(sql, connection);

        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
        }

        await using var reader = await command.ExecuteReaderAsync(cancellationToken);

        var results = new List<string>();

        while (await reader.ReadAsync(cancellationToken))
        {
            results.Add(reader.GetString(0)); // Assumes JSON is returned in the first column
        }

        return results;
    }

    /// <summary>
    /// Executes a non-query command (e.g., INSERT, UPDATE, DELETE).
    /// </summary>
    /// <param name="sql">The SQL command to execute.</param>
    /// <param name="parameters">Optional command parameters.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The number of rows affected.</returns>
    public async Task<int> ExecuteNonQueryAsync(
        string sql,
        IEnumerable<NpgsqlParameter>? parameters = null,
        CancellationToken cancellationToken = default
    )
    {
        if (string.IsNullOrWhiteSpace(sql))
        {
            throw new ArgumentException("SQL command cannot be null or empty.", nameof(sql));
        }

        using var command = new NpgsqlCommand(sql, connection);

        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
        }

        return await command.ExecuteNonQueryAsync(cancellationToken);
    }
}
