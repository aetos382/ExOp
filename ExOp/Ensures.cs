using System;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

namespace ExOp
{
    public static class Ensures
    {
        [AssertionMethod]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [NotNull]
        public static T ArgumentNotNull<T>(
            [NotNull]
            [AssertionCondition(AssertionConditionType.IS_NOT_NULL)]
            T value,

            [NotNull]
            [InvokerParameterName]
            string argumentName)
            where T : class
        {
            if (value is null)
            {
                throw new ArgumentNullException(argumentName);
            }

            return value;
        }

        [AssertionMethod]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [NotNull]
        public static T ArgumentNotNull<T>(
            [NotNull]
            [AssertionCondition(AssertionConditionType.IS_NOT_NULL)]
            T value)
            where T : class
        {
            return ArgumentNotNull(value, nameof(value));
        }
    }
}
