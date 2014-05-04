using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Tests.Models
{
    [TestClass]
    public class DeckTests
    {
        [TestClass]
        public class Ctor
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Shoould_Intialize_CardCollection()
            {
                Deck deck = new Deck();
                Assert.IsNotNull(deck.Cards);
            }
        }
    }
}
