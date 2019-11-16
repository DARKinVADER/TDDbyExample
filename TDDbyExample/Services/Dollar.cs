using System;

namespace TDDbyExample.Services
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            base.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
