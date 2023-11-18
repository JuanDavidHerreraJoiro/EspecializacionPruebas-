using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.Polymorphism
{
    public class StoreSale : ISale
    {
        public const int SURCARGE = 5000;
        public double CalculateTotalSale(List<double> listTotalSale)
        {
            var subTotal = listTotalSale.Sum();
            return subTotal + SURCARGE; 
        }
    }
}
