using NUnit.Framework;

namespace ClassLibrary1
{
    public class Task1
    {
        [Test]
        public void Test1()
        {
            List<object> listForTest = new List<object>() { 1, 2, 'a', 'b' };
            List<int> filtered = GetIntegersFromList(listForTest);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, filtered.Count);

        }
        [Test]
        public void Test2()
        {
            List<object> listForTest = new List<object>() { 1, 2, 'a', 'b', 0, 15 };
            List<int> filtered = GetIntegersFromList(listForTest);
            int expectedResult = 4;
            Assert.AreEqual(expectedResult, filtered.Count);
            
        }
        [Test]
        public void Test3()
        {
            List<object> listForTest = new List<object>() { 1, 2, 'a', 'b', " aasf", '1', "123", 231 };
            List<int> filteredList = GetIntegersFromList(listForTest);
            List<int> expected = new List<int>() { 1, 2, 231 };
            Assert.AreEqual(expected, filteredList);

        }

        public static List<int> GetIntegersFromList(List<object> listofItems)
        {

            List<int> nums = new List<int>();
            foreach (var item in listofItems)
            {
                if (item is int)
                {
                    nums.Add((int)item);
                }
            }

            return nums;


        }
    }
}