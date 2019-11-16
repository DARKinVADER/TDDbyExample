using System;

namespace TDDbyExample.Services
{
    public class Franc
    {
        public Franc(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }

        public bool Equals(Object obj)
        {
            Franc Franc = (Franc)obj;
            return Amount == Franc.Amount;
        }
    }
}
