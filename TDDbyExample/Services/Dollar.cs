using System;

namespace TDDbyExample.Services
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            base.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
