using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Etapa4_NicolasMontoya
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Shell Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Insertion Sort");
                Console.WriteLine("5. Apply All Sorting Algorithms");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetNumbers(numbers);
                        BubbleSort(numbers);
                        break;
                    case "2":
                        GetNumbers(numbers);
                        ShellSort(numbers);
                        break;
                    case "3":
                        GetNumbers(numbers);
                        SelectionSort(numbers);
                        break;
                    case "4":
                        GetNumbers(numbers);
                        InsertionSort(numbers);
                        break;
                    case "5":
                        GetNumbers(numbers);
                        ApplyAllSortingAlgorithms(numbers);
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void GetNumbers(int[] numbers)
        {
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                string input = Console.ReadLine().Trim(); // Eliminar espacios en blanco al principio y al final

                if (string.IsNullOrEmpty(input) || !input.All(char.IsDigit))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Reintentar la entrada del número actual
                    continue;
                }

                try
                {
                    numbers[i] = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Reintentar la entrada del número actual
                }
            }
        }


        static void BubbleSort(int[] numbers)
        {
            Console.WriteLine("Executing Bubble Sort...");
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted numbers: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void ShellSort(int[] numbers)
        {
            Console.WriteLine("Executing Shell Sort...");
            int n = numbers.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = numbers[i];
                    int j;
                    for (j = i; j >= gap && numbers[j - gap] > temp; j -= gap)
                    {
                        numbers[j] = numbers[j - gap];
                    }
                    numbers[j] = temp;
                }
            }

            Console.WriteLine("Sorted numbers: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void SelectionSort(int[] numbers)
        {

            Console.WriteLine("Executing Selection Sort...");
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }

            Console.WriteLine("Sorted numbers: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void InsertionSort(int[] numbers)
        {

            Console.WriteLine("Executing Insertion Sort...");
            int n = numbers.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j = j - 1;
                }
                numbers[j + 1] = key;
            }

            Console.WriteLine("Sorted numbers: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        static void ApplyAllSortingAlgorithms(int[] numbers)
        {
            Console.WriteLine("Applying all sorting algorithms...");
            Console.WriteLine();

            Console.WriteLine("Bubble Sort:");
            BubbleSort(numbers);
            PrintSortedArray(numbers); // Función para imprimir el arreglo ordenado

            Console.WriteLine("\nShell Sort:");
            ShellSort(numbers);
            PrintSortedArray(numbers);

            Console.WriteLine("\nSelection Sort:");
            SelectionSort(numbers);
            PrintSortedArray(numbers);

            Console.WriteLine("\nInsertion Sort:");
            InsertionSort(numbers);
            PrintSortedArray(numbers);
        }

        static void PrintSortedArray(int[] numbers)
        {
            Console.WriteLine("Sorted numbers: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }


    }
}


