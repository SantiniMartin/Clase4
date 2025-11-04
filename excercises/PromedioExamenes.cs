using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class PromedioExamenes
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== Promedio de Notas ===");
            List<double> notas = new List<double>();
            string continuar;

            do
            {
                double nota;

                // Validación del ingreso
                while (true)
                {
                    Console.Write("Ingrese una nota (0 a 10): ");
                    if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                    {
                        break; // nota válida
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un número válido entre 0 y 10.");
                    }
                }

                notas.Add(nota);

                Console.Write("¿Desea ingresar otra nota? (s/n): ");
                continuar = Console.ReadLine()!.ToLower();

            } while (continuar == "s");

            if (notas.Count > 0)
            {
                double promedio = notas.Average();
                Console.WriteLine($"\nEl promedio de las {notas.Count} notas ingresadas es: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("No se ingresaron notas.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
