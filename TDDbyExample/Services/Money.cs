using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDDbyExample.Services
{
    public class Money
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }


        public bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && Currency().Equals(money.Currency());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return currency;
        }

        public string toString()
        {
            return amount + " " + currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

    }
}
