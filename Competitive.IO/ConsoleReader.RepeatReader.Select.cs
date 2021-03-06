﻿using System;

namespace Kzrnm.Competitive.IO
{
    /// <summary>
    /// <see cref="RepeatReader"/>
    /// </summary>
    public static class RepeatReaderSelect
    {
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static T[] Select<T>(this RepeatReader r, Func<ConsoleReader, T> factory)
        {
            var arr = new T[r.count];
            for (var i = 0; i < r.count; i++)
                arr[i] = factory(r.cr);
            return arr;
        }
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public static T[] Select<T>(this RepeatReader r, Func<ConsoleReader, int, T> factory)
        {
            var arr = new T[r.count];
            for (var i = 0; i < r.count; i++)
                arr[i] = factory(r.cr, i);
            return arr;
        }
    }
}
