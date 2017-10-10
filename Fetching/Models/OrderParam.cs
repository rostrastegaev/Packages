using Fetching.Operators;

namespace Fetching.Models
{
    public class OrderParam : IOrderParam
    {
        public string Property { get; }
        public OrderOperator Operator { get; }
    }
}
