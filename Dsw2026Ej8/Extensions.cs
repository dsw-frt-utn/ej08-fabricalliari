using System.Reflection.Metadata.Ecma335;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string productCode)
        {
            if (productCode == null) return "SIN-CODIGO";
            string resultado = productCode.Trim().ToUpper().Replace(" ", "-");
            return resultado;

        }
    }
}
