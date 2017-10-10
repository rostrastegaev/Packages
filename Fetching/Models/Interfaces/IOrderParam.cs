using Fetching.Operators;

namespace Fetching.Models
{
    public interface IOrderParam
    {
        string Property { get; }
        OrderOperator Operator { get; }
    }
}
