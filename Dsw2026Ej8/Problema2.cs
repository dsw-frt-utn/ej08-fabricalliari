using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var producto = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity <= 0 ? 0 : quantity,
                Total = quantity <= 0 ? 0 : quantity * unitPrice
            };

            return $"{producto.Code}-{producto.Description}-{producto.Total}";
        }
    }
}
