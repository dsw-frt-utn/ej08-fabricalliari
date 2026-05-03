namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {   //--------Pruebas Problema 1-------\\
            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Coca cola", 2000);
            Console.WriteLine("//--------Pruebas Problema 1-------\\");
            Console.WriteLine(etiqueta);
            //--------Pruebas Problema 2-------\\
            var p2 = new Problema2();
            Console.WriteLine("//--------Pruebas Problema 2-------\\");
            Console.WriteLine(p2.CrearResumenVenta(1000,"Pepsi Black",2,300m));
            //--------Pruebas Problema 3-------\\
            var producto = new Product("Producto Original");
            var p3 = new Problema3();
            Console.WriteLine("//--------Pruebas Problema 3-------\\");
            Console.WriteLine(p3.CompararCopias(5, producto));
            //--------Pruebas Problema 4-------\\
            var p4 = new Problema4();
            Console.WriteLine("//--------Pruebas Problema 4-------\\");
            Console.WriteLine(p4.CalcularPromedio(5, 8, null));  // → 6.5
            Console.WriteLine(p4.CalcularPromedio(null, null, null)); // → 0
            Console.WriteLine(p4.CalcularPromedio(-1, 5, 12));   // → 5  (-1 y 12 se ignoran)
            //--------Pruebas Problema 5-------\\
            var p5 = new Problema5();
            Console.WriteLine("//--------Pruebas Problema 5-------\\");
            Sale v1 = new RetailSale(1, 100);
            Sale v2 = new WholesaleSale(1, 100);
            Console.WriteLine(p5.ObtenerImporteFinal(v1));
            Console.WriteLine(p5.ObtenerImporteFinal(v2));
            //--------Pruebas Problema 6-------\\
            var p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" asdw 123"));
            Console.WriteLine(p6.NormalizarCodigoProducto(null));

        }
    }
}
