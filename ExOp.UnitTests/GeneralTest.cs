using System;

using Xunit;

namespace ExOp.UnitTests
{
    public class GeneralTest
    {
        [Fact]
        public void DefaultはNotNull()
        {
            Assert.NotNull(ExpressionOptimizer.Default);
        }

        [Fact]
        public void 引数にNullを渡したらArgumentNullExceptionが発生する()
        {
            Assert.Throws<ArgumentNullException>(() =>
                ExpressionOptimizer.Default.Optimize(null));
        }
    }
}
