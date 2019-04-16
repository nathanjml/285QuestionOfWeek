using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassExample
{
    public static class Extensions
    {
        public static (IEnumerable<T>, IEnumerable<T>) Partition<T>(this IEnumerable<T> obj, Func<T, bool> criterion)
        {
            //TODO: fix this. What goes here? Hint: use Linq.
        }
    }
}
