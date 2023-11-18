using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.Creator
{
    public class SaleCreator : ISale
    {
        private ISale _sale;
        public SaleCreator(ISale sale)
        {
            _sale = sale;
        }
        public void Sell()
        {
           _sale.Sell();
        }
    }
}
