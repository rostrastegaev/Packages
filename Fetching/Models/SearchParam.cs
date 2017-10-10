using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Fetching.Models
{
    public class SearchParam : ISearchParam
    {
        private static readonly Regex _regex = new Regex(@"(\w+)");

        public string Property { get; set; }
        public string Value { get; set; }

        public IEnumerable<ISearchParam> Split()
        {
            var matches = _regex.Matches(Value);
            foreach (Match match in matches)
            {
                var param = new SearchParam
                {
                    Property = Property,
                    Value = match.Value
                };
                yield return param;
            }
        }
    }
}
