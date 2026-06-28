// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using System.Linq.Expressions;

namespace Fluent.DocumentDb.Linq;

/// <summary>
/// Translates LINQ expressions into PostgreSQL-compatible SQL queries.
/// </summary>
public sealed class LinqToSqlTranslator
{
    public string Translate(Expression expression)
    {
        // Parse the expression tree and generate SQL
        var visitor = new SqlExpressionVisitor();
        return visitor.VisitExpression(expression);
    }
}
