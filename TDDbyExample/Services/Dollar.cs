﻿using System;

namespace TDDbyExample.Services
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(amount * multiplier);
        }
    }
}
