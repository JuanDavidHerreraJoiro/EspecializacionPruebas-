﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.ISP.Bad
{
    public interface IPayment
    {
        void PayCash();
        void PayOnline();
    }
}
