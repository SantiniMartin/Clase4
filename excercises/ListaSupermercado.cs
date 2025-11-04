using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class ListaSupermercado
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Lista de supermercado ===\n");

            List<string> lista = new List<string> { "pan", "leche", "huevos", "arroz", "fideos" };
            List<string> compradosFuera = new List<string>();
            List<string> noComprados = new List<string>(lista);

            string? item;

            do
            {
                Console.Write("\nIngrese un producto que compró (o 'fin' para terminar): ");
                item = Console.ReadLine()?.ToLower();

                if (item == "fin") break;
                if (string.IsNullOrWhiteSpace(item)) continue;

                if (lista.Contains(item))
                {
                    Console.WriteLine($"'{item}' estaba en la lista, se marca como comprado.");
                    noComprados.Remove(item);
                }
                else
                {
                    Console.WriteLine($"'{item}' no estaba en la lista, se agrega.");
                    compradosFuera.Add(item);
                }

            } while (true);

            Console.WriteLine("\n--- Resumen ---");
            Console.WriteLine("Elementos NO comprados:");
            foreach (var n in noComprados) Console.WriteLine($"- {n}");
            Console.WriteLine("\nElementos comprados que NO estaban en la lista:");
            foreach (var c in compradosFuera) Console.WriteLine($"- {c}");

            Console.ReadKey();
        }
    }
}
