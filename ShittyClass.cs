using BenchmarkDotNet.Attributes;

namespace benchmark
{
    public class ShittyClass
    {
        private const string csvString = "Code,Maze";
        private static readonly BottleneckProcess process = new BottleneckProcess();

        [Benchmark]
        public void GetLastItem()
        {
            process.GetLastItem(csvString);
        }

        [Benchmark]
        public void GetStaticItem()
    {
        process.GetLastItem("1");
    }
    }
}
