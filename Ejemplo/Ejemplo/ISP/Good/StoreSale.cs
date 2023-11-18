using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.ISP.Good
{
    public class StoreSale : ICashPayment, IOnlinePayment
    {
        public void PayCash()
        {
            throw new NotImplementedException();
        }

        public void PayOnline()
        {
            throw new NotImplementedException();
        }
    }
}
