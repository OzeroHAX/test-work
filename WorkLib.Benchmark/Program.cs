using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using WorkLib;

public class TriangleAnalyzerBenchmark
{
    [Benchmark]
    public void BenchmarkDetermineTriangleType()
    {
        var result1 = TriangleAnalyzer.DetermineTriangleType(3, 4, 5);
        var result2 = TriangleAnalyzer.DetermineTriangleType(5, 12, 13);
        var result3 = TriangleAnalyzer.DetermineTriangleType(2, 2, 2);
        var result4 = TriangleAnalyzer.DetermineTriangleType(7, 10, 5);
    }

    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<TriangleAnalyzerBenchmark>();
    }
}