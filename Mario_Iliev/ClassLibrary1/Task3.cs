using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task3
    {
        [TestCase(16, 7)]

        public void TestDigRootTest1(int input1, int expectedResult)
        {
            int number = DigitalRootNumber(input1);

            Assert.AreEqual(expectedResult, number);
        }
        [TestCase(132189, 6)]

        public void TestDigRootTest2(int input1, int expectedResult)
        {
            int number = DigitalRootNumber(input1);

            Assert.AreEqual(expectedResult, number);
        }
        public static int DigitalRootNumber(int n)
        {
            int root = 0;
            while (n % 10 > 0)
            {
                root += (n % 10);
                n /= 10;

            }
            if (root / 10 > 0)
            {

                return DigitalRootNumber(root);
            }
            return root;
        }
    }
}
