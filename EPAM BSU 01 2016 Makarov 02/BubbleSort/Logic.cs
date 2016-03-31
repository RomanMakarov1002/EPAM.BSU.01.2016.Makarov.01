using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class Logic
    {
        /// <summary> Bubble sort for jagged array using Interface </summary>
        public static void BubbleSort<T>(T[][] arr, IComparer<T[]> comparer )
        {            
            BubbleSortWithDelegate(arr, comparer.Compare);
        }
        /// <summary> Bubble sort for jagged array using Delegate</summary>
        public static void BubbleSortWithDelegate<T>(T[][] arr, Func<T[],T[],int> comparer)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] == null || arr[j + 1] == null)
                        throw new ArgumentNullException();
                    if (comparer(arr[j], arr[j + 1]) > 0)
                        SwapRows(ref arr[j], ref arr[j + 1]);
                }
        }


        private static void SwapRows<T>(ref T[] left, ref T[] right)
        {
            var t = left;
            left = right;
            right = t;
        }
    }
}
