using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class DiccionarioNotas
    {
        public static void Ejecutar()
        {
            Dictionary<string, double> notas = new Dictionary<string, double>();
            string nombre;

            Console.WriteLine("Ingrese nombre del alumno y su nota ('fin' para terminar):");

            while (true)
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                if (nombre.ToLower() == "fin") break;

                Console.Write("Nota: ");
                double nota = double.Parse(Console.ReadLine());
                notas[nombre] = nota;
            }

            if (notas.Count == 0)
            {
                Console.WriteLine("No se ingresaron datos.");
                return;
            }

            double promedio = notas.Values.Average();
            var mejor = notas.OrderByDescending(n => n.Value).First();
            var peor = notas.OrderBy(n => n.Value).First();

            Console.WriteLine($"\nPromedio general: {promedio:F2}");
            Console.WriteLine($"Mejor alumno: {mejor.Key} ({mejor.Value})");
            Console.WriteLine($"Peor alumno: {peor.Key} ({peor.Value})");
        }
    }
}
