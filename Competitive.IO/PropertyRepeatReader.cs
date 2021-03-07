﻿// <auto-generated>
// This code was generated by T4 template. Do not change this code.
// </auto-generated>
using System;
using System.Diagnostics;

namespace Kzrnm.Competitive.IO
{
    using static DebuggerBrowsableState;
    /// <summary>
    /// Calls <see cref="PropertyConsoleReader"/> several times
    /// </summary>
    public struct PropertyRepeatReader
    {
        internal readonly PropertyConsoleReader cr;
        internal readonly int count;
        internal PropertyRepeatReader(PropertyConsoleReader cr, int count)
        {
            this.cr = cr; this.count = count;
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Line"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public string[] Line
        {
            get
            {
                var arr = new string[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Line;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.String"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public string[] String
        {
            get
            {
                var arr = new string[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.String;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Ascii"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public string[] Ascii
        {
            get
            {
                var arr = new string[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Ascii;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Int"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public int[] Int
        {
            get
            {
                var arr = new int[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Int;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Int0"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public int[] Int0
        {
            get
            {
                var arr = new int[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Int0;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.UInt"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public uint[] UInt
        {
            get
            {
                var arr = new uint[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.UInt;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.UInt0"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public uint[] UInt0
        {
            get
            {
                var arr = new uint[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.UInt0;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Long"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public long[] Long
        {
            get
            {
                var arr = new long[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Long;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Long0"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public long[] Long0
        {
            get
            {
                var arr = new long[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Long0;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.ULong"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public ulong[] ULong
        {
            get
            {
                var arr = new ulong[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.ULong;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.ULong0"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public ulong[] ULong0
        {
            get
            {
                var arr = new ulong[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.ULong0;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Double"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public double[] Double
        {
            get
            {
                var arr = new double[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Double;
                return arr;
            }
        }
        /// <summary>
        /// Read <see cref="PropertyConsoleReader.Decimal"/> array
        /// </summary>
        [DebuggerBrowsable(Never)]
        public decimal[] Decimal
        {
            get
            {
                var arr = new decimal[count];
                for (var i = 0; i < count; i++)
                    arr[i] = cr.Decimal;
                return arr;
            }
        }

        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.Ascii"/>
        /// </summary>
        public static implicit operator string[](PropertyRepeatReader rr) => rr.Ascii;
        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.Int"/>
        /// </summary>
        public static implicit operator int[](PropertyRepeatReader rr) => rr.Int;
        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.UInt"/>
        /// </summary>
        public static implicit operator uint[](PropertyRepeatReader rr) => rr.UInt;
        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.Long"/>
        /// </summary>
        public static implicit operator long[](PropertyRepeatReader rr) => rr.Long;
        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.ULong"/>
        /// </summary>
        public static implicit operator ulong[](PropertyRepeatReader rr) => rr.ULong;
        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.Double"/>
        /// </summary>
        public static implicit operator double[](PropertyRepeatReader rr) => rr.Double;
        /// <summary>
        /// implicit call <see cref="PropertyRepeatReader.Decimal"/>
        /// </summary>
        public static implicit operator decimal[](PropertyRepeatReader rr) => rr.Decimal;
    }
    /// <summary>
    /// Defines extension
    /// </summary>
    public static class PRepeatEx
    {
        /// <summary>
        /// Get <see cref="PropertyRepeatReader"/>
        /// </summary>
        public static PropertyRepeatReader Repeat(this PropertyConsoleReader cr, int count) => new PropertyRepeatReader(cr, count);
    }
}
