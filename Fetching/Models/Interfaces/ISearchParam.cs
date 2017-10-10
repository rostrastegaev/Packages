using System.Collections.Generic;

namespace Fetching.Models
{
    public interface ISearchParam
    {
        string Property { get; }
        string Value { get; }
        IEnumerable<ISearchParam> Split();
    }
}
