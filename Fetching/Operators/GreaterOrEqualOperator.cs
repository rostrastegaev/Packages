using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class GreaterOrEqualOperator : IFilterOperator
    {
        public FilterExpression Filter { get; } = Expression.GreaterThanOrEqual;
    }
}
