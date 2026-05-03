using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
           public String FormatearPrecio (decimal price)
        {

            return price.ToString ("C"); //DEVOLVEMOS EN FORMATO CURRENCY O MONEDA. 
        }
    }
}
