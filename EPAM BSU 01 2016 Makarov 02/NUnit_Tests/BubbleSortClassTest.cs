using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSort;
using NUnit.Framework;

namespace NUnit_Tests
{
    [TestFixture]
    public class BubbleSortClassTest
    {
        [Test]
        public void BubbleSort_Test()
        {
            int[][] array = new int[6][];
            array[0] = new int[3] { 9, 3, 3 };      //sum = 15      
            array[1] = new int[4] { 3, 7, 2, 5 };   // sum = 17
            array[2] = new int[3] { 1, 1, 8 };      // sum = 10
            array[3] = new int[5] {100, 0, 0, -1, -5};  // sum = 94
            array[4] = new int[3] { -50, 4, 2 };        //sum = - 44
            array[5] = new int[1] {20};                 // sum = 20
            int[] expectedResultsforSum = new int[6] {-44, 10, 15, 17, 20, 94};
            int[] expectedResultsforAbs = new int[6] {3, 1, 9, 20, -50, 100}; // First elements of sorted Array with Abs key

            IComparer<int[]> sumInc = new SumInc();
            Logic<int>.BubbleSort(array, sumInc);
            for (int i=0; i<expectedResultsforSum.Length; i++)
            Assert.AreEqual(expectedResultsforSum[i],array[i].Sum());

            SumInc sumInc1 = new SumInc();
            Logic<int>.BubbleSort(array, sumInc);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[i], array[i].Sum());

            SumDec sumDec = new SumDec();
            Logic<int>.BubbleSort(array, sumDec);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[Math.Abs(i-5)], array[i].Sum());


            MaxAbs maxAbs = new MaxAbs();
            Logic<int>.BubbleSort(array,maxAbs);
            for (int i =0; i<expectedResultsforAbs.Length; i++)
                Assert.AreEqual(expectedResultsforAbs[i],array[i][0]);
        
           

        }

        [TestCase( ExpectedException = typeof (NullReferenceException))]
        public void BubbleSortException_Test ()
        {
            int[][] array = new int[2][];
            array[0] = new int[3] {1,2,3};
            array[1] = null;
            Logic<int>.BubbleSort(array,new MaxAbs());
        }



    }
}
