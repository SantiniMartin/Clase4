using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class ColaDeBanco
    {
        public static void Ejecutar()
        {
            Queue<string> cola = new Queue<string>();
            Console.WriteLine("Ingrese nombres de clientes (escriba 'fin' para terminar):");

            while (true)
            {
                string cliente = Console.ReadLine();
                if (cliente.ToLower() == "fin") break;
                cola.Enqueue(cliente);
            }

            Console.WriteLine("\nAtención en ventanilla:\n");

            while (cola.Count > 0)
            {
                string atendido = cola.Dequeue();
                Console.WriteLine($"Atendiendo a: {atendido}. Quedan {cola.Count} en la fila.");
            }

            Console.WriteLine("\nTodos los clientes fueron atendidos.");
        }
    }
}
