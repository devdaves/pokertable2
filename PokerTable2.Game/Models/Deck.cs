using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTable2.Game.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        internal Deck()
        {
            this.Cards = new List<Card>();
        }
    }
}
