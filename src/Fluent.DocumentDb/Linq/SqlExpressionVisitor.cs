// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and Fluent DocumentDB Contributors.
// All Rights Reserved.

using System.Linq.Expressions;

namespace Fluent.DocumentDb.Linq;

internal sealed class SqlExpressionVisitor
{
    public string VisitExpression(Expression expression)
    {
        // Example: Handle Where clause
        if (expression is MethodCallExpression methodCall && methodCall.Method.Name == "Where")
        {
            var lambda = (LambdaExpression)((UnaryExpression)methodCall.Arguments[1]).Operand;
            var condition = VisitLambda(lambda);

            return $"SELECT * FROM documents WHERE {condition}";
        }

        throw new NotSupportedException($"Expression type '{expression.GetType()}' is not supported.");
    }

    private string VisitLambda(LambdaExpression lambda)
    {
        // Simplified: Translate lambda expression into SQL condition
        if (lambda.Body is BinaryExpression binaryExpression)
        {
            var left = binaryExpression.Left.ToString();
            var right = binaryExpression.Right.ToString();
            var @operator = binaryExpression.NodeType switch
            {
                ExpressionType.Equal => "=",
                ExpressionType.GreaterThan => ">",
                ExpressionType.LessThan => "<",
                _ => throw new NotSupportedException(
                    $"Operator '{binaryExpression.NodeType}' is not supported."
                ),
            };

            return $"{left} {@operator} {right}";
        }

        throw new NotSupportedException("Only binary expressions are supported.");
    }
}
