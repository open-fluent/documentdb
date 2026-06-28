// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

namespace Fluent.DocumentDb;

public interface IDocumentSession : IUnitOfWork
{
    IDocumentStore Documents { get; }
}
