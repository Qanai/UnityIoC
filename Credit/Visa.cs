using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    public class Visa : ICreditCard
    {
        public int ChargeCount
        {
            get
            {
                return 0;
            }
        }

        public string Charge()
        {
            return "Visa ... Visa";
        }
    }
}
