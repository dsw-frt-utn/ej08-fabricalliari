namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            var notas = new List<int?> { nota1, nota2, nota3 };


            var validas = notas.Where(n => n.HasValue && n.Value >= 0 && n.Value <= 10);
            int cantidad = validas.Count();
            double suma = validas.Sum(n => n.Value);
            if (cantidad == 0) { return 0; }
            double promedio = suma / cantidad;
            return promedio;



        }
    }
}