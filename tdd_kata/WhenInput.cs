using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_kata
{
    [TestFixture]
    class WhenInput
    {
        [Test]
        public void EmptyString_ResultShouldBeZero()
        {
            var input = "";

            var result = StringCalculator.Add(input);

            Assert.AreEqual(0, result);
        }
}

    internal static class StringCalculator
    {
        public static int Add(string input)
        {
            return 0;
        }
    }
}
