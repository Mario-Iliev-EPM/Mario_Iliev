using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task5
    {
        [Test]
        public void FriensListTest()
        {
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string FriendsListAfterProcessing = ProccesingFriendsList(s);
            string ExpectedList = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(ExpectedList, FriendsListAfterProcessing);
        }

        public string ProccesingFriendsList(string friends)
        {
            return "(" + string.Join(")(",
                friends.
                ToUpper().
                Split(';').
                Select(n => n.Split(":")).
                Select(n => string.Join(", ", n.Reverse())).
                OrderBy(n => n)
            ) + ")";
        }
    }
}
