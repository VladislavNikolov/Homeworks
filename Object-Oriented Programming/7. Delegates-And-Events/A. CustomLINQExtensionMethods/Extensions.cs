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

        public static TSource Max<TSource, TSelector>(
            this IEnumerable<TSource> collection, Func<TSource, 
            TSelector> predicate)
            where TSource : IComparable<TSource>
        {
            var collectionArray = collection.ToArray();
            var maxElement = collectionArray[0];

            foreach (var element in collection)
            {
                if (element.CompareTo(maxElement) > 0)
                {
                    maxElement = element;
                }
            }

            return maxElement;
        }
    }
}
