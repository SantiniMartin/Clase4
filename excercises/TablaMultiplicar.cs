using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class TablaMultiplicar
    {
        public static void Ejecutar()
        {
            int[,] tabla = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0) tabla[i, j] = j;
                    else if (j == 0) tabla[i, j] = i;
                    else tabla[i, j] = i * j;
                }
            }

            Console.WriteLine("Matriz de Tablas del 1 al 9:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{tabla[i, j],4}");
                Console.WriteLine();
            }
        }
    }
}
