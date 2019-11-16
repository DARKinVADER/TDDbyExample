using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDDbyExample.Services
{
    public abstract class Money
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
            return amount == money.amount && GetType().Equals(obj.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public abstract Money Times(int multiplier);

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return currency;

        }
    }
}
