using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_NicolasMontoya
{
    public class ShellSort
    {
        /**
        * Ordena un arreglo de enteros usando el algoritmo Shell Sort y devuelve una lista con el resultado ordenado.
        *
        * @param numbers El arreglo de enteros a ordenar.
        * @return Una lista que contiene el arreglo ordenado.
        */
        public List<int> Sort(int[] numbers)
        {
            Console.WriteLine("Executing Shell Sort... \n ");

            int n = numbers.Length;

            // Crea una lista vacía para almacenar el resultado ordenado.
            List<int> sortedNumbers = new List<int>();

            // Intervalo inicial para la ordenación por subarreglos.
            for (int gap = n / 2; gap > 0; gap /= 2)
            {

                for (int i = gap; i < n; i += 1)
                {
                    // Elemento actual que se va a insertar.
                    int temp = numbers[i];

                    // Índice para la inserción dentro del subarreglo.
                    int j;

                    // Inserta el elemento actual en su posición correcta dentro del subarreglo definido por el gap.
                    for (j = i; j >= gap && numbers[j - gap] > temp; j -= gap)
                    {
                        // Desplaza el elemento anterior en el subarreglo hacia adelante.
                        numbers[j] = numbers[j - gap];
                    }
                    // Verifica si temp ya existe en la lista ordenada dentro del rango actual
                    if (!sortedNumbers.Contains(temp) && j >= gap)
                    {
                        // Agrega el elemento actual a la lista ordenada
                        sortedNumbers.Add(temp);
                    }
                }

            }

            

            Console.WriteLine("Sorted numbers: \n ");

            // Imprime el contenido de la lista ordenada.
            foreach (var number in sortedNumbers)
            {
                Console.Write($"{number} ");
            }

            // **Devuelve la lista con el resultado ordenado:**
            return sortedNumbers;
        }
    }


}
