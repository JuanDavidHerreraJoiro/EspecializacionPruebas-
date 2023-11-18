using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspPatterns.Creator
{
    public class program
    {
        public static void main(string[] args)
        {
            ISale sale = new StoreSale();
            SaleCreator creator = new SaleCreator(sale);
            creator.Sell();
        }
    }
}
