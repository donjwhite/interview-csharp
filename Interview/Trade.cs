namespace Interview
{
    public class Trade
    {
        private readonly int _shares;
        private readonly double _price;
        private readonly DateTime _timestamp;

        public int shares 
        { 
            get { return _shares; }
        }
        public double price
        {
            get { return _price; }
        }
        public DateTime timestamp
        {
            get { return _timestamp; }
        }

        public Trade(int shares, double price)
        {
            this._shares = shares;
            this._price = price;
            this._timestamp = DateTime.Now;

        }

        public override bool Equals(object? obj)
        {
            return obj is Trade trade &&
                   _shares == trade.shares &&
                   _price == trade.price &&
                   _timestamp == trade.timestamp;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_shares, _price, _timestamp);
        }
    }
}
