using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_NicolasMontoya
{
    public class SelectionSort
    {
        /**
         * Ordena un arreglo de enteros usando el algoritmo Selection Sort.
         * 
         * @param numbers El arreglo de enteros a ordenar.
         */
        public List<int> Sort(int[] numbers)
        {

            Console.WriteLine("Executing Selection Sort... \n ");

            int n = numbers.Length;

            // Crea una lista vacía para almacenar el resultado ordenado.
            List<int> sortedNumbers = new List<int>();

            // Recorre el arreglo desde el primer elemento hasta el penúltimo.
            for (int i = 0; i < n - 1; i++)
            {
                // Almacena el índice del elemento mínimo encontrado hasta el momento.
                int minIndex = i;

                // Recorre el arreglo desde el elemento siguiente al actual hasta el final.
                for (int j = i + 1; j < n; j++)
                {
                    // Comprueba si el elemento actual (j) es menor que el elemento mínimo encontrado.
                    if (numbers[j] < numbers[minIndex])
                    {
                        // Actualiza el índice del elemento mínimo.
                        minIndex = j;
                    }
                }

                // Si se encontró un elemento mínimo en la parte sin ordenar, intercambia su posición con el elemento actual
                if (minIndex != i)
                {
                    int temp = numbers[minIndex];
                    numbers[minIndex] = numbers[i];
                    numbers[i] = temp;
                }
            }

            // Agrega los elementos ordenados a la lista.
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

            // Devuelve la lista con el resultado ordenado.
            return sortedNumbers;
        }
    }

}
