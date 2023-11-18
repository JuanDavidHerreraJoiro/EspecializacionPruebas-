using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.Polymorphism
{
    public interface ISale
    {
        double CalculateTotalSale(List<double> listTotalSale);
    }
}
