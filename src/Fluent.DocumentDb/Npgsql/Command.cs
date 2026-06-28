// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using System.Text;
using Npgsql;

namespace Fluent.DocumentDb.Npgsql;

internal class Command
{
    public NpgsqlCommand Compile(NpgsqlConnection? connection, NpgsqlTransaction? transaction)
    {
        // StringBuilder commandText = new();
        //
        // string compiledCommand = commandText.ToString();
        //
        // List<NpgsqlParameter> parameters = [];
        //
        // NpgsqlCommand command = new(compiledCommand, connection, transaction) { Parameters = parameters };
        //
        // return command;

        throw new NotImplementedException();
    }
}
