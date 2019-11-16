using System;

namespace TDDbyExample.Services
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }
    }
}
