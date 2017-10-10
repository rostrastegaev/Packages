using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class LessOrEqualOperator : IFilterOperator
    {
        public FilterExpression Filter { get; } = Expression.LessThanOrEqual;
    }
}
