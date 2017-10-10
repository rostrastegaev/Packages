using Fetching.Operators;

namespace Fetching.Models
{
    public interface IFilterParam
    {
        string Property { get; }
        string Value { get; }
        FilterOperator Operator { get; }
    }
}
