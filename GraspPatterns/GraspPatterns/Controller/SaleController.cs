using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.Controller
{
    public class SaleController
    {
        private ISaleService _saleService;
        public SaleController(ISaleService saleService) {
            _saleService = saleService;
        }

        public void Save(Sale sale)
        {
            _saleService.Save(sale);
        }
    }
}
