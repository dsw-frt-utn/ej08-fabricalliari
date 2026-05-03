namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {   //--------Pruebas Problema 1-------\\
            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Coca cola", 2000);
            Console.WriteLine(etiqueta);
            //--------Pruebas Problema 2
            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(1000,"Pepsi Black",2,300m));
        }
    }
}
