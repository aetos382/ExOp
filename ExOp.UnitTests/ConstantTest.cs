using System;
using System.Linq.Expressions;

using Xunit;

namespace ExOp.UnitTests
{
    public class ConstantTest
    {
        [Fact]
        public void Constantはそのまま()
        {
            var expression = Expression.Constant(1);

            var actual = ExpressionOptimizer.Default.Optimize(expression);

            Assert.Equal(1, ((ConstantExpression)actual).Value);
        }
    }
}
