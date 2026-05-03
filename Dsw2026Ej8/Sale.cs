using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
    
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        public Sale(int cantidad, decimal precioUnitario)
    {
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;

    }
            public virtual decimal CalculateTotal() {  return 0; }
    }
}
