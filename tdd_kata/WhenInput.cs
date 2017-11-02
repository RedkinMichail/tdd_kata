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

        [Test]
        public void AnyNumber_ResultShouldBeSameNumber()
        {
            var input = "3";

            var result = StringCalculator.Add(input);

            Assert.AreEqual(3,result);
        }

        [Test]
        public void TwoNumbers_ResultShouldBeTheirSum()
        {
            var input = "3,5";

            var result = StringCalculator.Add(input);

            Assert.AreEqual(3 + 5, result);
        }

        [Test]
        public void ManyNumbers_ResultShouldBeTheirSum()
        {
            var input = "4,6,30,1";

            var result = StringCalculator.Add(input);

            Assert.AreEqual(4 + 6 + 30 + 1, result);
        }

        [Test]
        public void ManyNumbersWithNewLineSymbolAsDelimeter_ResultShouldBeTheirSum()
        {
            var input = "3\n6,1";

            var result = StringCalculator.Add(input);

            Assert.AreEqual(3 + 6 + 1, result);
        }
}
}
