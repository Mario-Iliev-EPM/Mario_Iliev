using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task4
    {
        [Test]
        public void TestCount()
        {
            int[] array = new int[] { 1, 3, 6, 2, 2, 0, 4, 5 };
            int target = 5;
            int ActualResult = CountPairs(array, target);
            int ExpetedResult = 4;
            Assert.AreEqual(ExpetedResult, ActualResult);

        }
        public static int CountPairs(int[] arr, int target)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == target)
                        count++;
            return count;
        }
    }
}
