using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // proverit' na null

            int[] myarr = new int[5] { 3, 5, 6, 1, 2 };
            Array.Sort(myarr);
            int[][] myarr2 = new int[5][];
            int x=0;
            long t=0;
            t = x;
            myarr2[0] = new int[3] { 9, 3, 3 };
            myarr2[1] = new int[4] { 3, 7, 2, 5 };
            myarr2[2] = new int[2] { 1, 1 };
            myarr2[4] = new int[3] { 50, 4, 2 };
            Console.WriteLine(myarr2.Length);
            Console.ReadKey();
            /*
            BubbleSort.Logic.Sort(myarr2, "sum", BubbleSort.Logic.Comp(myarr, myarr));
            for (int i = 0; i < myarr2.Length; i++)
                Console.WriteLine("{0}{1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            BubbleSort.Logic.Sort(myarr2, "min");
            for (int i = 0; i < myarr2.Length; i++)
                Console.WriteLine("{0}{1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            BubbleSort.Logic.Sort(myarr2, "max");
            for (int i = 0; i < myarr2.Length; i++)
                Console.WriteLine("{0}{1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());
            
            */
            BubbleSort.Logic a = new BubbleSort.Logic();
            a.someproc(myarr2);
            for (int i = 0; i < myarr2.Length; i++)
                if (myarr2[i]!=null)
                Console.WriteLine("{0}{1}", myarr2[i][0].ToString(), myarr2[i][1].ToString());

            Console.ReadKey();
        }
    }
}
