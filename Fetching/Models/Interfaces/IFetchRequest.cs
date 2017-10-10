using System.Collections.Generic;

namespace Fetching.Models
{
    public interface IFetchRequest
    {
        int Page { get; }
        int PageSize { get; }
        IEnumerable<IFilterParam> GetFilterParams();
        IEnumerable<IOrderParam> GetOrderParams();
        IEnumerable<ISearchParam> GetSearchParams();
    }
}
