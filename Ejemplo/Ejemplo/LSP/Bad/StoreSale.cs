﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.LSP.Bad
{
    public class StoreSale : Sale
    {
        public override void Sell()
        {
            throw new NotImplementedException();
        }
    }
}
