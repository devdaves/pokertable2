namespace PokerTable2.Game.Models
{
    public class Card
    {
        public enum Suites
        {
            Clubs = 1,
            Hearts = 2,
            Spades = 3,
            Diamonds = 4
        }

        public int Value { get; set; }

        public Suites Suite { get; set; }

        public string StringValue
        {
            get { return this.GetStringValue(); }
        }

        public string SuiteValue
        {
            get { return this.GetSuiteValue(); }
        }

        public string Name {
            get { return this.GetName(); }
        }

        public Card(int value, Suites suite)
        {
            this.Value = value;
            this.Suite = suite;
        }

        private string GetStringValue()
        {
            switch (this.Value)
            {
                case 1:
                    return "A";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                default:
                    return this.Value.ToString();
            }
        }

        private string GetSuiteValue()
        {
            switch (Suite)
            {
                case Suites.Hearts:
                    return "H";
                case Suites.Clubs:
                    return "C";
                case Suites.Diamonds:
                    return "D";
                case Suites.Spades:
                    return "S";
            }

            return string.Empty;
        }

        private string GetName()
        {
            return string.Format("{0}:{1}", this.GetStringValue(), this.GetSuiteValue());
        }
    }
}