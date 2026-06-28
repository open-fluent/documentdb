// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using Fluent.DocumentDb.Configuration;

namespace Fluent.DocumentDb.EventStore;

public class EventStore(IDocumentSession session, IMetadataContainer metadata) : IEventStore
{
    /// <inheritdoc />
    public async Task AppendEventAsync<TEvent>(
        string streamId,
        TEvent @event,
        CancellationToken cancellationToken = default
    )
        where TEvent : class
    {
        await Task.CompletedTask;

        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<IEvent>> ReadStreamAsync(
        string streamId,
        CancellationToken cancellationToken = default
    )
    {
        await Task.CompletedTask;

        throw new NotImplementedException();
    }
}
