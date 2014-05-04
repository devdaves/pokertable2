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
    public class SeatTests
    {
        [TestClass]
        public class IsOccupied : SeatTests
        {
            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Be_True_If_PlayerIsInSeat()
            {
                Seat seat = new Seat();
                seat.PlayerGuid = Guid.NewGuid();

                Assert.AreEqual(true, seat.IsOccupied);
            }

            [TestMethod, TestCategory(Constants.Bvt)]
            public void Should_Be_False_If_PlayerIsNotInSeat()
            {
                Seat seat = new Seat();

                Assert.AreEqual(false, seat.IsOccupied);
            }
        }
    }
}
