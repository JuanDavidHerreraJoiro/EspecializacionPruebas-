using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.ISP.Bad
{
    public class OnlineSale : IPayment
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
