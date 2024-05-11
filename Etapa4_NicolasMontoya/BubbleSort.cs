using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_NicolasMontoya
{
    public class BubbleSort
    {
        /**
         * Ordena un arreglo de enteros usando el algoritmo Bubble Sort.
         * 
         * @param numbers El arreglo de enteros a ordenar.
         */
        public void Sort(int[] numbers)
        {
            Console.WriteLine("Executing Bubble Sort... \n");

            // Obtiene la longitud del arreglo.
            int n = numbers.Length;

            // Bucle externo: controla el número de pasadas por el arreglo.
            for (int i = 0; i < n - 1; i++)
            {
                // Bucle interno: compara elementos adyacentes y los intercambia si están desordenados.
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Comprueba si el elemento actual es mayor que el siguiente.
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Almacena el elemento actual en una variable temporal.
                        int temp = numbers[j];

                        // Reemplaza el elemento actual con el siguiente.
                        numbers[j] = numbers[j + 1];

                        // Reemplaza el siguiente elemento con el elemento temporal (que era el actual).
                        numbers[j + 1] = temp;
                    }
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
