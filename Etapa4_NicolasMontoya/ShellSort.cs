using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_NicolasMontoya
{
    using System;
    using System.Collections.Generic;

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

            // Copia el arreglo original para no modificarlo directamente.
            int[] sortedArray = new int[n];
            Array.Copy(numbers, sortedArray, n);

            // Intervalo inicial para la ordenación por subarreglos.
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    // Elemento actual que se va a insertar.
                    int temp = sortedArray[i];

                    // Índice para la inserción dentro del subarreglo.
                    int j;

                    // Inserta el elemento actual en su posición correcta dentro del subarreglo definido por el gap.
                    for (j = i; j >= gap && sortedArray[j - gap] > temp; j -= gap)
                    {
                        // Desplaza el elemento anterior en el subarreglo hacia adelante.
                        sortedArray[j] = sortedArray[j - gap];
                    }
                    // Inserta el elemento actual en su posición correcta.
                    sortedArray[j] = temp;
                }
            }

            Console.WriteLine("Sorted numbers: \n ");

            // Convierte el arreglo ordenado en una lista para devolverla.
            List<int> sortedNumbers = new List<int>(sortedArray);

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
