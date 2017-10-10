using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class NotEqualOperator : IFilterOperator
    {
        public FilterExpression Filter { get; } = Expression.NotEqual;
    }
}
