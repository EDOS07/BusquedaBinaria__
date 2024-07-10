using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    public class IntParseBenchmarks
    {
        private const string IntAsString = "609";

        [Benchmark]
        public void GetIntByStringUsingParse()
        {
            var number = BenchmarkDotNet.GetIntFromString(IntAsString);
        }
    }
}
