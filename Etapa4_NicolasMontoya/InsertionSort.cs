using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa4_NicolasMontoya
{
    public class InsertionSort
    {
        /**
         * Ordena un arreglo de enteros usando el algoritmo Insertion Sort.
         * 
         * @param numbers El arreglo de enteros a ordenar.
         */
        public void Sort(int[] numbers)
        {
            Console.WriteLine("Executing Insertion Sort...");

            int n = numbers.Length;

            // Recorre el arreglo desde el segundo elemento hasta el final.
            for (int i = 1; i < n; ++i)
            {
                // Elemento actual que se va a insertar.
                int key = numbers[i];

                // Índice del elemento anterior 
                int j = i - 1;

                // Mientras j sea mayor o igual a cero y el elemento anterior sea mayor que el elemento actual
                while (j >= 0 && numbers[j] > key)
                {
                    // Desplaza el elemento anterior un puesto a la derecha.
                    numbers[j + 1] = numbers[j];

                    // Desplaza el índice del elemento anterior una posición hacia atrás.
                    j = j - 1;
                }

                // Inserta el elemento actual en la posición correcta
                numbers[j + 1] = key;
            }

            
            Console.WriteLine("Sorted numbers: ");

            // Imprime el contenido del arreglo ordenado.
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }

}
