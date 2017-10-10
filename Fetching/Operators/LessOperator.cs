using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class LessOperator : IFilterOperator
    {
        public FilterExpression Filter { get; } = Expression.LessThan;
    }
}
