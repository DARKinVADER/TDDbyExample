using System;

namespace TDDbyExample.Services
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            base.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
    }
}
