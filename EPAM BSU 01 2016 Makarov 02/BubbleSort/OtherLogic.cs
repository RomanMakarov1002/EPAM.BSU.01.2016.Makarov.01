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

    public sealed class MaxAbs : IComparer<Int32[]>
    {
        public int Compare(int[] lhs, int[] rhs)
        {
            int lhsAbs=Math.Abs(lhs[0]);
            int rhsAbs = Math.Abs(rhs[0]);
            for (int i=1; i<lhs.Length; i++)
                if (Math.Abs(lhs[i]) > lhsAbs)
                    lhsAbs = Math.Abs(lhs[i]);
            for (int i=1; i<rhs.Length; i++)
                if (Math.Abs(rhs[i]) > rhsAbs)
                    rhsAbs = Math.Abs(rhs[i]);
            return (lhsAbs > rhsAbs) ? 1 : -1;
        }
    }

    public sealed class Adapter : IComparer<Int32[]>
    {
        private Func<int[], int[], int> del;

        public Adapter(Func<int[], int[], int> key)
        {
            this.del = key;
        }

        public int Compare(int[] lhs, int[] rhs)
        {
            return del(lhs,rhs);
        }

        public static int SumInc(int[] x, int[] y)
        {
            return (x.Sum() > y.Sum()) ? 1 : -1;
        }

        public static int SumDec(int[] x, int[] y)
        {
            return (x.Sum() < y.Sum()) ? 1 : -1;
        }

        public static int MaxInc(int[] x, int[] y)
        {
            return (x.Max() > y.Max()) ? 1 : -1;
        }

        public static int MaxDec(int[] x, int[] y)
        {
            return (x.Max() < y.Max()) ? 1 : -1;
        }

        public static int MinInc(int[] x, int[] y)
        {
            return (x.Min() > y.Min()) ? 1 : -1;
        }

        public static int MinDec(int[] x, int[] y)
        {
            return (x.Min() < y.Min()) ? 1 : -1;
        }

        public static  int MaxAbs(int[] lhs, int[] rhs)
        {
            int lhsAbs = Math.Abs(lhs[0]);
            int rhsAbs = Math.Abs(rhs[0]);
            for (int i = 1; i < lhs.Length; i++)
                if (Math.Abs(lhs[i]) > lhsAbs)
                    lhsAbs = Math.Abs(lhs[i]);
            for (int i = 1; i < rhs.Length; i++)
                if (Math.Abs(rhs[i]) > rhsAbs)
                    rhsAbs = Math.Abs(rhs[i]);
            return (lhsAbs > rhsAbs) ? 1 : -1;
        }
    }
}
