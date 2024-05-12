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
        * Ordena un arreglo de enteros usando el algoritmo Bubble Sort y devuelve una lista con el resultado ordenado.
        *
        * @param numbers El arreglo de enteros a ordenar.
        * @return Una lista que contiene el arreglo ordenado.
        */
        public List<int> Sort(int[] numbers)
        {
            Console.WriteLine("Executing Bubble Sort... ");

            // Obtiene la longitud del arreglo.
            int n = numbers.Length;

            // Crea una lista vacía para almacenar el resultado ordenado.
            List<int> sortedNumbers = new List<int>();

            // Bucle externo: controla el número de pasadas por el arreglo.
            for (int i = 0; i < n - 1; i++)
            {
                // Indicador de cambio: se inicializa en falso y se actualiza si se realiza alguna permutación.
                bool hasChanged = false;

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

                        // Actualiza el indicador de cambio para indicar que se realizó una permutación.
                        hasChanged = true;
                    }
                }

                // Si no se realizaron permutaciones en la pasada actual, se puede terminar el bucle externo.
                if (!hasChanged)
                {
                    break;
                }
            }

            // **Agrega los elementos ordenados a la lista:**
            foreach (int number in numbers)
            {
                sortedNumbers.Add(number);
            }

            
            Console.WriteLine("Sorted numbers: \n");
            // Imprime el contenido de la lista ordenada.
           
            foreach (var number in sortedNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            // **Devuelve la lista con el resultado ordenado:**
            return sortedNumbers;
        }
    }


}
