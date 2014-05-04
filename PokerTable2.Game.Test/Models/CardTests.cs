using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Test.Models
{
    [TestClass]
    public class CardTests
    {
        [TestClass]
        public class StringValue : CardTests
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Value_1_Should_Return_A()
            {
                var expectedStringValue = "A";
                Card card = new Card(1, Card.Suites.Clubs);
                Assert.AreEqual(expectedStringValue, card.StringValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Value_11_Should_Return_J()
            {
                var expectedStringValue = "J";
                Card card = new Card(11, Card.Suites.Clubs);
                Assert.AreEqual(expectedStringValue, card.StringValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Value_12_Should_Return_Q()
            {
                var expectedStringValue = "Q";
                Card card = new Card(12, Card.Suites.Clubs);
                Assert.AreEqual(expectedStringValue, card.StringValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Value_13_Should_Return_K()
            {
                var expectedStringValue = "K";
                Card card = new Card(13, Card.Suites.Clubs);
                Assert.AreEqual(expectedStringValue, card.StringValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Value_2_Through_10_Return_CorrectValue()
            {
                for (int i = 2; i < 11; i++)
                {
                    var expectedStringValue = i.ToString();
                    Card card = new Card(i, Card.Suites.Clubs);
                    Assert.AreEqual(expectedStringValue, card.StringValue);
                }
            }
        }

        [TestClass]
        public class SuitValue : CardTests
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Hearts_Returns_H()
            {
                var expectedSuitValue = "H";
                Card card = new Card(1, Card.Suites.Hearts);
                Assert.AreEqual(expectedSuitValue, card.SuitValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Clubs_Returns_C()
            {
                var expectedSuitValue = "C";
                Card card = new Card(1, Card.Suites.Clubs);
                Assert.AreEqual(expectedSuitValue, card.SuitValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Diamonds_Returns_D()
            {
                var expectedSuitValue = "D";
                Card card = new Card(1, Card.Suites.Diamonds);
                Assert.AreEqual(expectedSuitValue, card.SuitValue);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Spades_Returns_S()
            {
                var expectedSuitValue = "S";
                Card card = new Card(1, Card.Suites.Spades);
                Assert.AreEqual(expectedSuitValue, card.SuitValue);
            }
        }

        [TestClass]
        public class Name : CardTests
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Hearts_2_Should_Return_2H()
            {
                var expectedName = "2:H";
                Card card = new Card(2, Card.Suites.Hearts);
                Assert.AreEqual(expectedName, card.Name);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Club_1_Should_Return_AC()
            {
                var expectedName = "A:C";
                Card card = new Card(1, Card.Suites.Clubs);
                Assert.AreEqual(expectedName, card.Name);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Diamonds_11_Should_Return_JD()
            {
                var expectedName = "J:D";
                Card card = new Card(11, Card.Suites.Diamonds);
                Assert.AreEqual(expectedName, card.Name);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Spades_12_Should_Return_QS()
            {
                var expectedName = "Q:S";
                Card card = new Card(12, Card.Suites.Spades);
                Assert.AreEqual(expectedName, card.Name);
            }
        }
    }
}
