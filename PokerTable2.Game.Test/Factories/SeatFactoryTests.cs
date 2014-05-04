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
    public class SeatFactoryTests
    {
        public ISeatFactory SeatFactory { get; set; }

        [TestInitialize]
        public void Setup()
        {
            this.SeatFactory = new SeatFactory();
        }

        [TestClass]
        public class BuildSeat : SeatFactoryTests
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Return_Seat()
            {
                var seat = this.SeatFactory.BuildSeat();
                Assert.IsInstanceOfType(seat, typeof(Seat));
            }
        }
    }
}
