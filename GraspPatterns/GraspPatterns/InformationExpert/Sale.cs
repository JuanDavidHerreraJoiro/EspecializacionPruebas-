using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.InformationExpert
{
    public class Sale
    {
       public double CalculateTotalSale(List<double> listTotalSale)
        {
            return listTotalSale.Sum();
        }
    }
}
