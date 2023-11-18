using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.OCP.Good
{
    public class StoreSale : ISale
    {
        public int GetDiscount()
        {
            return 5;
        }
    }
}
