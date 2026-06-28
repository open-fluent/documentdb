// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

namespace Fluent.DocumentDb.Npgsql;

//internal static class Functions
//{
//    public const string CountQuery = "documentdb_api.count_query";
//}

/// <summary>
/// Enumeration of all DocumentDB functions.
/// </summary>
public enum Functions
{
    // CRUD Functions
    CreateDocument = 0,
    ReadDocument = 1,
    UpdateDocument = 2,
    DeleteDocument = 3,

    // Query Functions
    ExecuteQuery = 4,

    // Transaction Functions
    BeginTransaction = 5,
    CommitTransaction = 6,
    RollbackTransaction = 7,

    // Utility Functions
    CountDocuments = 8,
    GetDocumentMetadata = 9,
    ValidateDocument = 10,
}
