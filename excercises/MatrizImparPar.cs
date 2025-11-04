using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class MatrizImparPar
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== Matriz 5x5 con 'I' y 'P' ===\n");

            char[,] matriz = new char[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i + j) % 2 == 0)
                        matriz[i, j] = 'P';
                    else
                        matriz[i, j] = 'I';
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
