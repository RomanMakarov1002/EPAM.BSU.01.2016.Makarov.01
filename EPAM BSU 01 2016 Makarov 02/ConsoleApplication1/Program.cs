using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubbleSort;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myarr2 = new int[5][];
            myarr2[0] = new int[3] { 9, 3, 3 };
            myarr2[1] = new int[4] { 3, 7, 2, 5 };
            myarr2[2] = new int[3] { 1, 1, 8 };
            myarr2[3] = new int[5] {100, 0, 0, -1, -5};
            myarr2[4] = new int[3] { -50, 4, 2 };
            Console.WriteLine(myarr2.Length);
            Console.ReadKey();
            
            SumInc sumInc = new SumInc();
            SumDec sumDec =new SumDec();
            MaxInc maxInc = new MaxInc();
            MaxDec maxDec = new MaxDec();
            MinInc minInc = new MinInc();
            MinDec minDec = new MinDec();
            MaxAbs maxAbs = new MaxAbs();
            Logic<int>.BubbleSort(myarr2,sumInc);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i]!=null)
                Console.WriteLine("{0} {1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            Console.WriteLine("sum inc --------------------------");
            Logic<int>.BubbleSort(myarr2, sumDec);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i] != null)
                    Console.WriteLine("{0} {1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            Console.WriteLine("sum dec --------------------------");

            Logic<int>.BubbleSort(myarr2, maxInc);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i] != null)
                    Console.WriteLine("{0} {1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            Console.WriteLine("max inc --------------------------");

            Logic<int>.BubbleSort(myarr2, minInc);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i] != null)
                    Console.WriteLine("{0} {1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            Console.WriteLine("min inc --------------------------");

            Logic<int>.BubbleSort(myarr2, minDec);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i] != null)
                    Console.WriteLine("{0} {1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            Console.WriteLine("min dec --------------------------");

            Logic<int>.BubbleSort(myarr2, maxAbs);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i] != null)
                    Console.WriteLine("{0} {1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            Console.WriteLine("max Abs --------------------------");


            Console.ReadKey();
        }
    }
}
