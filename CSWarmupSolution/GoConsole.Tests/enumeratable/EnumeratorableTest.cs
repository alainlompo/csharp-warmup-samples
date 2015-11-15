using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoConsole.enumeretable;
using System.Collections.Generic;

namespace GoConsole.Tests.enumeratable
{
    [TestClass]
    public class EnumeratorableTest
    {
        [TestMethod]
        public void AffectRankTest()
        {
            string[] elements = new string[] { "zero", "un", "deux", "trois", "quatre" };
            Enumeratorable<String> instance = new Enumeratorable<String>();
            IEnumerable<String> callResult = instance.AffectRank(elements);
            Assert.IsNotNull(callResult);
            int index = 0;
            foreach (String s in callResult)
            {

                Assert.IsTrue(s.Contains("[" + index+"]:"));
                index++;
            }


        }
    }
}
