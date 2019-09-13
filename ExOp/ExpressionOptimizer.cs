using System;
using System.Linq.Expressions;

using JetBrains.Annotations;

namespace ExOp
{
    public class ExpressionOptimizer
    {
        [NotNull]
        public Expression Optimize(
            [NotNull] Expression expression)
        {
            expression = Ensures.ArgumentNotNull(expression, nameof(expression));

            return Expression.Constant(1);
        }

        [NotNull]
        public static readonly ExpressionOptimizer Default = new ExpressionOptimizer();
    }
}
