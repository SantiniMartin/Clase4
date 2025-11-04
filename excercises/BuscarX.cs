using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class BuscarX
    {
        public static void Ejecutar()
        {
            Random random = new Random();
            char[,] matriz = new char[10, 10];
            int totalCeldas = 100;
            int cantidadX = random.Next(5, 50); // No más de la mitad
            int intentosFallidos = 0;
            int aciertos = 0;

            // Llenar matriz con '*'
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    matriz[i, j] = '*';

            // Esconder X
            for (int k = 0; k < cantidadX; k++)
            {
                int fila, col;
                do
                {
                    fila = random.Next(10);
                    col = random.Next(10);
                } while (matriz[fila, col] == 'X');
                matriz[fila, col] = 'X';
            }

            Console.WriteLine("¡Bienvenido al juego de las X!");
            Console.WriteLine($"Hay {cantidadX} X escondidas. Tenés 3 intentos para fallar.\n");

            char[,] visible = new char[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    visible[i, j] = '*';

            while (intentosFallidos < 3 && aciertos < cantidadX)
            {
                Console.Write("Ingrese fila (0-9): ");
                int fila = int.Parse(Console.ReadLine());
                Console.Write("Ingrese columna (0-9): ");
                int col = int.Parse(Console.ReadLine());

                if (matriz[fila, col] == 'X')
                {
                    Console.WriteLine("¡Acertaste!");
                    visible[fila, col] = 'X';
                    aciertos++;
                }
                else
                {
                    Console.WriteLine("Fallaste.");
                    intentosFallidos++;
                }

                Console.WriteLine($"Intentos fallidos: {intentosFallidos}/3\n");
            }

            Console.WriteLine("\nResultado final:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{matriz[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}
