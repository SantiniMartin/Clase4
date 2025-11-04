using Clase4.excercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.utils
{
    internal class Menu
    {
        public static void Ejecutar()
        {
            int opcion;

            do
            {
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Promedio de examenes");
                Console.WriteLine("2. Edades");
                Console.WriteLine("3. Nombre largo / corto");
                Console.WriteLine("4. Lista de supermercado");
                Console.WriteLine("5. Matriz Par e impar");
                Console.WriteLine("6. Temperaturas semanales");
                Console.WriteLine("7. Tabla de multiplicar");
                Console.WriteLine("8. Buscar en X");
                Console.WriteLine("9. Diccionario de notas");
                Console.WriteLine("10. Cola de banco");
                Console.WriteLine("11. Gestion de inventario");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción: ");

                // Validación segura de entrada
                bool esValido = int.TryParse(Console.ReadLine(), out opcion);

                if (!esValido)
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        PromedioExamenes.Ejecutar();
                        break;
                    case 2:
                        EdadesMayoresMenores.Ejecutar();
                        break;
                    case 3:
                        NombresLargoCorto.Ejecutar();
                        break;
                    case 4:
                        ListaSupermercado.Ejecutar();
                        break;
                    case 5:
                        MatrizImparPar.Ejecutar();
                        break;
                    case 6:
                        TemperaturasSemanales.Ejecutar();
                        break;
                    case 7:
                        TablaMultiplicar.Ejecutar();
                        break;
                    case 8:
                        BuscarX.Ejecutar();
                        break;
                    case 9:
                        DiccionarioNotas.Ejecutar();
                        break;
                    case 10:
                        ColaDeBanco.Ejecutar();
                        break;
                    case 11:
                        Inventario.Ejecutar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

            } while (opcion != 0);
        }
    }
}
