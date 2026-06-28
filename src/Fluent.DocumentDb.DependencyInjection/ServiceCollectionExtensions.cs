// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using Microsoft.Extensions.DependencyInjection;

// ReSharper disable once CheckNamespace
namespace Fluent.DocumentDb;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDocumentDbEventStore(
        this IServiceCollection services,
        Action<DocumentDbEventStoreOptions> configure
    )
    {
        return services;
    }
}
