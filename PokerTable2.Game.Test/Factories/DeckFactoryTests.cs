using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerTable2.Game.Factories;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Test.Factories
{
    [TestClass]
    public class DeckFactoryTests
    {
        public ICardFactory CardFactory { get; set; }

        public IDeckFactory DeckFactory { get; set; }

        [TestInitialize]
        public void Setup()
        {
            this.CardFactory = new CardFactory();
            this.DeckFactory = new DeckFactory(this.CardFactory);
        }

        [TestClass]
        public class BuildDeck : DeckFactoryTests
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Return_52_Cards()
            {
                int expectedNumberOfCards = 52;
                Deck deck = this.DeckFactory.BuildDeck();
                Assert.AreEqual(expectedNumberOfCards, deck.Cards.Count);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Return_13_Of_Each_Suit()
            {
                int expectedSuiteCount = 13;
                Deck deck = this.DeckFactory.BuildDeck();

                Assert.AreEqual(expectedSuiteCount, deck.Cards.Count(x => x.Suit == Card.Suites.Clubs));
                Assert.AreEqual(expectedSuiteCount, deck.Cards.Count(x => x.Suit == Card.Suites.Diamonds));
                Assert.AreEqual(expectedSuiteCount, deck.Cards.Count(x => x.Suit == Card.Suites.Hearts));
                Assert.AreEqual(expectedSuiteCount, deck.Cards.Count(x => x.Suit == Card.Suites.Spades));
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Have_Correct_Values_For_Each_Suit()
            {
                List<int> expectedValues = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13};
                Deck deck = this.DeckFactory.BuildDeck();

                CollectionAssert.AreEqual(expectedValues, deck.Cards.Where(x => x.Suit == Card.Suites.Clubs).Select(x => x.Value).ToList());
                CollectionAssert.AreEqual(expectedValues, deck.Cards.Where(x => x.Suit == Card.Suites.Diamonds).Select(x => x.Value).ToList());
                CollectionAssert.AreEqual(expectedValues, deck.Cards.Where(x => x.Suit == Card.Suites.Hearts).Select(x => x.Value).ToList());
                CollectionAssert.AreEqual(expectedValues, deck.Cards.Where(x => x.Suit == Card.Suites.Spades).Select(x => x.Value).ToList());
            }
        }
    }
}
