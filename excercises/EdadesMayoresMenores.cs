using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class EdadesMayoresMenores
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Edades de 20 personas ===\n");

            List<int> edades = new List<int>();
            int mayores = 0, menores = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"Ingrese la edad de la persona {i}: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                edades.Add(edad);
                if (edad >= 18) mayores++;
                else menores++;
            }

            Console.WriteLine($"\nMayores de edad: {mayores}");
            Console.WriteLine($"Menores de edad: {menores}");
            Console.ReadKey();
        }
    }
}
