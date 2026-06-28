// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using Fluent.DocumentDb.EventStore;

// ReSharper disable once CheckNamespace
namespace Fluent.DocumentDb;

public interface IEventStore
{
    Task AppendEventAsync<TEvent>(
        string streamId,
        TEvent @event,
        CancellationToken cancellationToken = default
    )
        where TEvent : class;

    Task<IEnumerable<IEvent>> ReadStreamAsync(string streamId, CancellationToken cancellationToken = default);
}
