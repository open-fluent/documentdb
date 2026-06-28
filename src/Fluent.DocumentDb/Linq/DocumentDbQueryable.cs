// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using System.Linq;
using System.Linq.Expressions;

namespace Fluent.DocumentDb.Linq;

/// <summary>
/// Represents a LINQ-enabled queryable document collection.
/// </summary>
public sealed class DocumentDbQueryable<T>(DocumentDbQueryProvider provider, Expression expression)
    : IQueryable<T>
{
    public Type ElementType => typeof(T);

    public Expression Expression => expression;

    public IQueryProvider Provider => provider;

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)provider.Execute(expression)!).GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
