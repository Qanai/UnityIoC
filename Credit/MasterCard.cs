using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Credit
{
    public class MasterCard : ICreditCard
    {
        public int ChargeCount
        {
            get;
            set;
        }

        public string Charge()
        {
            ChargeCount++;
            return string.Format("MasterCard charged: {0}", ChargeCount);
        }
    }
}
