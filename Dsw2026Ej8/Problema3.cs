using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias (int originalValue, Product product)
        {
            int variableLocal = originalValue;
            variableLocal = variableLocal + 1;
            Product productCopia = product;
            productCopia.ModificarDescription("20 mil leguas de viaje submarino");
            return $"{originalValue}-{variableLocal}-{product.Description}";

        }
    }
}
