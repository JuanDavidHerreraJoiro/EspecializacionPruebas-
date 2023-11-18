using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.ISP.Bad
{
    public interface ISale
    {
        void CashPayment(double amount);
        void OnlinePayment(double amount);
    }
}
