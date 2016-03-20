using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public sealed class SumInc : IComparer<Int32[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x.Sum() > y.Sum()) ? 1 : -1;
        }
    }

    public sealed class SumDec : IComparer<Int32[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x.Sum() < y.Sum()) ? 1 : -1;
        }
    }

    public sealed class MinInc : IComparer<Int32[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x.Min() > y.Min()) ? 1 : -1;
        }
    }

    public sealed class MinDec : IComparer<Int32[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x.Min() < y.Min()) ? 1 : -1;
        }
    }

    public sealed class MaxInc : IComparer<Int32[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x.Max() > y.Max()) ? 1 : -1;
        }
    }

    public sealed class MaxDec : IComparer<Int32[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x.Max() < y.Max()) ? 1 : -1;
        }
    }
}
