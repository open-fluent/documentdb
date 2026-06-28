// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using System.Linq;
using System.Linq.Expressions;
using Fluent.DocumentDb.Npgsql;

namespace Fluent.DocumentDb.Linq;

/// <summary>
/// Provides LINQ query translation for DocumentDB.
/// </summary>
public sealed class DocumentDbQueryProvider(CommandExecutor executor) : IQueryProvider
{
    public IQueryable CreateQuery(Expression expression)
    {
        var elementType = GetElementType(expression.Type);
        return (IQueryable)
            Activator.CreateInstance(
                typeof(DocumentDbQueryable<>).MakeGenericType(elementType),
                this,
                expression
            )!;
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new DocumentDbQueryable<TElement>(this, expression);
    }

    public object? Execute(Expression expression)
    {
        var sql = TranslateExpressionToSql(expression);

        return executor.ExecuteQueryAsync(sql).Result; // Blocking call for simplicity
    }

    public TResult Execute<TResult>(Expression expression)
    {
        var sql = TranslateExpressionToSql(expression);

        return (TResult)executor.ExecuteQueryAsync(sql).Result!;
    }

    private string TranslateExpressionToSql(Expression expression)
    {
        // Translate LINQ expression to SQL query
        var translator = new LinqToSqlTranslator();
        return translator.Translate(expression);
    }

    private static Type GetElementType(Type type)
    {
        // Extracts the element type from an IEnumerable or IQueryable type
        if (type.IsGenericType && typeof(IEnumerable<>).IsAssignableFrom(type.GetGenericTypeDefinition()))
        {
            return type.GetGenericArguments()[0];
        }

        return type;
    }
}
