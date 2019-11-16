using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDDbyExample.Services
{
    public class Money
    {
        protected int amount;

        public bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType().Equals(obj.GetType());
        }
    }
}
