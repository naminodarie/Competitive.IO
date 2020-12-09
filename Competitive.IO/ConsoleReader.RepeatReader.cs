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
        public T[] Select<T>(Func<ConsoleReader, T> factory)
        {
            var arr = new T[count];
            for (var i = 0; i < count; i++)
                arr[i] = factory(cr);
            return arr;
        }
        public T[] Select<T>(Func<ConsoleReader, int, T> factory)
        {
            var arr = new T[count];
            for (var i = 0; i < count; i++)
                arr[i] = factory(cr, i);
            return arr;
        }
        public string[] Line()
        {
            var arr = new string[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Line();
            return arr;
        }
        public string[] String()
        {
            var arr = new string[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.String();
            return arr;
        }
        public string[] Ascii()
        {
            var arr = new string[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Ascii();
            return arr;
        }
        public int[] Int()
        {
            var arr = new int[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Int();
            return arr;
        }
        public int[] Int0()
        {
            var arr = new int[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Int0();
            return arr;
        }
        public long[] Long()
        {
            var arr = new long[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Long();
            return arr;
        }
        public long[] Long0()
        {
            var arr = new long[count];
            for (var i = 0; i < count; i++)
                arr[i] = cr.Long0();
            return arr;
        }
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
        public static implicit operator double[](RepeatReader rr) => rr.Double();
    }
}
