using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication
{
    public static class ListExtensions
    {
        public static void Remove<T>(this IList<T> list, Type type)
        {
            var instances = list.Where(x => x.GetType() == type).ToList();
            instances.ForEach(obj => list.Remove(obj));
        }
    }
}