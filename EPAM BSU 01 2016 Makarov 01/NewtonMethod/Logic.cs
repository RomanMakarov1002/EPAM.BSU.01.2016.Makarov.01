using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    public class Logic
    {
        /// <summary>
        /// Returns SqrtN
        /// </summary>
        /// <param name="num">The Number whose root is to be found</param>
        /// <param name="n">power</param>
        /// <param name="eps">accuracy</param>
        public static double SqrtN (double num, int n, double eps)
        {
            if (num == 0)
                return 0;
            if ((num < 0 && n % 2 == 0) || (n==0))
                throw new ArgumentException();
            if (n < 0)
                return 1 / NewtonMethod(num, Math.Abs(n), eps);
            return NewtonMethod(num, n, eps);
        }

        private static double NewtonMethod(double num, int n, double eps)
        {
            double x0 = num / n;
            double x1 = (1.0 / n) * ((n - 1) * x0 + num / Math.Pow(x0, n - 1));
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1.0 / n) * ((n - 1) * x0 + num / Math.Pow(x0, n - 1));
            }
            return x1;
        }
    }
}
