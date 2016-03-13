using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class OtherLogic
    {
        // 6 methods for diffrent types of sort
        public int SumInc(int[] firstLine, int[] secondLine)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < firstLine.Length; i++)
                sum1 += firstLine[i];
            for (int i = 0; i < secondLine.Length; i++)
                sum2 += secondLine[i];
            if (sum1 > sum2)
                return 1;
            if (sum1 < sum2)
                return -1;
            else
                return 0;
        }

        public int SumDec(int[] firstLine, int[] secondLine)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < firstLine.Length; i++)
                sum1 += firstLine[i];
            for (int i = 0; i < secondLine.Length; i++)
                sum2 += secondLine[i];
            if (sum1 < sum2)
                return 1;
            if (sum1 > sum2)
                return -1;
            else
                return 0;
        }

        public int MaxInc(int[] firstLine, int[] secondLine)
        {
            int sum1 = firstLine[0];
            int sum2 = secondLine[0];
            for (int i = 0; i < firstLine.Length - 1; i++)
                if (sum1 < firstLine[i + 1])
                    sum1 = firstLine[i + 1];
            for (int i = 0; i < secondLine.Length - 1; i++)
                if (sum2 < secondLine[i + 1])
                    sum2 = secondLine[i + 1];
            if (sum1 > sum2)
                return 1;
            if (sum1 < sum2)
                return -1;
            else
                return 0;
        }

        public int MaxDec(int[] firstLine, int[] secondLine)
        {
            int sum1 = firstLine[0];
            int sum2 = secondLine[0];
            for (int i = 0; i < firstLine.Length - 1; i++)
                if (sum1 < firstLine[i + 1])
                    sum1 = firstLine[i + 1];
            for (int i = 0; i < secondLine.Length - 1; i++)
                if (sum2 < secondLine[i + 1])
                    sum2 = secondLine[i + 1];
            if (sum1 < sum2)
                return 1;
            if (sum1 > sum2)
                return -1;
            else
                return 0;
        }

        public int MinInc(int[] firstLine, int[] secondLine)
        {
            int sum1 = firstLine[0];
            int sum2 = secondLine[0];
            for (int i = 0; i < firstLine.Length - 1; i++)
                if (sum1 > firstLine[i + 1])
                    sum1 = firstLine[i + 1];
            for (int i = 0; i < secondLine.Length - 1; i++)
                if (sum2 > secondLine[i + 1])
                    sum2 = secondLine[i + 1];
            if (sum1 > sum2)
                return 1;
            if (sum1 < sum2)
                return -1;
            else
                return 0;
        }

        public int MinDec(int[] firstLine, int[] secondLine)
        {
            int sum1 = firstLine[0];
            int sum2 = secondLine[0];
            for (int i = 0; i < firstLine.Length - 1; i++)
                if (sum1 > firstLine[i + 1])
                    sum1 = firstLine[i + 1];
            for (int i = 0; i < secondLine.Length - 1; i++)
                if (sum2 > secondLine[i + 1])
                    sum2 = secondLine[i + 1];
            if (sum1 < sum2)
                return 1;
            if (sum1 > sum2)
                return -1;
            else
                return 0;
        }

    }
}
