using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class EqualOperator : IFilterOperator
    {
        public FilterExpression Filter { get; } = Expression.Equal;
    }
}
