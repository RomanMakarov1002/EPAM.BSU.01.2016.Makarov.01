using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Logic
    {

        // 6 methods for diffrent types of sort
        public int SumInc(int[] a, int[] b)
        {
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < a.Length; i++)
                s1 += a[i];
            for (int i = 0; i < b.Length; i++)
                s2 += b[i];
            if (s1 > s2)    
                return 1;
            if (s1 < s2)
                return -1;
             else
                return 0;
        }

        public int SumDec(int[] a, int[] b)
        {
            int s1 = 0;
            int s2 = 0;
            for (int i = 0; i < a.Length; i++)
                s1 += a[i];
            for (int i = 0; i < b.Length; i++)
                s2 += b[i];
            if (s1 < s2)
                return 1;
            if (s1 > s2)
                return -1;
            else
                return 0;
        }

        public int MaxInc(int[] a, int[] b)
        {
            int s1 = a[0];
            int s2 = b[0];
            for (int i =0; i < a.Length - 1; i++)
                if (s1 < a[i + 1])
                    s1 = a[i + 1];
            for (int i = 0; i < b.Length - 1; i++)
                if (s2 < b[i + 1])
                    s2 = b[i + 1];
            if (s1 > s2)
                return 1;
            if (s1 < s2)
                return -1;
            else
                return 0;
        }

        public int MaxDec(int[] a, int[] b)
        {
            int s1 = a[0];
            int s2 = b[0];
            for (int i = 0; i < a.Length - 1; i++)
                if (s1 < a[i + 1])
                    s1 = a[i + 1];
            for (int i = 0; i < b.Length - 1; i++)
                if (s2 < b[i + 1])
                    s2 = b[i + 1];
            if (s1 < s2)
                return 1;
            if (s1 > s2)
                return -1;
            else
                return 0;
        }

        public int MinInc(int[] a, int[] b)
        {
            int s1 = a[0];
            int s2 = b[0];
            for (int i = 0; i < a.Length - 1; i++)
                if (s1 > a[i + 1])
                    s1 = a[i + 1];
            for (int i = 0; i < b.Length - 1; i++)
                if (s2 > b[i + 1])
                    s2 = b[i + 1];
            if (s1 > s2)
                return 1;
            if (s1 < s2)
                return -1;
            else
                return 0;
        }

        public int MinDec(int[] a, int[] b)
        {
            int s1 = a[0];
            int s2 = b[0];
            for (int i = 0; i < a.Length - 1; i++)
                if (s1 > a[i + 1])
                    s1 = a[i + 1];
            for (int i = 0; i < b.Length - 1; i++)
                if (s2 > b[i + 1])
                    s2 = b[i + 1];
            if (s1 < s2)
                return 1;
            if (s1 > s2)
                return -1;
            else
                return 0;
        }

        public void SwapRows (ref int[] left, ref int[] right)
        {
            var t = left;
            left = right;
            right = t;
        }
 
        /// <summary> Bubble sort of jugged array </summary>
        public void BubbleSort(int[][] arr, Func<int[], int[], int> cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] != null && arr[j + 1] != null)
                        if (cmp(arr[j], arr[j + 1]) > 0)
                            SwapRows(ref arr[j], ref arr[j + 1]);               
        }
             
    }
}
