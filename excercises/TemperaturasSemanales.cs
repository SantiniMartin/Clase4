using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.excercises
{
    internal class TemperaturasSemanales
    {
        public static void Ejecutar()
        {
            Random random = new Random();
            int[,] temperaturas = new int[5, 7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Llenar matriz con valores aleatorios (7 a 38)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    temperaturas[i, j] = random.Next(7, 39);
                }
            }

            Console.WriteLine("Temperaturas registradas (°C):\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Semana {i + 1}: ");
                for (int j = 0; j < 7; j++)
                    Console.Write($"{temperaturas[i, j]} ");
                Console.WriteLine();
            }

            int tempMaxMes = int.MinValue, tempMinSemana, tempMaxSemana, diaMaxMes = 0, semanaMaxMes = 0;

            for (int i = 0; i < 5; i++)
            {
                tempMinSemana = int.MaxValue;
                tempMaxSemana = int.MinValue;
                int suma = 0;

                for (int j = 0; j < 7; j++)
                {
                    int temp = temperaturas[i, j];
                    suma += temp;

                    if (temp > tempMaxSemana) tempMaxSemana = temp;
                    if (temp < tempMinSemana) tempMinSemana = temp;

                    if (temp > tempMaxMes)
                    {
                        tempMaxMes = temp;
                        diaMaxMes = j;
                        semanaMaxMes = i;
                    }
                }

                double promedio = suma / 7.0;
                Console.WriteLine($"\nSemana {i + 1} -> Máx: {tempMaxSemana}°C, Mín: {tempMinSemana}°C, Promedio: {promedio:F2}°C");
            }

            Console.WriteLine($"\nTemperatura más alta del mes: {tempMaxMes}°C (Semana {semanaMaxMes + 1}, {dias[diaMaxMes]})");
        }
    }
}
