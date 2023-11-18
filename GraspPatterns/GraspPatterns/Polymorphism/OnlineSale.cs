using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.Polymorphism
{
    public class OnlineSale : ISale
    {
        public const int DISCOUNT = 2000;
        public double CalculateTotalSale(List<double> listTotalSale)
        {
            var subTotal = listTotalSale.Sum();
            return subTotal - DISCOUNT;
        }
    }
}
