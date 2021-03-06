﻿#if !NETSTANDARD1_3
using System;

namespace Kzrnm.Competitive.IO
{
    /// <summary>
    /// <see cref="RepeatReader"/>
    /// </summary>
    public static class RepeatReaderSelectArray
    {
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static (T1[], T2[]) SelectArray<T1, T2>(this RepeatReader r,
            Func<ConsoleReader, (T1, T2)> factory)
        {
            var arr1 = new T1[r.count];
            var arr2 = new T2[r.count];
            for (var i = 0; i < r.count; i++)
                (arr1[i], arr2[i]) = factory(r.cr);
            return (arr1, arr2);
        }
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static (T1[], T2[]) SelectArray<T1, T2>(this RepeatReader r,
            Func<ConsoleReader, int, (T1, T2)> factory)
        {
            var arr1 = new T1[r.count];
            var arr2 = new T2[r.count];
            for (var i = 0; i < r.count; i++)
                (arr1[i], arr2[i]) = factory(r.cr, i);
            return (arr1, arr2);
        }

        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static (T1[], T2[], T3[]) SelectArray<T1, T2, T3>(this RepeatReader r,
            Func<ConsoleReader, (T1, T2, T3)> factory)
        {
            var arr1 = new T1[r.count];
            var arr2 = new T2[r.count];
            var arr3 = new T3[r.count];
            for (var i = 0; i < r.count; i++)
                (arr1[i], arr2[i], arr3[i]) = factory(r.cr);
            return (arr1, arr2, arr3);
        }
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static (T1[], T2[], T3[]) SelectArray<T1, T2, T3>(this RepeatReader r,
            Func<ConsoleReader, int, (T1, T2, T3)> factory)
        {
            var arr1 = new T1[r.count];
            var arr2 = new T2[r.count];
            var arr3 = new T3[r.count];
            for (var i = 0; i < r.count; i++)
                (arr1[i], arr2[i], arr3[i]) = factory(r.cr, i);
            return (arr1, arr2, arr3);
        }

        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static (T1[], T2[], T3[], T4[]) SelectArray<T1, T2, T3, T4>(this RepeatReader r,
            Func<ConsoleReader, (T1, T2, T3, T4)> factory)
        {
            var arr1 = new T1[r.count];
            var arr2 = new T2[r.count];
            var arr3 = new T3[r.count];
            var arr4 = new T4[r.count];
            for (var i = 0; i < r.count; i++)
                (arr1[i], arr2[i], arr3[i], arr4[i]) = factory(r.cr);
            return (arr1, arr2, arr3, arr4);
        }
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static (T1[], T2[], T3[], T4[]) SelectArray<T1, T2, T3, T4>(this RepeatReader r,
            Func<ConsoleReader, int, (T1, T2, T3, T4)> factory)
        {
            var arr1 = new T1[r.count];
            var arr2 = new T2[r.count];
            var arr3 = new T3[r.count];
            var arr4 = new T4[r.count];
            for (var i = 0; i < r.count; i++)
                (arr1[i], arr2[i], arr3[i], arr4[i]) = factory(r.cr, i);
            return (arr1, arr2, arr3, arr4);
        }
    }
}
#endif
