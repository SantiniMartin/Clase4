using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class NombresLargoCorto
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Nombre con más y menos letras ===\n");

            List<string> nombres = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese el nombre {i}: ");
                nombres.Add(Console.ReadLine() ?? "");
            }

            string masLargo = nombres.OrderByDescending(n => n.Length).First();
            string masCorto = nombres.OrderBy(n => n.Length).First();

            Console.WriteLine($"\nNombre más largo: {masLargo} ({masLargo.Length} letras)");
            Console.WriteLine($"Nombre más corto: {masCorto} ({masCorto.Length} letras)");
            Console.ReadKey();
        }
    }
}
