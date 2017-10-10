using System.Linq.Expressions;

namespace Fetching.Operators
{
    public delegate Expression FilterExpression(Expression left, Expression right);
    public interface IFilterOperator
    {
        FilterExpression Filter { get; }
    }
}
