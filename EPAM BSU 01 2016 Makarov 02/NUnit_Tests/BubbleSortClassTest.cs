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
            Logic.BubbleSort(array, sumInc);
            for (int i=0; i<expectedResultsforSum.Length; i++)
            Assert.AreEqual(expectedResultsforSum[i],array[i].Sum());

            SumInc sumInc1 = new SumInc();
            Logic.BubbleSort(array, sumInc);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[i], array[i].Sum());

            SumDec sumDec = new SumDec();
            Logic.BubbleSort(array, sumDec);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[Math.Abs(i-5)], array[i].Sum());


            MaxAbs maxAbs = new MaxAbs();
            Logic.BubbleSort(array,maxAbs);
            for (int i =0; i<expectedResultsforAbs.Length; i++)
                Assert.AreEqual(expectedResultsforAbs[i],array[i][0]);         
        }


        [Test]
        public void BubbleSortInterfaceWithDelegate_Test()
        {
            int[][] array = new int[6][];
            array[0] = new int[3] { 9, 3, 3 };      //sum = 15      
            array[1] = new int[4] { 3, 7, 2, 5 };   // sum = 17
            array[2] = new int[3] { 1, 1, 8 };      // sum = 10
            array[3] = new int[5] { 100, 0, 0, -1, -5 };  // sum = 94
            array[4] = new int[3] { -50, 4, 2 };        //sum = - 44
            array[5] = new int[1] { 20 };                 // sum = 20
            int[] expectedResultsforSum = new int[6] { -44, 10, 15, 17, 20, 94 };
            int[] expectedResultsforAbs = new int[6] { 3, 1, 9, 20, -50, 100 }; // First elements of sorted Array with Abs key

            Adapter ADelegate = new Adapter(Adapter.SumInc);
            Logic.BubbleSort(array, ADelegate);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[i], array[i].Sum());

            ADelegate = new Adapter(Adapter.SumDec);
            Logic.BubbleSort(array, ADelegate);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[Math.Abs(i - 5)], array[i].Sum());

            ADelegate = new Adapter(Adapter.MaxAbs);       
            Logic.BubbleSort(array, ADelegate);
            for (int i = 0; i < expectedResultsforAbs.Length; i++)
                Assert.AreEqual(expectedResultsforAbs[i], array[i][0]);
        }


        [Test]
        public void BubbleSortDelegatewithInterfaceMethod_Test()
        {
            int[][] array = new int[6][];
            array[0] = new int[3] { 9, 3, 3 };      //sum = 15      
            array[1] = new int[4] { 3, 7, 2, 5 };   // sum = 17
            array[2] = new int[3] { 1, 1, 8 };      // sum = 10
            array[3] = new int[5] { 100, 0, 0, -1, -5 };  // sum = 94
            array[4] = new int[3] { -50, 4, 2 };        //sum = - 44
            array[5] = new int[1] { 20 };                 // sum = 20
            int[] expectedResultsforSum = new int[6] { -44, 10, 15, 17, 20, 94 };
            int[] expectedResultsforAbs = new int[6] { 3, 1, 9, 20, -50, 100 }; // First elements of sorted Array with Abs key

            Logic.BubbleSortWithDelegate(array, new SumInc().Compare);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[i], array[i].Sum());

            Logic.BubbleSortWithDelegate(array, new SumDec().Compare);
            for (int i = 0; i < expectedResultsforSum.Length; i++)
                Assert.AreEqual(expectedResultsforSum[Math.Abs(i - 5)], array[i].Sum());

            Logic.BubbleSortWithDelegate(array, new MaxAbs().Compare);
            for (int i = 0; i < expectedResultsforAbs.Length; i++)
                Assert.AreEqual(expectedResultsforAbs[i], array[i][0]);
        }



        [TestCase( ExpectedException = typeof (NullReferenceException))]
        public void BubbleSortException_Test ()
        {
            int[][] array = new int[2][];
            array[0] = new int[3] {1,2,3};
            array[1] = null;
            Logic.BubbleSort(array,new MaxAbs());
        }

        [Test]
        public void DiffrentTypes_Test()
        {
            double[][] array = new double[4][];
            array[0] = new double[5] {1.1, 1.3, 1.8, 2.1, 2.4};
            array[1] = new double[3] {24.1, 1.1, -5.4};
            array[2] = new double[4] {17, 8.3, 4.2, 1.1};
            array[3] = new double[1] {-50.83};

            double[] resSumArray= new double[4] {17,24.1,1.1,-50.83};
            double[] resMaxAbsArray = new double[4] { 1.1, 17, 24.1, -50.83 };
            double[] resMinIncArray = new double[4] {-50.83, 24.1, 1.1, 17};

            Logic.BubbleSortWithDelegate(array, new SumDec4Double().Compare);
            for (int i = 0; i < resSumArray.Length; i++)
                Assert.AreEqual(resSumArray[i], array[i][0]);

            Logic.BubbleSortWithDelegate(array, new MaxAbs4Double().Compare);
            for (int i = 0; i < resMaxAbsArray.Length; i++)
                Assert.AreEqual(resMaxAbsArray[i], array[i][0]);

            Logic.BubbleSortWithDelegate(array, new MinInc4Double().Compare);
            for (int i = 0; i < resMinIncArray.Length; i++)
                Assert.AreEqual(resMinIncArray[i], array[i][0]);
        }

    }
}
