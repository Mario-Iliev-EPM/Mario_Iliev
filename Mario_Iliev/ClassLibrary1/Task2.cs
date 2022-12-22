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
            string str = FirstNonReapeatingLetter("ss");
            string expected = " ";
            Assert.AreEqual(expected, str);
        }
        [Test]
        public void NonRptCharTest2()
        {
            string str = FirstNonReapeatingLetter("stress");
            string expected = "t";
            Assert.AreEqual(expected, str);

        }
        [Test]
        public void NonRptCharTest3()
        {
            string str = FirstNonReapeatingLetter("sTress");
            string expected = "T";
            Assert.AreEqual(expected, str);
        }

        [Test]
        public void NonRepeatLetter()
        {
            string str = FirstNonReapeatingLetter("AbcaBDC");
            string expected = "D";
            Assert.AreEqual(expected, str);
        }

        public static string FirstNonReapeatingLetter(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            int frequency = 0;


            string lower = str.ToLower();
            foreach (char c in lower.ToCharArray())
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
                int Indexof = lower.IndexOf(nonrpt);
                string ret = str[Indexof].ToString();
                return ret;
            }
            return " ";
        }
    }
}
