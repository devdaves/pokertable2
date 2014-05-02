using System;
using PokerTable2.Game.Models;

namespace PokerTable2.Game.Factories
{
    public interface ICardFactory
    {
        Card BuildCard(int value, Card.Suites suites);
    }
 
    public class CardFactory : ICardFactory
    {
        public Card BuildCard(int value, Card.Suites suite)
        {
            if (value < 1 || value > 13)
            {
                throw new ArgumentOutOfRangeException("value", "value should be between 1 and 13");
            }
            return new Card(value, suite);
        }
    }
}