using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task2
    {
        [Test]
        public void NonRepeatCharTest()
        {
            char first = FirstNonReapeatingLetter("ss");
            char second = ' ';
            Assert.AreEqual(second, first);
        }
        [Test]
        public void NonRptCharTest2()
        {
            char first = FirstNonReapeatingLetter("stress");
            char second = 't';
            Assert.AreEqual(second, first);

        }
        [Test]
        public void NonRptCharTest3()
        {
            char first = FirstNonReapeatingLetter("sTress");
            char second = 't';
            bool equal = char.ToUpperInvariant(first) == char.ToUpperInvariant(second);
            Assert.IsTrue(equal);

        }

        public static char FirstNonReapeatingLetter(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int frequency = 0;

            foreach (char c in str.ToCharArray())
            {
                if (map.ContainsKey(c))
                {
                    frequency = map[c];
                    map[c] = frequency + 1;
                    continue;
                }
                map.Add(c, 1);
            }
            if (map.Values.Contains(1))
            {
                char nonrpt = map.First(x => x.Value == 1).Key;
                return nonrpt;
            }
            return ' ';
        }
    }
}
