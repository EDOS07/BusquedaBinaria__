using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    public static class BenchmarkDotNet
    {
        public static int GetIntFromString(string intAsStr)
        {
            int.TryParse(intAsStr, out var number);
            return number;
        }
    }
}
