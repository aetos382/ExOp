using System;
using System.Linq.Expressions;

using Xunit;

namespace ExOp.UnitTests.BinaryExpressions
{
    public class AddTest
    {
        [Fact]
        public void AddInt()
        {
            Expression<Func<int>> expression = () => 3 + 2;

            var actual = ExpressionOptimizer.Default.Optimize(expression);

            Assert.Equal(5, ((ConstantExpression)actual).Value);
        }
    }
}
