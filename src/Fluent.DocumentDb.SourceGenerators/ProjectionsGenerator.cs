// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

namespace Fluent.DocumentDb.SourceGenerators;

/// <summary>
/// A source generator injecting all needed C# polyfills at compile time.
/// </summary>
[Generator(LanguageNames.CSharp)]
public sealed partial class ProjectionsGenerator : IIncrementalGenerator
{
    /// <inheritdoc />
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        throw new NotImplementedException();
    }
}
