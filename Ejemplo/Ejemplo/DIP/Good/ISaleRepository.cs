using Ejemplo.SRP.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.DIP.Good
{
    public interface ISaleRepository
    {
        public void SaveSale(Sale sale);
    }
}
