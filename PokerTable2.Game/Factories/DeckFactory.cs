using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Factories
{
    public interface IDeckFactory
    {
        Deck BuildDeck();
    }

    public class DeckFactory : IDeckFactory
    {
        private ICardFactory cardFactory;

        public DeckFactory(ICardFactory cardFactory)
        {
            this.cardFactory = cardFactory;
        }

        public Deck BuildDeck()
        {
            Deck deck = new Deck();

            foreach (Card.Suites suit in (Card.Suites[])Enum.GetValues(typeof(Card.Suites)))
            {
                for (int v = 1; v < 14; v++)
                {
                    deck.Cards.Add(new Card(v, suit));
                }
            }

            return deck;
        }
    }
}
