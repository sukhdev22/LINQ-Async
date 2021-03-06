﻿// Description: Async extension methods for LINQ (Language Integrated Query).
// Website & Documentation: https://github.com/zzzprojects/LINQ-Async
// Forum: https://github.com/zzzprojects/LINQ-Async/issues
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Z.Linq
{
    public static partial class EnumerableAsync
    {
        public static Task<int> Max(this Task<List<int>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<int?> Max(this Task<List<int?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<long> Max(this Task<List<long>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<long?> Max(this Task<List<long?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<double> Max(this Task<List<double>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<double?> Max(this Task<List<double?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<float> Max(this Task<List<float>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<float?> Max(this Task<List<float?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal> Max(this Task<List<decimal>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal?> Max(this Task<List<decimal?>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<TSource> Max<TSource>(this Task<List<TSource>> source, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, Enumerable.Max, cancellationToken);
        }

        public static Task<int> Max<TSource>(this Task<List<TSource>> source, Func<TSource, int> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<int?> Max<TSource>(this Task<List<TSource>> source, Func<TSource, int?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<long> Max<TSource>(this Task<List<TSource>> source, Func<TSource, long> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<long?> Max<TSource>(this Task<List<TSource>> source, Func<TSource, long?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<float> Max<TSource>(this Task<List<TSource>> source, Func<TSource, float> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<float?> Max<TSource>(this Task<List<TSource>> source, Func<TSource, float?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<double> Max<TSource>(this Task<List<TSource>> source, Func<TSource, double> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<double?> Max<TSource>(this Task<List<TSource>> source, Func<TSource, double?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal> Max<TSource>(this Task<List<TSource>> source, Func<TSource, decimal> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<decimal?> Max<TSource>(this Task<List<TSource>> source, Func<TSource, decimal?> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }

        public static Task<TResult> Max<TSource, TResult>(this Task<List<TSource>> source, Func<TSource, TResult> selector, CancellationToken cancellationToken = default(CancellationToken))
        {
            return Task.Factory.FromTaskEnumerable(source, selector, Enumerable.Max, cancellationToken);
        }
    }
}