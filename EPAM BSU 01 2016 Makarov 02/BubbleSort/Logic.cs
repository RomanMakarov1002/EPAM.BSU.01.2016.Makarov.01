using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Logic
    { 
        /// <summary> Bubble sort of jagged array </summary>
        public void BubbleSort(int[][] arr, Func<int[], int[], int> cmp)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] != null && arr[j + 1] != null)
                        if (cmp(arr[j], arr[j + 1]) > 0)
                            SwapRows(ref arr[j], ref arr[j + 1]);               
        }

        private void SwapRows(ref int[] left, ref int[] right)
        {
            var t = left;
            left = right;
            right = t;
        }
    }
}
