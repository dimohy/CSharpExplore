using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

using System.Collections.Immutable;

namespace Benchmark;

[SimpleJob(RuntimeMoniker.Net80)]
[RPlotExporter]
[MemoryDiagnoser]
public class CSharp12
{
    [Params(10000)]
    public int Count;

    [Benchmark]
    public void CollectionExpressionsArray()
    {
        for (var i = 0; i < Count; i++)
        {
            int[] list = [1, 2, 3, 4, 5];
            list[0] = 1;
        }
    }

    [Benchmark]
    public void CollectionExpressionsSpan()
    {
        for (var i = 0; i < Count; i++)
        {
            Span<int> list = [1, 2, 3, 4, 5];
            list[0] = 1;
        }
    }

    [Benchmark]
    public void InlineArraysInt5()
    {
        for (var i = 0; i < Count; i++)
        {
            var block = new Block<int>();
            block[0] = 1;
            block[1] = 2;
            block[2] = 3;
            block[3] = 4;
            block[4] = 5;
        }
    }

    [System.Runtime.CompilerServices.InlineArray(5)]
    public struct Block<T>
    {
        private T _element0;
    }
}
