using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.OCP.Bad
{
    public class Sale
    {
        public int Sell(string saleType) {
             
            int discount;

            switch (saleType) {

                case "online":
                    discount = 10;
                    break;

                case "store":
                    discount = 5;
                    break;

                default:
                    discount = 0;
                    break;
                   
            }

            return discount;
        }
    }
}
