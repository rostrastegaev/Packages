using Fetching.Operators;

namespace Fetching.Models
{
    public class FilterParam : IFilterParam
    {
        public string Property { get; set; }
        public string Value { get; set; }
        public FilterOperator Operator { get; set; }
    }
}
