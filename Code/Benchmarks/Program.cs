using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Benchmarks
{
    public static class Program
    {
        private static IConfig CreateDefaultConfig() => 
            DefaultConfig
               .Instance
               .With(Job.Clr, Job.Core)
               .With(MemoryDiagnoser.Default)
               .With(DisassemblyDiagnoser.Create(DisassemblyDiagnoserConfig.Asm));
        public static void Main(string[] args) =>
         BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly)
                          .Run(args, CreateDefaultConfig());
    }
}
