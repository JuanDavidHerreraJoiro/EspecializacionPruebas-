using Ejemplo.SRP.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.DIP.Good
{
    public class SaleService
    {
        private SaleRepository _repository;
        public SaleService(SaleRepository repository)
        {

            _repository = repository;
        }
        public void SaveSale(Sale sale)
        {
            _repository.SaveSale(sale);
        }
    }
}
