using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerTable2.Game.Factories;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Tests.Factories
{
    [TestClass]
    public class CardFactoryTests
    {
        [TestClass]
        public class BuildCard : CardFactoryTests
        {
            public ICardFactory CardFactory { get; set; }

            [TestInitialize]
            public void Setup()
            {
                this.CardFactory = new CardFactory();
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Return_Card()
            {
                var card = this.CardFactory.BuildCard(1, Card.Suites.Clubs);
                Assert.IsInstanceOfType(card, typeof(Card));
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void Value_LessThan1_ShouldThrow_ArgumentOutOfRangeException()
            {
                var card = this.CardFactory.BuildCard(-1, Card.Suites.Clubs);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void Value_MoreThan13_ShouldThrow_ArgumentOutOfRangeException()
            {
                var card = this.CardFactory.BuildCard(14, Card.Suites.Clubs);
            }
        }
    }
}
