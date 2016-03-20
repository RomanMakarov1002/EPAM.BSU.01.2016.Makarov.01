using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class Logic<T>
    {
        /// <summary> Bubble sort for jagged array </summary>
        public static void BubbleSort(T[][] arr, IComparer<T[]> comparer )
        {            
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] == null || arr[j + 1] == null)
                        throw new NullReferenceException();
                        if (comparer.Compare(arr[j],arr[j+1])>0)
                            SwapRows(ref arr[j], ref arr[j + 1]);
                }
        }
     
        private static void SwapRows(ref T[] left, ref T[] right)
        {
            var t = left;
            left = right;
            right = t;
        }
    }
}
