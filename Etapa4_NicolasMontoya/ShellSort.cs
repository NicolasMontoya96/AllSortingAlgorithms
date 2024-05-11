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
         * Ordena un arreglo de enteros usando el algoritmo Shell Sort.
         * 
         * @param numbers El arreglo de enteros a ordenar.
         */
        public void Sort(int[] numbers)
        {

            Console.WriteLine("Executing Shell Sort... \n ");

            int n = numbers.Length;

            // Intervalo inicial para la ordenación por subarreglos.
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                // Recorre el arreglo desde el valor del gap hasta el final.
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

                    // Inserta el elemento actual en la posición correcta del subarreglo.
                    numbers[j] = temp;
                }
            }

            Console.WriteLine("Sorted numbers: \n ");

            // Imprime el contenido del arreglo ordenado.
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }

}
