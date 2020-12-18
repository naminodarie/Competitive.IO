﻿// <auto-generated>
// This code was generated by T4 template. Do not change this code.
// </auto-generated>
using System;

namespace Kzrnm.Competitive.IO
{
    public struct RepeatReader
    {
        readonly ConsoleReader cr;
        readonly int count;
        internal RepeatReader(ConsoleReader cr, int count)
        {
            this.cr = cr; this.count = count;
        }
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public T[] Select<T>(Func<ConsoleReader, T> factory)
        {
            var arr = new T[count];
            for (var i = 0; i < count; i++)
                arr[i] = factory(cr);
            return arr;
        }
        /// <summary>
        /// Repeat <paramref name="factory"/>()
        /// </summary>
        public T[] Select<T>(Func<ConsoleReader, int, T> factory)
        {
            var arr = new T[count];
            for (var i = 0; i < count; i++)
                arr[i] = factory(cr, i);
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Line"/> array
        /// </summary>
        public string[] Line()
        {
            var arr = new string[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Line();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.String"/> array
        /// </summary>
        public string[] String()
        {
            var arr = new string[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.String();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Ascii"/> array
        /// </summary>
        public string[] Ascii()
        {
            var arr = new string[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Ascii();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Int"/> array
        /// </summary>
        public int[] Int()
        {
            var arr = new int[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Int();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Int0"/> array
        /// </summary>
        public int[] Int0()
        {
            var arr = new int[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Int0();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Long"/> array
        /// </summary>
        public long[] Long()
        {
            var arr = new long[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Long();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Long0"/> array
        /// </summary>
        public long[] Long0()
        {
            var arr = new long[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Long0();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.ULong"/> array
        /// </summary>
        public ulong[] ULong()
        {
            var arr = new ulong[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.ULong();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.ULong0"/> array
        /// </summary>
        public ulong[] ULong0()
        {
            var arr = new ulong[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.ULong0();
            return arr;
        }
        /// <summary>
        /// Read <see cref="ConsoleReader.Double"/> array
        /// </summary>
        public double[] Double()
        {
            var arr = new double[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Double();
            return arr;
        }

        public static implicit operator string[](RepeatReader rr) => rr.Ascii();
        public static implicit operator int[](RepeatReader rr) => rr.Int();
        public static implicit operator long[](RepeatReader rr) => rr.Long();
        public static implicit operator ulong[](RepeatReader rr) => rr.ULong();
        public static implicit operator double[](RepeatReader rr) => rr.Double();
    }
    public static class RepeatEx
    {
        /// <summary>
        /// Get <see cref="RepeatReader"/>
        /// </summary>
        public static RepeatReader Repeat(this ConsoleReader cr, int count) => new RepeatReader(cr, count);
    }
}
