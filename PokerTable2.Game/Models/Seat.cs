using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable2.Game.Models
{
    public class Seat
    {
        public Guid? PlayerGuid { get; set; }

        public bool IsOccupied
        {
            get { return this.PlayerGuid.HasValue; }
        }

        internal Seat()
        {
            
        }
    }
}
