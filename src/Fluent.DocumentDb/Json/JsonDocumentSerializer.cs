// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using System.Text.Json;

namespace Fluent.DocumentDb.Json;

/// <summary>
/// Provides serialization and deserialization for JSON documents.
/// </summary>
public class JsonDocumentSerializer
{
    public virtual string Serialize<T>(T document)
    {
        return JsonSerializer.Serialize(document);
    }

    public virtual T? Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json);
    }
}
