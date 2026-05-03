namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Coca cola", 2000);
            Console.WriteLine(etiqueta);
        }
    }
}
