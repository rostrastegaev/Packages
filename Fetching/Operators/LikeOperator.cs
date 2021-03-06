﻿using System;
using System.Linq.Expressions;

namespace Fetching.Operators
{
    public class LikeOperator : IFilterOperator
    {
        private FilterExpression _filter;
        public FilterExpression Filter { get; }

        public LikeOperator()
        {
            Func<string, string, bool> _filter = (str1, str2) => str1.Contains(str2);
            Filter = FilterWrapper;
        }

        private Expression FilterWrapper(Expression left, Expression right) =>
            _filter.Invoke(left, right);
    }
}
