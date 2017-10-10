using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class GreaterOperator : IFilterOperator
    {
        public FilterExpression Filter { get; } = Expression.GreaterThan;
    }
}
