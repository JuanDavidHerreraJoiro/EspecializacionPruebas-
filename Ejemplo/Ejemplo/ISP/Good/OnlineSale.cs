
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.ISP.Good
{
    public class OnlineSale : IOnlinePayment
    {
        public void PayOnline()
        {
            throw new NotImplementedException();
        }
    }
}
