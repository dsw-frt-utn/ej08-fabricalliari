using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale:Sale
    {
        public WholesaleSale(int cantidad ,decimal precioUnitario):base(cantidad,precioUnitario) { }

        public override decimal CalculateTotal()
        {
            decimal descuento = (Cantidad * PrecioUnitario) * (decimal)0.1;
            return  (Cantidad * PrecioUnitario)-descuento; 
        }
    }
}
