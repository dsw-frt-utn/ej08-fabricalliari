using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale:Sale
    {
        public RetailSale(int cantidad, decimal precioUnitario) : base(cantidad, precioUnitario)
        {
        }

        public override decimal CalculateTotal()
        {
            return  PrecioUnitario*Cantidad;
        }
    }
}
