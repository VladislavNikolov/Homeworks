namespace A.CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate)
            where TSelector : IComparable
        {
            TSelector result = predicate(collection.First());

            foreach (var element in collection)
            {
                if (result.CompareTo(predicate(element)) < 0)
                {
                    result = predicate(element);
                }
            }

            return result;
        }
    }
}
