using System;

namespace DataAccess
{
    public static class ExceptionsHelper
    {
        public static void ArgumentNullException(string name)
        {
            throw new ArgumentNullException($"Argument {name} is null");
        }
    }
}
