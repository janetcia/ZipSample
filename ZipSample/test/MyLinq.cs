using System;
using System.Collections.Generic;

namespace ZipSample.test
{
    public static class MyLinq
    {
        public static IEnumerable<TSource> MyConcat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            var firstEnumerator = first.GetEnumerator();
            while (firstEnumerator.MoveNext())
            {
                yield return firstEnumerator.Current;
            }

            var secondEnumerator = second.GetEnumerator();
            while (secondEnumerator.MoveNext())
            {
                yield return secondEnumerator.Current;
            }
        }

        public static IEnumerable<TResult> MyZip<TSource1, TSource2, TResult>(this IEnumerable<TSource1> source1, IEnumerable<TSource2> source2, Func<TSource1, TSource2, TResult> predicate)
        {
            var firstEnumerator = source1.GetEnumerator();
            var secondEnumerator = source2.GetEnumerator();

            while (firstEnumerator.MoveNext() && secondEnumerator.MoveNext())
            {
                var girl = firstEnumerator.Current;
                var key = secondEnumerator.Current;
                yield return predicate(girl, key);
            }
        }

        public static IEnumerable<string> MyReverse(this IEnumerable<string> source)
        {
            return new Stack<string>(source);
        }
    }
}