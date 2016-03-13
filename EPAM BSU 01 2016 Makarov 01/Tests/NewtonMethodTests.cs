using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static NewtonMethod.Logic;

namespace Tests
{
    [TestFixture]
    public class NewtonMethodTests
    {
        [TestCase(0, 5, 00.1, ExpectedResult = 0)]
        [TestCase(-25, 2 ,0.0001, ExpectedException = typeof(ArgumentException))]
        public double SqrtN_Test(double num, int root, double e)
        {
            return SqrtN(num, root, e) ;
        }
        [Test]
        public void SqrtN_CompareWithMathPowResults()
        {
            double[] nums = new double[5] {125, -125, 0, 100, -100};
            int[] roots = new int[5] {3, 3, 1, 5, 5};
            double eps = 0.001;
            double[] results = new double[5] {5, -5, 0, 2.5118, -2.5118};
            for (int i=0; i< nums.Length; i++)
                Assert.That(SqrtN(nums[i], roots[i], eps), Is.InRange(results[i] - eps, results[i] + eps));
        }

    }
}
