using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class Inventario
    {
        public static void Ejecutar()
        {
            List<string> productos = new List<string>();
            Dictionary<string, int> stock = new Dictionary<string, int>();
            Stack<string> historial = new Stack<string>();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== INVENTARIO =====");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Vender producto");
                Console.WriteLine("3. Mostrar inventario");
                Console.WriteLine("4. Ver últimas 3 acciones");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Cantidad: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        if (!stock.ContainsKey(nombre))
                        {
                            productos.Add(nombre);
                            stock[nombre] = cantidad;
                        }
                        else
                            stock[nombre] += cantidad;

                        historial.Push($"Agregado {cantidad} de {nombre}");
                        Console.WriteLine("✅ Producto agregado.");
                        break;

                    case 2:
                        Console.Write("Producto a vender: ");
                        string venta = Console.ReadLine();

                        if (stock.ContainsKey(venta) && stock[venta] > 0)
                        {
                            stock[venta]--;
                            historial.Push($"Vendido 1 de {venta}");
                            Console.WriteLine("✅ Venta realizada.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Producto no disponible o sin stock.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nInventario actual:");
                        foreach (var p in stock)
                            Console.WriteLine($"{p.Key}: {p.Value}");
                        break;

                    case 4:
                        Console.WriteLine("\nÚltimas 3 acciones:");
                        foreach (var accion in historial.Take(3))
                            Console.WriteLine($"- {accion}");
                        break;

                    case 5:
                        Console.WriteLine("👋 Saliendo del inventario...");
                        break;

                    default:
                        Console.WriteLine("⚠️ Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 5);
        }
    }
}
