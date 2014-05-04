using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Factories
{
    public interface ISeatFactory
    {
        Seat BuildSeat();
    }

    public class SeatFactory : ISeatFactory
    {

        public Seat BuildSeat()
        {
            return new Seat();
        }
    }
}
