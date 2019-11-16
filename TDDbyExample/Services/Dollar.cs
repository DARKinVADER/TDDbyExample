using System;

namespace TDDbyExample.Services
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }

        public bool Equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return Amount == dollar.Amount;
        }
    }
}
